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
    public sealed class SellingPlanGroupSellingPlansQueryBuilder : FieldsQueryBuilderBase<SellingPlanConnection, SellingPlanGroupSellingPlansQueryBuilder>, IHasArguments<SellingPlanGroupSellingPlansArgumentsBuilder>
    {
        public SellingPlanGroupSellingPlansArgumentsBuilder Arguments { get; }
        protected override SellingPlanGroupSellingPlansQueryBuilder Self => this;

        public SellingPlanGroupSellingPlansQueryBuilder(string name) : base(new Query<SellingPlanConnection>(name))
        {
            Arguments = new SellingPlanGroupSellingPlansArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupSellingPlansQueryBuilder(IQuery<SellingPlanConnection> query) : base(query)
        {
            Arguments = new SellingPlanGroupSellingPlansArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupSellingPlansQueryBuilder SetArguments(Action<SellingPlanGroupSellingPlansArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SellingPlanGroupSellingPlansQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanEdgeQueryBuilder> build)
        {
            var query = new Query<SellingPlanEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanEdge>(query);
            return this;
        }

        public SellingPlanGroupSellingPlansQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanQueryBuilder> build)
        {
            var query = new Query<SellingPlan>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlan>(query);
            return this;
        }

        public SellingPlanGroupSellingPlansQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}