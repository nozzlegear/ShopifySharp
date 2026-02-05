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
    public sealed class ReturnableFulfillmentLineItemConnectionQueryBuilder : FieldsQueryBuilderBase<ReturnableFulfillmentLineItemConnection, ReturnableFulfillmentLineItemConnectionQueryBuilder>
    {
        protected override ReturnableFulfillmentLineItemConnectionQueryBuilder Self => this;

        public ReturnableFulfillmentLineItemConnectionQueryBuilder() : this("returnableFulfillmentLineItemConnection")
        {
        }

        public ReturnableFulfillmentLineItemConnectionQueryBuilder(string name) : base(new Query<ReturnableFulfillmentLineItemConnection>(name))
        {
        }

        public ReturnableFulfillmentLineItemConnectionQueryBuilder(IQuery<ReturnableFulfillmentLineItemConnection> query) : base(query)
        {
        }

        public ReturnableFulfillmentLineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillmentLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillmentLineItemEdge>(query);
            return this;
        }

        public ReturnableFulfillmentLineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentLineItemQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillmentLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnableFulfillmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillmentLineItem>(query);
            return this;
        }

        public ReturnableFulfillmentLineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}