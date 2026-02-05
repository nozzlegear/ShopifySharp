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
    public sealed class ShopifyPaymentsMerchantCategoryCodeQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsMerchantCategoryCode, ShopifyPaymentsMerchantCategoryCodeQueryBuilder>
    {
        protected override ShopifyPaymentsMerchantCategoryCodeQueryBuilder Self => this;

        public ShopifyPaymentsMerchantCategoryCodeQueryBuilder() : this("shopifyPaymentsMerchantCategoryCode")
        {
        }

        public ShopifyPaymentsMerchantCategoryCodeQueryBuilder(string name) : base(new Query<ShopifyPaymentsMerchantCategoryCode>(name))
        {
        }

        public ShopifyPaymentsMerchantCategoryCodeQueryBuilder(IQuery<ShopifyPaymentsMerchantCategoryCode> query) : base(query)
        {
        }

        public ShopifyPaymentsMerchantCategoryCodeQueryBuilder Category()
        {
            base.InnerQuery.AddField("category");
            return this;
        }

        public ShopifyPaymentsMerchantCategoryCodeQueryBuilder CategoryLabel()
        {
            base.InnerQuery.AddField("categoryLabel");
            return this;
        }

        public ShopifyPaymentsMerchantCategoryCodeQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ShopifyPaymentsMerchantCategoryCodeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopifyPaymentsMerchantCategoryCodeQueryBuilder SubcategoryLabel()
        {
            base.InnerQuery.AddField("subcategoryLabel");
            return this;
        }
    }
}