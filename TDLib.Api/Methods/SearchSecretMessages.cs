using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class SearchSecretMessages : Method<FoundMessages>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "searchSecretMessages";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonConverter(typeof(Converter.Int64))]
        [JsonProperty("from_search_id")]
        public Int64 FromSearchId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("filter")]
        public SearchMessagesFilter Filter { get; set; }

    }

}