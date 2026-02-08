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
    public sealed class DiscountApplicationEdgeQueryBuilder : FieldsQueryBuilderBase<DiscountApplicationEdge, DiscountApplicationEdgeQueryBuilder>
    {
        protected override DiscountApplicationEdgeQueryBuilder Self => this;

        public DiscountApplicationEdgeQueryBuilder() : this("discountApplicationEdge")
        {
        }

        public DiscountApplicationEdgeQueryBuilder(string name) : base(new Query<DiscountApplicationEdge>(name))
        {
        }

        public DiscountApplicationEdgeQueryBuilder(IQuery<DiscountApplicationEdge> query) : base(query)
        {
        }

        public DiscountApplicationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DiscountApplicationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationQueryBuilder> build)
        {
            var query = new Query<IDiscountApplication>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IDiscountApplication>(query);
            return this;
        }
    }
}