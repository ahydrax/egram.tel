using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class TestVectorInt : Structure
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "testVectorInt";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("value")]
        public int[] Value { get; set; }

    }

}