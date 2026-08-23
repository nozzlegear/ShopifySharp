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
    public sealed class DeliveryValueBasedRateGroupRatesQueryBuilder : FieldsQueryBuilderBase<DeliveryValueBasedRateConnection, DeliveryValueBasedRateGroupRatesQueryBuilder>, IHasArguments<DeliveryValueBasedRateGroupRatesArgumentsBuilder>
    {
        public DeliveryValueBasedRateGroupRatesArgumentsBuilder Arguments { get; }
        protected override DeliveryValueBasedRateGroupRatesQueryBuilder Self => this;

        public DeliveryValueBasedRateGroupRatesQueryBuilder(string name) : base(new Query<DeliveryValueBasedRateConnection>(name))
        {
            Arguments = new DeliveryValueBasedRateGroupRatesArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryValueBasedRateGroupRatesQueryBuilder(IQuery<DeliveryValueBasedRateConnection> query) : base(query)
        {
            Arguments = new DeliveryValueBasedRateGroupRatesArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryValueBasedRateGroupRatesQueryBuilder SetArguments(Action<DeliveryValueBasedRateGroupRatesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryValueBasedRateGroupRatesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryValueBasedRateEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryValueBasedRateEdge>(query);
            return this;
        }

        public DeliveryValueBasedRateGroupRatesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateQueryBuilder> build)
        {
            var query = new Query<DeliveryValueBasedRate>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryValueBasedRate>(query);
            return this;
        }

        public DeliveryValueBasedRateGroupRatesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}