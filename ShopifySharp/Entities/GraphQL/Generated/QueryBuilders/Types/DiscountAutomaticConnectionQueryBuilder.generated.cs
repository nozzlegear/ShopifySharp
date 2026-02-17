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
    public sealed class DiscountAutomaticConnectionQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticConnection, DiscountAutomaticConnectionQueryBuilder>
    {
        protected override DiscountAutomaticConnectionQueryBuilder Self => this;

        public DiscountAutomaticConnectionQueryBuilder() : this("discountAutomaticConnection")
        {
        }

        public DiscountAutomaticConnectionQueryBuilder(string name) : base(new Query<DiscountAutomaticConnection>(name))
        {
        }

        public DiscountAutomaticConnectionQueryBuilder(IQuery<DiscountAutomaticConnection> query) : base(query)
        {
        }

        public DiscountAutomaticConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticEdge>(query);
            return this;
        }

        public DiscountAutomaticConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public DiscountAutomaticConnectionQueryBuilder Nodes(Action<DiscountAutomaticUnionCasesBuilder> build)
        {
            var query = new Query<DiscountAutomatic>("nodes");
            var unionBuilder = new DiscountAutomaticUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}