#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class BulkProductResourceFeedbackCreateArgumentsBuilder : ArgumentsBuilderBase<BulkProductResourceFeedbackCreatePayload, BulkProductResourceFeedbackCreateArgumentsBuilder>
    {
        protected override BulkProductResourceFeedbackCreateArgumentsBuilder Self => this;

        public BulkProductResourceFeedbackCreateArgumentsBuilder(IQuery<BulkProductResourceFeedbackCreatePayload> query) : base(query)
        {
        }

        public BulkProductResourceFeedbackCreateArgumentsBuilder FeedbackInput(ICollection<ProductResourceFeedbackInput>? feedbackInput)
        {
            base.InnerQuery.AddArgument("feedbackInput", feedbackInput);
            return this;
        }
    }
}