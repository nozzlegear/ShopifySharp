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
    public sealed class FulfillmentOrderCancelErrorQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderCancelError, FulfillmentOrderCancelErrorQueryBuilder>
    {
        protected override FulfillmentOrderCancelErrorQueryBuilder Self => this;

        public FulfillmentOrderCancelErrorQueryBuilder() : this("fulfillmentOrderCancelError")
        {
        }

        public FulfillmentOrderCancelErrorQueryBuilder(string name) : base(new Query<FulfillmentOrderCancelError>(name))
        {
        }

        public FulfillmentOrderCancelErrorQueryBuilder(IQuery<FulfillmentOrderCancelError> query) : base(query)
        {
        }

        public FulfillmentOrderCancelErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FulfillmentOrderCancelErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FulfillmentOrderCancelErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}