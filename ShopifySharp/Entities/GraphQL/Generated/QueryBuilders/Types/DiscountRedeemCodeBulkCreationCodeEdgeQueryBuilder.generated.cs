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
    public sealed class DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder : FieldsQueryBuilderBase<DiscountRedeemCodeBulkCreationCodeEdge, DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder>
    {
        protected override DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder Self => this;

        public DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder() : this("discountRedeemCodeBulkCreationCodeEdge")
        {
        }

        public DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder(string name) : base(new Query<DiscountRedeemCodeBulkCreationCodeEdge>(name))
        {
        }

        public DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder(IQuery<DiscountRedeemCodeBulkCreationCodeEdge> query) : base(query)
        {
        }

        public DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeBulkCreationCode>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeBulkCreationCode>(query);
            return this;
        }
    }
}