﻿namespace Fabric.Metadata.FileService.Client.Events
{
    using System;
    using System.ComponentModel;

    public class UploadErrorEventArgs : CancelEventArgs
    {
        public UploadErrorEventArgs(int resourceId, Uri fullUri, string statusCode, string response)
        {
            this.FullUri = fullUri;
            this.StatusCode = statusCode;
            this.Response = response;
            this.ResourceId = resourceId;
        }

        public string Response { get; set; }
        public int ResourceId { get; }
        public string StatusCode { get; set; }

        public Uri FullUri { get; set; }
    }
}