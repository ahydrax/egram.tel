using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public class UpdateUserFullInfo : Update
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateUserFullInfo";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int UserId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_full_info")]
                public UserFullInfo UserFullInfo { get; set; }

        }

    }

}