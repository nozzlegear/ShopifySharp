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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class SellingPlanGroupsOperationQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupConnection, SellingPlanGroupsOperationQueryBuilder>, IGraphOperationQueryBuilder<SellingPlanGroupConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SellingPlanGroupsArgumentsBuilder Arguments { get; }
        protected override SellingPlanGroupsOperationQueryBuilder Self => this;

        public SellingPlanGroupsOperationQueryBuilder() : this("sellingPlanGroups")
        {
        }

        public SellingPlanGroupsOperationQueryBuilder(string name) : base(new Query<SellingPlanGroupConnection>(name))
        {
            Arguments = new SellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupsOperationQueryBuilder(IQuery<SellingPlanGroupConnection> query) : base(query)
        {
            Arguments = new SellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupEdgeQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupEdge>(query);
            return this;
        }

        public SellingPlanGroupsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public SellingPlanGroupsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}