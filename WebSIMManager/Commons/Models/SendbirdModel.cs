using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Channel
    {
        public string channel_url { get; set; }
        public string name { get; set; }
        public string cover_url { get; set; }
        public string data { get; set; }
        public int member_count { get; set; }
        public int joined_member_count { get; set; }
        public int max_length_message { get; set; }
        public int created_at { get; set; }
        public string custom_type { get; set; }
        public bool is_distinct { get; set; }
        public bool is_super { get; set; }
        public bool is_broadcast { get; set; }
        public bool is_public { get; set; }
        public bool is_discoverable { get; set; }
        public bool freeze { get; set; }
        public bool is_ephemeral { get; set; }
        public int unread_message_count { get; set; }
        public int unread_mention_count { get; set; }
        public bool ignore_profanity_filter { get; set; }
        public string id { get; set; }
        public Channel2 channel { get; set; }
        public string count_preference { get; set; }
        public CreatedBy created_by { get; set; }
        public DisappearingMessage disappearing_message { get; set; }
        public bool is_access_code_required { get; set; }
        public bool is_exclusive { get; set; }
        public bool is_muted { get; set; }
        public bool is_push_enabled { get; set; }
        public string member_state { get; set; }
        public int message_survival_seconds { get; set; }
        public string my_role { get; set; }
        public string push_trigger_option { get; set; }
        public SmsFallback sms_fallback { get; set; }
        public int ts_message_offset { get; set; }
        public long user_last_read { get; set; }
        public Inviter inviter { get; set; }
        public long invited_at { get; set; }
        public bool is_hidden { get; set; }
        public string hidden_state { get; set; }
        public LastMessage last_message { get; set; }
        public int joined_ts { get; set; }
        public object last_queried_message { get; set; }
    }

    public class Channel2
    {
        public string channel_url { get; set; }
        public string name { get; set; }
        public string cover_url { get; set; }
        public string data { get; set; }
        public int created_at { get; set; }
        public string custom_type { get; set; }
        public int max_length_message { get; set; }
        public int member_count { get; set; }
    }

    public class CreatedBy
    {
        public string user_id { get; set; }
        public string nickname { get; set; }
        public string profile_url { get; set; }
        public bool require_auth_for_profile_image { get; set; }
    }

    public class DisappearingMessage
    {
        public bool is_triggered_by_message_read { get; set; }
        public int message_survival_seconds { get; set; }
    }

    public class File
    {
    }

    public class Inviter
    {
        public string user_id { get; set; }
        public string nickname { get; set; }
        public string profile_url { get; set; }
        public bool require_auth_for_profile_image { get; set; }
        public Metadata metadata { get; set; }
    }

    public class LastMessage
    {
        public string type { get; set; }
        public long message_id { get; set; }
        public string message { get; set; }
        public string data { get; set; }
        public string custom_type { get; set; }
        public File file { get; set; }
        public long created_at { get; set; }
        public User user { get; set; }
        public string channel_url { get; set; }
        public int updated_at { get; set; }
        public int message_survival_seconds { get; set; }
        public List<object> mentioned_users { get; set; }
        public string mention_type { get; set; }
        public bool silent { get; set; }
        public int message_retention_hour { get; set; }
        public string channel_type { get; set; }
        public Translations translations { get; set; }
        public bool is_removed { get; set; }
        public string req_id { get; set; }
        public bool is_op_msg { get; set; }
        public MessageEvents message_events { get; set; }
    }

    public class MessageEvents
    {
        public string send_push_notification { get; set; }
        public bool update_unread_count { get; set; }
        public bool update_mention_count { get; set; }
        public bool update_last_message { get; set; }
    }

    public class Metadata
    {
    }

    public class MyGroupChannel
    {
        public List<Channel> channels { get; set; }
        public string next { get; set; }
        public long ts { get; set; }
    }

    public class SmsFallback
    {
        public int wait_seconds { get; set; }
        public List<object> exclude_user_ids { get; set; }
    }

    public class Translations
    {
    }

    public class User
    {
        public string user_id { get; set; }
        public string profile_url { get; set; }
        public bool require_auth_for_profile_image { get; set; }
        public string nickname { get; set; }
        public Metadata metadata { get; set; }
        public bool is_blocked_by_me { get; set; }
        public string role { get; set; }
        public bool is_active { get; set; }
    }


    //
    public class SendMesssageRequest
    {
        public string message_type { get; set; }
        public string user_id { get; set; }
        public string custom_type { get; set; }
        public string message { get; set; }
        public List<SortedMetaarray> sorted_metaarray { get; set; }
    }

    public class SortedMetaarray
    {
        public string key { get; set; }
        public List<string> value { get; set; }
    }
    //

    public class SendMesssageResponse
    {
        public string type { get; set; }
        public long message_id { get; set; }
        public string message { get; set; }
        public string data { get; set; }
        public string custom_type { get; set; }
        public File file { get; set; }
        public long created_at { get; set; }
        public User user { get; set; }
        public string channel_url { get; set; }
        public int updated_at { get; set; }
        public int message_survival_seconds { get; set; }
        public List<object> mentioned_users { get; set; }
        public string mention_type { get; set; }
        public bool silent { get; set; }
        public int message_retention_hour { get; set; }
        public string channel_type { get; set; }
        public Translations translations { get; set; }
        public List<SortedMetaarray> sorted_metaarray { get; set; }
        public bool is_removed { get; set; }
        public bool is_op_msg { get; set; }
        public MessageEvents message_events { get; set; }
    }

    public class Message
    {
        public string type { get; set; }
        public object message_id { get; set; }
        public string message { get; set; }
        public string data { get; set; }
        public string custom_type { get; set; }
        public File file { get; set; }
        public object created_at { get; set; }
        public User user { get; set; }
        public string channel_url { get; set; }
        public int updated_at { get; set; }
        public int message_survival_seconds { get; set; }
        public List<object> mentioned_users { get; set; }
        public string mention_type { get; set; }
        public bool silent { get; set; }
        public int message_retention_hour { get; set; }
        public string channel_type { get; set; }
        public Translations translations { get; set; }
        public bool is_removed { get; set; }
        public bool is_op_msg { get; set; }
        public OgTag og_tag { get; set; }
        public MessageEvents message_events { get; set; }
    }

    public class OgImage
    {
        public string url { get; set; }
    }

    public class OgTag
    {
        [JsonProperty("og:image")]
        public OgImage ogimage { get; set; }

        [JsonProperty("og:title")]
        public string ogtitle { get; set; }

        [JsonProperty("og:description")]
        public string ogdescription { get; set; }

        [JsonProperty("og:url")]
        public string ogurl { get; set; }
    }

    public class ListMessage
    {
        public List<Message> messages { get; set; }
    }
    public class MaskReadRequest
    {
        public string user_id { get; set; }
    }
}
