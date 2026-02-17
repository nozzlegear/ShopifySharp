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
    public sealed class FulfillmentOrderMergeUserErrorQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderMergeUserError, FulfillmentOrderMergeUserErrorQueryBuilder>
    {
        protected override FulfillmentOrderMergeUserErrorQueryBuilder Self => this;

        public FulfillmentOrderMergeUserErrorQueryBuilder() : this("fulfillmentOrderMergeUserError")
        {
        }

        public FulfillmentOrderMergeUserErrorQueryBuilder(string name) : base(new Query<FulfillmentOrderMergeUserError>(name))
        {
        }

        public FulfillmentOrderMergeUserErrorQueryBuilder(IQuery<FulfillmentOrderMergeUserError> query) : base(query)
        {
        }

        public FulfillmentOrderMergeUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FulfillmentOrderMergeUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FulfillmentOrderMergeUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}