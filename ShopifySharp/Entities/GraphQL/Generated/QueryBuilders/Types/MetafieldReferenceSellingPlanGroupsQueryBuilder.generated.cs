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
    public sealed class MetafieldReferenceSellingPlanGroupsQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupConnection, MetafieldReferenceSellingPlanGroupsQueryBuilder>, IHasArguments<MetafieldReferenceSellingPlanGroupsArgumentsBuilder>
    {
        public MetafieldReferenceSellingPlanGroupsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceSellingPlanGroupsQueryBuilder Self => this;

        public MetafieldReferenceSellingPlanGroupsQueryBuilder(string name) : base(new Query<SellingPlanGroupConnection>(name))
        {
            Arguments = new MetafieldReferenceSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceSellingPlanGroupsQueryBuilder(IQuery<SellingPlanGroupConnection> query) : base(query)
        {
            Arguments = new MetafieldReferenceSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceSellingPlanGroupsQueryBuilder SetArguments(Action<MetafieldReferenceSellingPlanGroupsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceSellingPlanGroupsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupEdgeQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupEdge>(query);
            return this;
        }

        public MetafieldReferenceSellingPlanGroupsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public MetafieldReferenceSellingPlanGroupsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}