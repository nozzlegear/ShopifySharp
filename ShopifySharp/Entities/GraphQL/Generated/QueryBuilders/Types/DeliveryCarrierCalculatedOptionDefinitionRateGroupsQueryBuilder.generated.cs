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
    public sealed class DeliveryCarrierCalculatedOptionDefinitionRateGroupsQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierCalculatedRateGroupConnection, DeliveryCarrierCalculatedOptionDefinitionRateGroupsQueryBuilder>, IHasArguments<DeliveryCarrierCalculatedOptionDefinitionRateGroupsArgumentsBuilder>
    {
        public DeliveryCarrierCalculatedOptionDefinitionRateGroupsArgumentsBuilder Arguments { get; }
        protected override DeliveryCarrierCalculatedOptionDefinitionRateGroupsQueryBuilder Self => this;

        public DeliveryCarrierCalculatedOptionDefinitionRateGroupsQueryBuilder(string name) : base(new Query<DeliveryCarrierCalculatedRateGroupConnection>(name))
        {
            Arguments = new DeliveryCarrierCalculatedOptionDefinitionRateGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCarrierCalculatedOptionDefinitionRateGroupsQueryBuilder(IQuery<DeliveryCarrierCalculatedRateGroupConnection> query) : base(query)
        {
            Arguments = new DeliveryCarrierCalculatedOptionDefinitionRateGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCarrierCalculatedOptionDefinitionRateGroupsQueryBuilder SetArguments(Action<DeliveryCarrierCalculatedOptionDefinitionRateGroupsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionRateGroupsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedRateGroupEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierCalculatedRateGroupEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedRateGroupEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierCalculatedRateGroupEdge>(query);
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionRateGroupsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedRateGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierCalculatedRateGroup>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedRateGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierCalculatedRateGroup>(query);
            return this;
        }

        public DeliveryCarrierCalculatedOptionDefinitionRateGroupsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}