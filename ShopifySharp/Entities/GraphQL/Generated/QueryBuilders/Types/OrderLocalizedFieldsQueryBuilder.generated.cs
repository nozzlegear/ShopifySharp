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
    public sealed class OrderLocalizedFieldsQueryBuilder : FieldsQueryBuilderBase<LocalizedFieldConnection, OrderLocalizedFieldsQueryBuilder>, IHasArguments<OrderLocalizedFieldsArgumentsBuilder>
    {
        public OrderLocalizedFieldsArgumentsBuilder Arguments { get; }
        protected override OrderLocalizedFieldsQueryBuilder Self => this;

        public OrderLocalizedFieldsQueryBuilder(string name) : base(new Query<LocalizedFieldConnection>(name))
        {
            Arguments = new OrderLocalizedFieldsArgumentsBuilder(base.InnerQuery);
        }

        public OrderLocalizedFieldsQueryBuilder(IQuery<LocalizedFieldConnection> query) : base(query)
        {
            Arguments = new OrderLocalizedFieldsArgumentsBuilder(base.InnerQuery);
        }

        public OrderLocalizedFieldsQueryBuilder SetArguments(Action<OrderLocalizedFieldsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderLocalizedFieldsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldEdgeQueryBuilder> build)
        {
            var query = new Query<LocalizedFieldEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedFieldEdge>(query);
            return this;
        }

        public OrderLocalizedFieldsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldQueryBuilder> build)
        {
            var query = new Query<LocalizedField>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedField>(query);
            return this;
        }

        public OrderLocalizedFieldsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}