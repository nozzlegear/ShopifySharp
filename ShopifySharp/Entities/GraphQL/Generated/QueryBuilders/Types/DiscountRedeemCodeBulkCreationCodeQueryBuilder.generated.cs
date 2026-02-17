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
    public sealed class DiscountRedeemCodeBulkCreationCodeQueryBuilder : FieldsQueryBuilderBase<DiscountRedeemCodeBulkCreationCode, DiscountRedeemCodeBulkCreationCodeQueryBuilder>
    {
        protected override DiscountRedeemCodeBulkCreationCodeQueryBuilder Self => this;

        public DiscountRedeemCodeBulkCreationCodeQueryBuilder() : this("discountRedeemCodeBulkCreationCode")
        {
        }

        public DiscountRedeemCodeBulkCreationCodeQueryBuilder(string name) : base(new Query<DiscountRedeemCodeBulkCreationCode>(name))
        {
        }

        public DiscountRedeemCodeBulkCreationCodeQueryBuilder(IQuery<DiscountRedeemCodeBulkCreationCode> query) : base(query)
        {
        }

        public DiscountRedeemCodeBulkCreationCodeQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodeQueryBuilder DiscountRedeemCode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCode>("discountRedeemCode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCode>(query);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodeQueryBuilder Errors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("errors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}