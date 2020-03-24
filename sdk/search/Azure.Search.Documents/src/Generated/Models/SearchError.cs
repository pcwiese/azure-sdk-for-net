// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Documents.Models
{
    /// <summary> Describes an error condition for the Azure Cognitive Search API. </summary>
    internal partial class SearchError
    {
        /// <summary> Initializes a new instance of SearchError. </summary>
        /// <param name="message"> A human-readable representation of the error. </param>
        internal SearchError(string message)
        {
            Message = message;
        }

        /// <summary> Initializes a new instance of SearchError. </summary>
        /// <param name="code"> One of a server-defined set of error codes. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <param name="details"> An array of details about specific errors that led to this reported error. </param>
        internal SearchError(string code, string message, IReadOnlyList<SearchError> details)
        {
            Code = code;
            Message = message;
            Details = details;
        }

        /// <summary> One of a server-defined set of error codes. </summary>
        public string Code { get; }
        /// <summary> A human-readable representation of the error. </summary>
        public string Message { get; }
        /// <summary> An array of details about specific errors that led to this reported error. </summary>
        public IReadOnlyList<SearchError> Details { get; }
    }
}