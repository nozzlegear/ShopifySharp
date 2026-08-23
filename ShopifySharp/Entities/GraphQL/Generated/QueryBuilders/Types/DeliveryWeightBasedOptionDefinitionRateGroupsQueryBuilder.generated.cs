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
    public sealed class DeliveryWeightBasedOptionDefinitionRateGroupsQueryBuilder : FieldsQueryBuilderBase<DeliveryWeightBasedRateGroupConnection, DeliveryWeightBasedOptionDefinitionRateGroupsQueryBuilder>, IHasArguments<DeliveryWeightBasedOptionDefinitionRateGroupsArgumentsBuilder>
    {
        public DeliveryWeightBasedOptionDefinitionRateGroupsArgumentsBuilder Arguments { get; }
        protected override DeliveryWeightBasedOptionDefinitionRateGroupsQueryBuilder Self => this;

        public DeliveryWeightBasedOptionDefinitionRateGroupsQueryBuilder(string name) : base(new Query<DeliveryWeightBasedRateGroupConnection>(name))
        {
            Arguments = new DeliveryWeightBasedOptionDefinitionRateGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryWeightBasedOptionDefinitionRateGroupsQueryBuilder(IQuery<DeliveryWeightBasedRateGroupConnection> query) : base(query)
        {
            Arguments = new DeliveryWeightBasedOptionDefinitionRateGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryWeightBasedOptionDefinitionRateGroupsQueryBuilder SetArguments(Action<DeliveryWeightBasedOptionDefinitionRateGroupsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionRateGroupsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateGroupEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedRateGroupEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateGroupEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryWeightBasedRateGroupEdge>(query);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionRateGroupsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryWeightBasedRateGroup>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryWeightBasedRateGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryWeightBasedRateGroup>(query);
            return this;
        }

        public DeliveryWeightBasedOptionDefinitionRateGroupsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}