﻿// <auto-generated />
namespace WindowsUniversalAppDriver.Common
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class JsonWebElementContent
    {
        #region Constructors and Destructors

        public JsonWebElementContent(string element)
        {
            this.Element = element;
        }

        #endregion

        #region Public Properties

        [JsonProperty("ELEMENT")]
        public string Element { get; set; }

        #endregion
    }

    public class JsonResponse
    {
        #region Constructors and Destructors

        public JsonResponse(string sessionId, ResponseStatus responseCode, object value)
        {
            this.SessionId = sessionId;
            this.Status = responseCode;
            this.Value = value;
        }

        #endregion

        #region Public Properties

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("status")]
        public ResponseStatus Status { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }

        #endregion
    }
}
