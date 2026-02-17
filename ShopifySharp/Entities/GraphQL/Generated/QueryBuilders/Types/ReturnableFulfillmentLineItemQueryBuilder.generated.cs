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
    public sealed class ReturnableFulfillmentLineItemQueryBuilder : FieldsQueryBuilderBase<ReturnableFulfillmentLineItem, ReturnableFulfillmentLineItemQueryBuilder>
    {
        protected override ReturnableFulfillmentLineItemQueryBuilder Self => this;

        public ReturnableFulfillmentLineItemQueryBuilder() : this("returnableFulfillmentLineItem")
        {
        }

        public ReturnableFulfillmentLineItemQueryBuilder(string name) : base(new Query<ReturnableFulfillmentLineItem>(name))
        {
        }

        public ReturnableFulfillmentLineItemQueryBuilder(IQuery<ReturnableFulfillmentLineItem> query) : base(query)
        {
        }

        public ReturnableFulfillmentLineItemQueryBuilder FulfillmentLineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItem>("fulfillmentLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentLineItem>(query);
            return this;
        }

        public ReturnableFulfillmentLineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }
    }
}