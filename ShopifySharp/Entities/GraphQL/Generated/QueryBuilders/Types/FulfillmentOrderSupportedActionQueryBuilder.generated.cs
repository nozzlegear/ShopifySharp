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
    public sealed class FulfillmentOrderSupportedActionQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderSupportedAction, FulfillmentOrderSupportedActionQueryBuilder>
    {
        protected override FulfillmentOrderSupportedActionQueryBuilder Self => this;

        public FulfillmentOrderSupportedActionQueryBuilder() : this("fulfillmentOrderSupportedAction")
        {
        }

        public FulfillmentOrderSupportedActionQueryBuilder(string name) : base(new Query<FulfillmentOrderSupportedAction>(name))
        {
        }

        public FulfillmentOrderSupportedActionQueryBuilder(IQuery<FulfillmentOrderSupportedAction> query) : base(query)
        {
        }

        public FulfillmentOrderSupportedActionQueryBuilder Action()
        {
            base.InnerQuery.AddField("action");
            return this;
        }

        public FulfillmentOrderSupportedActionQueryBuilder ExternalUrl()
        {
            base.InnerQuery.AddField("externalUrl");
            return this;
        }
    }
}