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
    public sealed class CustomerMergePreviewDefaultFieldsOrdersQueryBuilder : FieldsQueryBuilderBase<OrderConnection, CustomerMergePreviewDefaultFieldsOrdersQueryBuilder>, IHasArguments<CustomerMergePreviewDefaultFieldsOrdersArgumentsBuilder>
    {
        public CustomerMergePreviewDefaultFieldsOrdersArgumentsBuilder Arguments { get; }
        protected override CustomerMergePreviewDefaultFieldsOrdersQueryBuilder Self => this;

        public CustomerMergePreviewDefaultFieldsOrdersQueryBuilder(string name) : base(new Query<OrderConnection>(name))
        {
            Arguments = new CustomerMergePreviewDefaultFieldsOrdersArgumentsBuilder(base.InnerQuery);
        }

        public CustomerMergePreviewDefaultFieldsOrdersQueryBuilder(IQuery<OrderConnection> query) : base(query)
        {
            Arguments = new CustomerMergePreviewDefaultFieldsOrdersArgumentsBuilder(base.InnerQuery);
        }

        public CustomerMergePreviewDefaultFieldsOrdersQueryBuilder SetArguments(Action<CustomerMergePreviewDefaultFieldsOrdersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsOrdersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderEdgeQueryBuilder> build)
        {
            var query = new Query<OrderEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderEdge>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsOrdersQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsOrdersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}