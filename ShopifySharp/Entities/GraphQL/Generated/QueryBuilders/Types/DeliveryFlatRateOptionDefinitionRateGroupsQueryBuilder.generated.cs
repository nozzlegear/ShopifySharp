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
    public sealed class DeliveryFlatRateOptionDefinitionRateGroupsQueryBuilder : FieldsQueryBuilderBase<DeliveryFlatRateGroupConnection, DeliveryFlatRateOptionDefinitionRateGroupsQueryBuilder>, IHasArguments<DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder>
    {
        public DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder Arguments { get; }
        protected override DeliveryFlatRateOptionDefinitionRateGroupsQueryBuilder Self => this;

        public DeliveryFlatRateOptionDefinitionRateGroupsQueryBuilder(string name) : base(new Query<DeliveryFlatRateGroupConnection>(name))
        {
            Arguments = new DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryFlatRateOptionDefinitionRateGroupsQueryBuilder(IQuery<DeliveryFlatRateGroupConnection> query) : base(query)
        {
            Arguments = new DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryFlatRateOptionDefinitionRateGroupsQueryBuilder SetArguments(Action<DeliveryFlatRateOptionDefinitionRateGroupsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionRateGroupsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateGroupEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryFlatRateGroupEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateGroupEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryFlatRateGroupEdge>(query);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionRateGroupsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryFlatRateGroup>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryFlatRateGroup>(query);
            return this;
        }

        public DeliveryFlatRateOptionDefinitionRateGroupsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}