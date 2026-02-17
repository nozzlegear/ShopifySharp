#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ShopifyPaymentsDisputeFileUploadQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDisputeFileUpload, ShopifyPaymentsDisputeFileUploadQueryBuilder>
    {
        protected override ShopifyPaymentsDisputeFileUploadQueryBuilder Self => this;

        public ShopifyPaymentsDisputeFileUploadQueryBuilder() : this("shopifyPaymentsDisputeFileUpload")
        {
        }

        public ShopifyPaymentsDisputeFileUploadQueryBuilder(string name) : base(new Query<ShopifyPaymentsDisputeFileUpload>(name))
        {
        }

        public ShopifyPaymentsDisputeFileUploadQueryBuilder(IQuery<ShopifyPaymentsDisputeFileUpload> query) : base(query)
        {
        }

        public ShopifyPaymentsDisputeFileUploadQueryBuilder DisputeEvidenceType()
        {
            base.InnerQuery.AddField("disputeEvidenceType");
            return this;
        }

        public ShopifyPaymentsDisputeFileUploadQueryBuilder FileSize()
        {
            base.InnerQuery.AddField("fileSize");
            return this;
        }

        public ShopifyPaymentsDisputeFileUploadQueryBuilder FileType()
        {
            base.InnerQuery.AddField("fileType");
            return this;
        }

        public ShopifyPaymentsDisputeFileUploadQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopifyPaymentsDisputeFileUploadQueryBuilder OriginalFileName()
        {
            base.InnerQuery.AddField("originalFileName");
            return this;
        }

        public ShopifyPaymentsDisputeFileUploadQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}