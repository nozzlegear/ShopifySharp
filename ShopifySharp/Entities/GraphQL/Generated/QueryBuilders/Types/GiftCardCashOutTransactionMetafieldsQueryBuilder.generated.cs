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
    public sealed class GiftCardCashOutTransactionMetafieldsQueryBuilder : FieldsQueryBuilderBase<MetafieldConnection, GiftCardCashOutTransactionMetafieldsQueryBuilder>, IHasArguments<GiftCardCashOutTransactionMetafieldsArgumentsBuilder>
    {
        public GiftCardCashOutTransactionMetafieldsArgumentsBuilder Arguments { get; }
        protected override GiftCardCashOutTransactionMetafieldsQueryBuilder Self => this;

        public GiftCardCashOutTransactionMetafieldsQueryBuilder(string name) : base(new Query<MetafieldConnection>(name))
        {
            Arguments = new GiftCardCashOutTransactionMetafieldsArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardCashOutTransactionMetafieldsQueryBuilder(IQuery<MetafieldConnection> query) : base(query)
        {
            Arguments = new GiftCardCashOutTransactionMetafieldsArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardCashOutTransactionMetafieldsQueryBuilder SetArguments(Action<GiftCardCashOutTransactionMetafieldsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public GiftCardCashOutTransactionMetafieldsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldEdgeQueryBuilder> build)
        {
            var query = new Query<MetafieldEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldEdge>(query);
            return this;
        }

        public GiftCardCashOutTransactionMetafieldsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public GiftCardCashOutTransactionMetafieldsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}