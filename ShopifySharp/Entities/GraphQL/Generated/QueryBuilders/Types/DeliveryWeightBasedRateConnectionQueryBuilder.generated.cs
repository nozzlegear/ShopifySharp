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
    public sealed class DeliveryWeightBasedRateConnectionQueryBuilder : FieldsQueryBuilderBase<DeliveryWeightBasedRateConnection, DeliveryWeightBasedRateConnectionQueryBuilder>, IHasArguments<DeliveryWeightBasedRateConnectionArgumentsBuilder>
    {
        public DeliveryWeightBasedRateConnectionArgumentsBuilder Arguments { get; }
        protected override DeliveryWeightBasedRateConnectionQueryBuilder Self => this;

        public DeliveryWeightBasedRateConnectionQueryBuilder() : this("deliveryWeightBasedRateConnection")
        {
        }

        public DeliveryWeightBasedRateConnectionQueryBuilder(string name) : base(new Query<DeliveryWeightBasedRateConnection>(name))
        {
            Arguments = new DeliveryWeightBasedRateConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryWeightBasedRateConnectionQueryBuilder(IQuery<DeliveryWeightBasedRateConnection> query) : base(query)
        {
            Arguments = new DeliveryWeightBasedRateConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryWeightBasedRateConnectionQueryBuilder SetArguments(Action<DeliveryWeightBasedRateConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryWeightBasedRateConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedRateEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryWeightBasedRateEdge>(query);
            return this;
        }

        public DeliveryWeightBasedRateConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedRate>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryWeightBasedRate>(query);
            return this;
        }

        public DeliveryWeightBasedRateConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}