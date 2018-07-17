﻿namespace Microsoft.Bot.Schema
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Activity is the basic communication type for the Bot Framework 3.0
    /// protocol
    /// </summary>
    public partial class Activity
    {
        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        public Activity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        /// <param name="type">The <see cref="ActivityTypes"/>type of the activity.</param>
        /// <seealso cref="ActivityTypes"/>
        public Activity(string type)
        {
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of the activity. Possible values include:
        /// 'message', 'contactRelationUpdate', 'conversationUpdate', 'typing',
        /// 'ping', 'endOfConversation', 'event', 'invoke', 'deleteUserData',
        /// 'messageUpdate', 'messageDelete', 'installationUpdate',
        /// 'messageReaction', 'suggestion', 'trace'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets ID of this activity
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets UTC Time when message was sent (set by service)
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets local time when message was sent (set by client, Ex:
        /// 2016-09-23T13:07:49.4714686-07:00)
        /// </summary>
        [JsonProperty(PropertyName = "localTimestamp")]
        public System.DateTimeOffset? LocalTimestamp { get; set; }

        /// <summary>
        /// Gets or sets service endpoint where operations concerning the
        /// activity may be performed
        /// </summary>
        [JsonProperty(PropertyName = "serviceUrl")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Gets or sets ID of the channel where the activity was sent
        /// </summary>
        [JsonProperty(PropertyName = "channelId")]
        public string ChannelId { get; set; }

        /// <summary>
        /// Gets or sets sender address
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public ChannelAccount From { get; set; }

        /// <summary>
        /// Gets or sets conversation
        /// </summary>
        [JsonProperty(PropertyName = "conversation")]
        public ConversationAccount Conversation { get; set; }

        /// <summary>
        /// Gets or sets (Outbound to bot only) Bot's address that received the
        /// message
        /// </summary>
        [JsonProperty(PropertyName = "recipient")]
        public ChannelAccount Recipient { get; set; }        
       
        /// <summary>
        /// Gets or sets collection of Entity objects, each of which contains
        /// metadata about this activity. Each Entity object is typed.
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        public IList<Entity> Entities { get; set; }

        /// <summary>
        /// Gets or sets channel-specific payload
        /// </summary>
        [JsonProperty(PropertyName = "channelData")]
        public object ChannelData { get; set; }

        /// <summary>
        /// Gets or sets the original ID this activity is a response to
        /// </summary>
        [JsonProperty(PropertyName = "replyToId")]
        public string ReplyToId { get; set; }

        /// <summary>
        /// Gets or sets descriptive label
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
       

        /// <summary>
        /// Gets or sets importance of this activity
        /// {Low|Normal|High}, null value indicates Normal importance see
        /// ActivityImportance)
        /// </summary>
        [JsonProperty(PropertyName = "importance")]
        public string Importance { get; set; }

        /// <summary>
        /// Gets or sets hint to describe how this activity should be
        /// delivered.
        /// Currently: null or "Default" = default delivery
        /// "Notification" = notification semantics
        /// </summary>
        [JsonProperty(PropertyName = "deliveryMode")]
        public string DeliveryMode { get; set; }        
    }
}
