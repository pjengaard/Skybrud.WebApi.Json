﻿using System.Net;
using Newtonsoft.Json;

namespace Skybrud.WebApi.Json.Meta {

    public class JsonMetaData {

        /// <summary>
        /// Gets or sets the status code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public HttpStatusCode Code { get; set; }

        /// <summary>
        /// Gets or sets the error message. If the error message is
        /// <code>NULL</code>, the property will not be a part of the JSON
        /// response.
        /// </summary>
        [JsonProperty(PropertyName = "error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        internal JsonMetaData() {
            // Hide default constructor
        }

    }

}