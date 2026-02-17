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

        public ReturnableFulfillmentLineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillmentLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillmentLineItemEdge>(query);
            return this;
        }

        public ReturnableFulfillmentLineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentLineItemQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillmentLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillmentLineItem>(query);
            return this;
        }

        public ReturnableFulfillmentLineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}