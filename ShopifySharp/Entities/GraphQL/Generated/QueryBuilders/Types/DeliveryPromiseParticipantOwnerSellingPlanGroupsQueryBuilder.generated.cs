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
    public sealed class DeliveryPromiseParticipantOwnerSellingPlanGroupsQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupConnection, DeliveryPromiseParticipantOwnerSellingPlanGroupsQueryBuilder>, IHasArguments<DeliveryPromiseParticipantOwnerSellingPlanGroupsArgumentsBuilder>
    {
        public DeliveryPromiseParticipantOwnerSellingPlanGroupsArgumentsBuilder Arguments { get; }
        protected override DeliveryPromiseParticipantOwnerSellingPlanGroupsQueryBuilder Self => this;

        public DeliveryPromiseParticipantOwnerSellingPlanGroupsQueryBuilder(string name) : base(new Query<SellingPlanGroupConnection>(name))
        {
            Arguments = new DeliveryPromiseParticipantOwnerSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantOwnerSellingPlanGroupsQueryBuilder(IQuery<SellingPlanGroupConnection> query) : base(query)
        {
            Arguments = new DeliveryPromiseParticipantOwnerSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantOwnerSellingPlanGroupsQueryBuilder SetArguments(Action<DeliveryPromiseParticipantOwnerSellingPlanGroupsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryPromiseParticipantOwnerSellingPlanGroupsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupEdgeQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupEdge>(query);
            return this;
        }

        public DeliveryPromiseParticipantOwnerSellingPlanGroupsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public DeliveryPromiseParticipantOwnerSellingPlanGroupsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}