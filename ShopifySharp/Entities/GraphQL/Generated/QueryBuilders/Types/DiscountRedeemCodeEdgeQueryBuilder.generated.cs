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
    public sealed class DiscountRedeemCodeEdgeQueryBuilder : FieldsQueryBuilderBase<DiscountRedeemCodeEdge, DiscountRedeemCodeEdgeQueryBuilder>
    {
        protected override DiscountRedeemCodeEdgeQueryBuilder Self => this;

        public DiscountRedeemCodeEdgeQueryBuilder() : this("discountRedeemCodeEdge")
        {
        }

        public DiscountRedeemCodeEdgeQueryBuilder(string name) : base(new Query<DiscountRedeemCodeEdge>(name))
        {
        }

        public DiscountRedeemCodeEdgeQueryBuilder(IQuery<DiscountRedeemCodeEdge> query) : base(query)
        {
        }

        public DiscountRedeemCodeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DiscountRedeemCodeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCode>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCode>(query);
            return this;
        }
    }
}