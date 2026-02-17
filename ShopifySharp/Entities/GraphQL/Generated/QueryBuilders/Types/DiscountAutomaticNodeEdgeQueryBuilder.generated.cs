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
    public sealed class DiscountAutomaticNodeEdgeQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticNodeEdge, DiscountAutomaticNodeEdgeQueryBuilder>
    {
        protected override DiscountAutomaticNodeEdgeQueryBuilder Self => this;

        public DiscountAutomaticNodeEdgeQueryBuilder() : this("discountAutomaticNodeEdge")
        {
        }

        public DiscountAutomaticNodeEdgeQueryBuilder(string name) : base(new Query<DiscountAutomaticNodeEdge>(name))
        {
        }

        public DiscountAutomaticNodeEdgeQueryBuilder(IQuery<DiscountAutomaticNodeEdge> query) : base(query)
        {
        }

        public DiscountAutomaticNodeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DiscountAutomaticNodeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNode>(query);
            return this;
        }
    }
}