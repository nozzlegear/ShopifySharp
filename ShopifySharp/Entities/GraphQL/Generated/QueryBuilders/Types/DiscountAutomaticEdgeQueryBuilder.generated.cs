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
    public sealed class DiscountAutomaticEdgeQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticEdge, DiscountAutomaticEdgeQueryBuilder>
    {
        protected override DiscountAutomaticEdgeQueryBuilder Self => this;

        public DiscountAutomaticEdgeQueryBuilder() : this("discountAutomaticEdge")
        {
        }

        public DiscountAutomaticEdgeQueryBuilder(string name) : base(new Query<DiscountAutomaticEdge>(name))
        {
        }

        public DiscountAutomaticEdgeQueryBuilder(IQuery<DiscountAutomaticEdge> query) : base(query)
        {
        }

        public DiscountAutomaticEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DiscountAutomaticEdgeQueryBuilder Node(Action<DiscountAutomaticUnionCasesBuilder> build)
        {
            var query = new Query<DiscountAutomatic>("node");
            var unionBuilder = new DiscountAutomaticUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}