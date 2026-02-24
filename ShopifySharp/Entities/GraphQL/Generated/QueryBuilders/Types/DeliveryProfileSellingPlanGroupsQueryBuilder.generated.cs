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
    public sealed class DeliveryProfileSellingPlanGroupsQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupConnection, DeliveryProfileSellingPlanGroupsQueryBuilder>, IHasArguments<DeliveryProfileSellingPlanGroupsArgumentsBuilder>
    {
        public DeliveryProfileSellingPlanGroupsArgumentsBuilder Arguments { get; }
        protected override DeliveryProfileSellingPlanGroupsQueryBuilder Self => this;

        public DeliveryProfileSellingPlanGroupsQueryBuilder(string name) : base(new Query<SellingPlanGroupConnection>(name))
        {
            Arguments = new DeliveryProfileSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileSellingPlanGroupsQueryBuilder(IQuery<SellingPlanGroupConnection> query) : base(query)
        {
            Arguments = new DeliveryProfileSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileSellingPlanGroupsQueryBuilder SetArguments(Action<DeliveryProfileSellingPlanGroupsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryProfileSellingPlanGroupsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupEdgeQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupEdge>(query);
            return this;
        }

        public DeliveryProfileSellingPlanGroupsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public DeliveryProfileSellingPlanGroupsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}