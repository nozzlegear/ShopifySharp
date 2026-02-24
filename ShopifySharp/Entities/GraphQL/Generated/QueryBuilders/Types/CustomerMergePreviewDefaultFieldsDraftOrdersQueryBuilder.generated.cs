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
    public sealed class CustomerMergePreviewDefaultFieldsDraftOrdersQueryBuilder : FieldsQueryBuilderBase<DraftOrderConnection, CustomerMergePreviewDefaultFieldsDraftOrdersQueryBuilder>, IHasArguments<CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder>
    {
        public CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder Arguments { get; }
        protected override CustomerMergePreviewDefaultFieldsDraftOrdersQueryBuilder Self => this;

        public CustomerMergePreviewDefaultFieldsDraftOrdersQueryBuilder(string name) : base(new Query<DraftOrderConnection>(name))
        {
            Arguments = new CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder(base.InnerQuery);
        }

        public CustomerMergePreviewDefaultFieldsDraftOrdersQueryBuilder(IQuery<DraftOrderConnection> query) : base(query)
        {
            Arguments = new CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder(base.InnerQuery);
        }

        public CustomerMergePreviewDefaultFieldsDraftOrdersQueryBuilder SetArguments(Action<CustomerMergePreviewDefaultFieldsDraftOrdersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsDraftOrdersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderEdgeQueryBuilder> build)
        {
            var query = new Query<DraftOrderEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderEdge>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsDraftOrdersQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsDraftOrdersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}