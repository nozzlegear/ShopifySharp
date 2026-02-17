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
    public sealed class DiscountNodeEdgeQueryBuilder : FieldsQueryBuilderBase<DiscountNodeEdge, DiscountNodeEdgeQueryBuilder>
    {
        protected override DiscountNodeEdgeQueryBuilder Self => this;

        public DiscountNodeEdgeQueryBuilder() : this("discountNodeEdge")
        {
        }

        public DiscountNodeEdgeQueryBuilder(string name) : base(new Query<DiscountNodeEdge>(name))
        {
        }

        public DiscountNodeEdgeQueryBuilder(IQuery<DiscountNodeEdge> query) : base(query)
        {
        }

        public DiscountNodeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DiscountNodeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeQueryBuilder> build)
        {
            var query = new Query<DiscountNode>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountNode>(query);
            return this;
        }
    }
}