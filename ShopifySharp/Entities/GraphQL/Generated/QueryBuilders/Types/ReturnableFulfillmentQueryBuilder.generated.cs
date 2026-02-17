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
    public sealed class ReturnableFulfillmentQueryBuilder : FieldsQueryBuilderBase<ReturnableFulfillment, ReturnableFulfillmentQueryBuilder>
    {
        protected override ReturnableFulfillmentQueryBuilder Self => this;

        public ReturnableFulfillmentQueryBuilder() : this("returnableFulfillment")
        {
        }

        public ReturnableFulfillmentQueryBuilder(string name) : base(new Query<ReturnableFulfillment>(name))
        {
        }

        public ReturnableFulfillmentQueryBuilder(IQuery<ReturnableFulfillment> query) : base(query)
        {
        }

        public ReturnableFulfillmentQueryBuilder Fulfillment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public ReturnableFulfillmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReturnableFulfillmentQueryBuilder ReturnableFulfillmentLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillmentLineItemConnection>("returnableFulfillmentLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillmentLineItemConnection>(query);
            return this;
        }
    }
}