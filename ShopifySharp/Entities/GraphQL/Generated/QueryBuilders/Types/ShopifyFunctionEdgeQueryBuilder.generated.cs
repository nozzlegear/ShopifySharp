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
    public sealed class ShopifyFunctionEdgeQueryBuilder : FieldsQueryBuilderBase<ShopifyFunctionEdge, ShopifyFunctionEdgeQueryBuilder>
    {
        protected override ShopifyFunctionEdgeQueryBuilder Self => this;

        public ShopifyFunctionEdgeQueryBuilder() : this("shopifyFunctionEdge")
        {
        }

        public ShopifyFunctionEdgeQueryBuilder(string name) : base(new Query<ShopifyFunctionEdge>(name))
        {
        }

        public ShopifyFunctionEdgeQueryBuilder(IQuery<ShopifyFunctionEdge> query) : base(query)
        {
        }

        public ShopifyFunctionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ShopifyFunctionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionQueryBuilder> build)
        {
            var query = new Query<ShopifyFunction>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyFunction>(query);
            return this;
        }
    }
}