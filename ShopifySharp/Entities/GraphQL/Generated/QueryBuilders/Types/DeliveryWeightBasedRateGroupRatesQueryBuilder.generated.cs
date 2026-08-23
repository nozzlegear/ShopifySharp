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
    public sealed class DeliveryWeightBasedRateGroupRatesQueryBuilder : FieldsQueryBuilderBase<DeliveryWeightBasedRateConnection, DeliveryWeightBasedRateGroupRatesQueryBuilder>, IHasArguments<DeliveryWeightBasedRateGroupRatesArgumentsBuilder>
    {
        public DeliveryWeightBasedRateGroupRatesArgumentsBuilder Arguments { get; }
        protected override DeliveryWeightBasedRateGroupRatesQueryBuilder Self => this;

        public DeliveryWeightBasedRateGroupRatesQueryBuilder(string name) : base(new Query<DeliveryWeightBasedRateConnection>(name))
        {
            Arguments = new DeliveryWeightBasedRateGroupRatesArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryWeightBasedRateGroupRatesQueryBuilder(IQuery<DeliveryWeightBasedRateConnection> query) : base(query)
        {
            Arguments = new DeliveryWeightBasedRateGroupRatesArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryWeightBasedRateGroupRatesQueryBuilder SetArguments(Action<DeliveryWeightBasedRateGroupRatesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryWeightBasedRateGroupRatesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedRateEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryWeightBasedRateEdge>(query);
            return this;
        }

        public DeliveryWeightBasedRateGroupRatesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedRate>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryWeightBasedRate>(query);
            return this;
        }

        public DeliveryWeightBasedRateGroupRatesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}