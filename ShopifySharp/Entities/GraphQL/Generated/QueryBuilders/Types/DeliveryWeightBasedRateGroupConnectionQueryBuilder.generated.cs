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
    public sealed class DeliveryWeightBasedRateGroupConnectionQueryBuilder : FieldsQueryBuilderBase<DeliveryWeightBasedRateGroupConnection, DeliveryWeightBasedRateGroupConnectionQueryBuilder>, IHasArguments<DeliveryWeightBasedRateGroupConnectionArgumentsBuilder>
    {
        public DeliveryWeightBasedRateGroupConnectionArgumentsBuilder Arguments { get; }
        protected override DeliveryWeightBasedRateGroupConnectionQueryBuilder Self => this;

        public DeliveryWeightBasedRateGroupConnectionQueryBuilder() : this("deliveryWeightBasedRateGroupConnection")
        {
        }

        public DeliveryWeightBasedRateGroupConnectionQueryBuilder(string name) : base(new Query<DeliveryWeightBasedRateGroupConnection>(name))
        {
            Arguments = new DeliveryWeightBasedRateGroupConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryWeightBasedRateGroupConnectionQueryBuilder(IQuery<DeliveryWeightBasedRateGroupConnection> query) : base(query)
        {
            Arguments = new DeliveryWeightBasedRateGroupConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryWeightBasedRateGroupConnectionQueryBuilder SetArguments(Action<DeliveryWeightBasedRateGroupConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryWeightBasedRateGroupConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateGroupEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedRateGroupEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateGroupEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryWeightBasedRateGroupEdge>(query);
            return this;
        }

        public DeliveryWeightBasedRateGroupConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedRateGroup>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryWeightBasedRateGroup>(query);
            return this;
        }

        public DeliveryWeightBasedRateGroupConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}