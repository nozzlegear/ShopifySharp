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
    public sealed class ShopifyFunctionConnectionQueryBuilder : FieldsQueryBuilderBase<ShopifyFunctionConnection, ShopifyFunctionConnectionQueryBuilder>, IHasArguments<ShopifyFunctionConnectionArgumentsBuilder>
    {
        public ShopifyFunctionConnectionArgumentsBuilder Arguments { get; }
        protected override ShopifyFunctionConnectionQueryBuilder Self => this;

        public ShopifyFunctionConnectionQueryBuilder() : this("shopifyFunctionConnection")
        {
        }

        public ShopifyFunctionConnectionQueryBuilder(string name) : base(new Query<ShopifyFunctionConnection>(name))
        {
            Arguments = new ShopifyFunctionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyFunctionConnectionQueryBuilder(IQuery<ShopifyFunctionConnection> query) : base(query)
        {
            Arguments = new ShopifyFunctionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyFunctionConnectionQueryBuilder SetArguments(Action<ShopifyFunctionConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShopifyFunctionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyFunctionEdgeQueryBuilder> build)
        {
            var query = new Query<ShopifyFunctionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyFunctionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyFunctionEdge>(query);
            return this;
        }

        public ShopifyFunctionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyFunctionQueryBuilder> build)
        {
            var query = new Query<ShopifyFunction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyFunctionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyFunction>(query);
            return this;
        }

        public ShopifyFunctionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}