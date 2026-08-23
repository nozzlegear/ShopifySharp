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
    public sealed class DeliveryValueBasedOptionDefinitionRateGroupsQueryBuilder : FieldsQueryBuilderBase<DeliveryValueBasedRateGroupConnection, DeliveryValueBasedOptionDefinitionRateGroupsQueryBuilder>, IHasArguments<DeliveryValueBasedOptionDefinitionRateGroupsArgumentsBuilder>
    {
        public DeliveryValueBasedOptionDefinitionRateGroupsArgumentsBuilder Arguments { get; }
        protected override DeliveryValueBasedOptionDefinitionRateGroupsQueryBuilder Self => this;

        public DeliveryValueBasedOptionDefinitionRateGroupsQueryBuilder(string name) : base(new Query<DeliveryValueBasedRateGroupConnection>(name))
        {
            Arguments = new DeliveryValueBasedOptionDefinitionRateGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryValueBasedOptionDefinitionRateGroupsQueryBuilder(IQuery<DeliveryValueBasedRateGroupConnection> query) : base(query)
        {
            Arguments = new DeliveryValueBasedOptionDefinitionRateGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryValueBasedOptionDefinitionRateGroupsQueryBuilder SetArguments(Action<DeliveryValueBasedOptionDefinitionRateGroupsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryValueBasedOptionDefinitionRateGroupsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateGroupEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryValueBasedRateGroupEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateGroupEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryValueBasedRateGroupEdge>(query);
            return this;
        }

        public DeliveryValueBasedOptionDefinitionRateGroupsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryValueBasedRateGroup>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryValueBasedRateGroup>(query);
            return this;
        }

        public DeliveryValueBasedOptionDefinitionRateGroupsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}