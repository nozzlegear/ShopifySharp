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
    public sealed class CustomerMergePreviewDefaultFieldsGiftCardsQueryBuilder : FieldsQueryBuilderBase<GiftCardConnection, CustomerMergePreviewDefaultFieldsGiftCardsQueryBuilder>, IHasArguments<CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder>
    {
        public CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder Arguments { get; }
        protected override CustomerMergePreviewDefaultFieldsGiftCardsQueryBuilder Self => this;

        public CustomerMergePreviewDefaultFieldsGiftCardsQueryBuilder(string name) : base(new Query<GiftCardConnection>(name))
        {
            Arguments = new CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerMergePreviewDefaultFieldsGiftCardsQueryBuilder(IQuery<GiftCardConnection> query) : base(query)
        {
            Arguments = new CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerMergePreviewDefaultFieldsGiftCardsQueryBuilder SetArguments(Action<CustomerMergePreviewDefaultFieldsGiftCardsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsGiftCardsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardEdgeQueryBuilder> build)
        {
            var query = new Query<GiftCardEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardEdge>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsGiftCardsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsGiftCardsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}