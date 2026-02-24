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
    public sealed class QueryRootCheckoutProfilesQueryBuilder : FieldsQueryBuilderBase<CheckoutProfileConnection, QueryRootCheckoutProfilesQueryBuilder>, IHasArguments<QueryRootCheckoutProfilesArgumentsBuilder>
    {
        public QueryRootCheckoutProfilesArgumentsBuilder Arguments { get; }
        protected override QueryRootCheckoutProfilesQueryBuilder Self => this;

        public QueryRootCheckoutProfilesQueryBuilder(string name) : base(new Query<CheckoutProfileConnection>(name))
        {
            Arguments = new QueryRootCheckoutProfilesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCheckoutProfilesQueryBuilder(IQuery<CheckoutProfileConnection> query) : base(query)
        {
            Arguments = new QueryRootCheckoutProfilesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCheckoutProfilesQueryBuilder SetArguments(Action<QueryRootCheckoutProfilesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCheckoutProfilesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutProfileEdgeQueryBuilder> build)
        {
            var query = new Query<CheckoutProfileEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutProfileEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutProfileEdge>(query);
            return this;
        }

        public QueryRootCheckoutProfilesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutProfileQueryBuilder> build)
        {
            var query = new Query<CheckoutProfile>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutProfile>(query);
            return this;
        }

        public QueryRootCheckoutProfilesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}