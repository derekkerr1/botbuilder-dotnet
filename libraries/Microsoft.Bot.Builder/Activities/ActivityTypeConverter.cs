﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Microsoft.Bot.Schema
{
    /// <summary>
    /// Utility methods for converting from activity schema representations to runtime representations.
    /// </summary>
    public static class ActivityTypeConverter
    {
        /// <summary>
        /// Given an <paramref name="activityType">activity type</paramref>, returns the corresponding <see cref="Type"/>.
        /// </summary>
        /// <remarks>
        /// If the specified value in <paramref name="activityType"/> is an unknown type, the runtime type returned 
        /// will be <see cref="Activity"/>.
        /// </remarks>
        /// <param name="activityType">The activity type.</param>
        /// <returns>
        /// The runtime type for the specified <paramref name="activityType">activity type</paramref>. If there is no matching runtime type, then just <see cref="Activity"/> will be returned.</returns>
        public static Type GetRuntimeType(string activityType)
        {
            /*
             * TODO: this is extremely brittle and not a great maintenance story. Consider a dynamic approach where
             * Activity classes are marked with an attribute that indicates their schema type name and then lazily assembly
             * scan for those on first call to this method and build/cache a dictionary lookup for subsequent calls.
             */

            switch (activityType)
            {
                case ActivityTypes.ConversationUpdate:
                    return typeof(ConversationUpdateActivity);

                case ActivityTypes.ContactRelationUpdate:
                    return typeof(ContactRelationUpdateActivity);

                case ActivityTypes.DeleteUserData:
                    return typeof(DeleteUserDataActivity);

                case ActivityTypes.EndOfConversation:
                    return typeof(EndOfConversationActivity);

                case ActivityTypes.Event:
                    return typeof(EventActivity);

                case ActivityTypes.InstallationUpdate:
                    return typeof(InstallationUpdateActivity);

                case ActivityTypes.Invoke:
                    return typeof(InvokeActivity);

                case ActivityTypes.Message:
                    return typeof(MessageActivity);

                case ActivityTypes.MessageDelete:
                    return typeof(MessageDeleteActivity);

                case ActivityTypes.MessageReaction:
                    return typeof(MessageReactionActivity);

                case ActivityTypes.MessageUpdate:
                    return typeof(MessageUpdateActivity);

                case ActivityTypes.Ping:
                    return typeof(PingActivity);

                case ActivityTypes.Suggestion:
                    return typeof(SuggestionActivity);

                case ActivityTypes.Trace:
                    return typeof(TraceActivity);

                case ActivityTypes.Typing:
                    return typeof(TypingActivity);

                default:
                    // TODO: trace a warning that we didn't find a specific type

                    return typeof(Activity);
            }
        }
    }
}