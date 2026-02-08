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
    public sealed class ShopifyFunctionConnectionQueryBuilder : FieldsQueryBuilderBase<ShopifyFunctionConnection, ShopifyFunctionConnectionQueryBuilder>
    {
        protected override ShopifyFunctionConnectionQueryBuilder Self => this;

        public ShopifyFunctionConnectionQueryBuilder() : this("shopifyFunctionConnection")
        {
        }

        public ShopifyFunctionConnectionQueryBuilder(string name) : base(new Query<ShopifyFunctionConnection>(name))
        {
        }

        public ShopifyFunctionConnectionQueryBuilder(IQuery<ShopifyFunctionConnection> query) : base(query)
        {
        }

        public ShopifyFunctionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionEdgeQueryBuilder> build)
        {
            var query = new Query<ShopifyFunctionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyFunctionEdge>(query);
            return this;
        }

        public ShopifyFunctionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionQueryBuilder> build)
        {
            var query = new Query<ShopifyFunction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyFunction>(query);
            return this;
        }

        public ShopifyFunctionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}