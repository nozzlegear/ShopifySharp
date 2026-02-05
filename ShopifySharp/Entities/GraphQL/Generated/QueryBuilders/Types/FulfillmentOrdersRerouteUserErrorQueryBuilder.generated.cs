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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class FulfillmentOrdersRerouteUserErrorQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrdersRerouteUserError, FulfillmentOrdersRerouteUserErrorQueryBuilder>
    {
        protected override FulfillmentOrdersRerouteUserErrorQueryBuilder Self => this;

        public FulfillmentOrdersRerouteUserErrorQueryBuilder() : this("fulfillmentOrdersRerouteUserError")
        {
        }

        public FulfillmentOrdersRerouteUserErrorQueryBuilder(string name) : base(new Query<FulfillmentOrdersRerouteUserError>(name))
        {
        }

        public FulfillmentOrdersRerouteUserErrorQueryBuilder(IQuery<FulfillmentOrdersRerouteUserError> query) : base(query)
        {
        }

        public FulfillmentOrdersRerouteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FulfillmentOrdersRerouteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FulfillmentOrdersRerouteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}