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
    public sealed class CalculatedLineItemConnectionQueryBuilder : FieldsQueryBuilderBase<CalculatedLineItemConnection, CalculatedLineItemConnectionQueryBuilder>
    {
        protected override CalculatedLineItemConnectionQueryBuilder Self => this;

        public CalculatedLineItemConnectionQueryBuilder() : this("calculatedLineItemConnection")
        {
        }

        public CalculatedLineItemConnectionQueryBuilder(string name) : base(new Query<CalculatedLineItemConnection>(name))
        {
        }

        public CalculatedLineItemConnectionQueryBuilder(IQuery<CalculatedLineItemConnection> query) : base(query)
        {
        }

        public CalculatedLineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItemEdge>(query);
            return this;
        }

        public CalculatedLineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemQueryBuilder> build)
        {
            var query = new Query<CalculatedLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CalculatedLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CalculatedLineItem>(query);
            return this;
        }

        public CalculatedLineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}