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
    public sealed class PriceListPriceQuantityPriceBreaksQueryBuilder : FieldsQueryBuilderBase<QuantityPriceBreakConnection, PriceListPriceQuantityPriceBreaksQueryBuilder>, IHasArguments<PriceListPriceQuantityPriceBreaksArgumentsBuilder>
    {
        public PriceListPriceQuantityPriceBreaksArgumentsBuilder Arguments { get; }
        protected override PriceListPriceQuantityPriceBreaksQueryBuilder Self => this;

        public PriceListPriceQuantityPriceBreaksQueryBuilder(string name) : base(new Query<QuantityPriceBreakConnection>(name))
        {
            Arguments = new PriceListPriceQuantityPriceBreaksArgumentsBuilder(base.InnerQuery);
        }

        public PriceListPriceQuantityPriceBreaksQueryBuilder(IQuery<QuantityPriceBreakConnection> query) : base(query)
        {
            Arguments = new PriceListPriceQuantityPriceBreaksArgumentsBuilder(base.InnerQuery);
        }

        public PriceListPriceQuantityPriceBreaksQueryBuilder SetArguments(Action<PriceListPriceQuantityPriceBreaksArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PriceListPriceQuantityPriceBreaksQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakEdgeQueryBuilder> build)
        {
            var query = new Query<QuantityPriceBreakEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityPriceBreakEdge>(query);
            return this;
        }

        public PriceListPriceQuantityPriceBreaksQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakQueryBuilder> build)
        {
            var query = new Query<QuantityPriceBreak>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPriceBreakQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityPriceBreak>(query);
            return this;
        }

        public PriceListPriceQuantityPriceBreaksQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}