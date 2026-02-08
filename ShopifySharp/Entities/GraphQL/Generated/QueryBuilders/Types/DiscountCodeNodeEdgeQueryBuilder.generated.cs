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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class DiscountCodeNodeEdgeQueryBuilder : FieldsQueryBuilderBase<DiscountCodeNodeEdge, DiscountCodeNodeEdgeQueryBuilder>
    {
        protected override DiscountCodeNodeEdgeQueryBuilder Self => this;

        public DiscountCodeNodeEdgeQueryBuilder() : this("discountCodeNodeEdge")
        {
        }

        public DiscountCodeNodeEdgeQueryBuilder(string name) : base(new Query<DiscountCodeNodeEdge>(name))
        {
        }

        public DiscountCodeNodeEdgeQueryBuilder(IQuery<DiscountCodeNodeEdge> query) : base(query)
        {
        }

        public DiscountCodeNodeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DiscountCodeNodeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }
    }
}