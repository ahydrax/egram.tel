using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class OptionValue : Structure
    {

        public class OptionValueString : OptionValue
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "optionValueString";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("value")]
                public string Value { get; set; }

        }

    }

}