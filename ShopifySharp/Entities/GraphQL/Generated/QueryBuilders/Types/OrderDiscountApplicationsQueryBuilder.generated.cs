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
    public sealed class OrderDiscountApplicationsQueryBuilder : FieldsQueryBuilderBase<DiscountApplicationConnection, OrderDiscountApplicationsQueryBuilder>, IHasArguments<OrderDiscountApplicationsArgumentsBuilder>
    {
        public OrderDiscountApplicationsArgumentsBuilder Arguments { get; }
        protected override OrderDiscountApplicationsQueryBuilder Self => this;

        public OrderDiscountApplicationsQueryBuilder(string name) : base(new Query<DiscountApplicationConnection>(name))
        {
            Arguments = new OrderDiscountApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public OrderDiscountApplicationsQueryBuilder(IQuery<DiscountApplicationConnection> query) : base(query)
        {
            Arguments = new OrderDiscountApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public OrderDiscountApplicationsQueryBuilder SetArguments(Action<OrderDiscountApplicationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderDiscountApplicationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountApplicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountApplicationEdge>(query);
            return this;
        }

        public OrderDiscountApplicationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationQueryBuilder> build)
        {
            var query = new Query<IDiscountApplication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IDiscountApplication>(query);
            return this;
        }

        public OrderDiscountApplicationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}