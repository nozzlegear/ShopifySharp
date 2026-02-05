#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    [Obsolete("Use `automaticDiscountNodes` instead.")]
    public sealed class AutomaticDiscountsOperationQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticConnection, AutomaticDiscountsOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountAutomaticConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AutomaticDiscountsArgumentsBuilder Arguments { get; }
        protected override AutomaticDiscountsOperationQueryBuilder Self => this;

        public AutomaticDiscountsOperationQueryBuilder() : this("automaticDiscounts")
        {
        }

        public AutomaticDiscountsOperationQueryBuilder(string name) : base(new Query<DiscountAutomaticConnection>(name))
        {
            Arguments = new AutomaticDiscountsArgumentsBuilder(base.InnerQuery);
        }

        public AutomaticDiscountsOperationQueryBuilder(IQuery<DiscountAutomaticConnection> query) : base(query)
        {
            Arguments = new AutomaticDiscountsArgumentsBuilder(base.InnerQuery);
        }

        public AutomaticDiscountsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticEdge>(query);
            return this;
        }

        public AutomaticDiscountsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public AutomaticDiscountsOperationQueryBuilder Nodes(Action<DiscountAutomaticUnionCasesBuilder> build)
        {
            var query = new Query<DiscountAutomatic>("nodes");
            var unionBuilder = new DiscountAutomaticUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}