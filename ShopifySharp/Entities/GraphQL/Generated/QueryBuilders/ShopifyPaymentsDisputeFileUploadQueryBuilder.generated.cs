#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ShopifyPaymentsDisputeFileUploadQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsDisputeFileUpload>("shopifyPaymentsDisputeFileUpload")
{
    public ShopifyPaymentsDisputeFileUploadQueryBuilder AddFieldDisputeEvidenceType()
    {
        AddField("disputeEvidenceType");
        return this;
    }

    public ShopifyPaymentsDisputeFileUploadQueryBuilder AddFieldFileSize()
    {
        AddField("fileSize");
        return this;
    }

    public ShopifyPaymentsDisputeFileUploadQueryBuilder AddFieldFileType()
    {
        AddField("fileType");
        return this;
    }

    public ShopifyPaymentsDisputeFileUploadQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopifyPaymentsDisputeFileUploadQueryBuilder AddFieldOriginalFileName()
    {
        AddField("originalFileName");
        return this;
    }

    public ShopifyPaymentsDisputeFileUploadQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}