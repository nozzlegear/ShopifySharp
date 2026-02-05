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
    public sealed class CheckoutBrandingShopifyFontQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingShopifyFont, CheckoutBrandingShopifyFontQueryBuilder>
    {
        protected override CheckoutBrandingShopifyFontQueryBuilder Self => this;

        public CheckoutBrandingShopifyFontQueryBuilder() : this("checkoutBrandingShopifyFont")
        {
        }

        public CheckoutBrandingShopifyFontQueryBuilder(string name) : base(new Query<CheckoutBrandingShopifyFont>(name))
        {
        }

        public CheckoutBrandingShopifyFontQueryBuilder(IQuery<CheckoutBrandingShopifyFont> query) : base(query)
        {
        }

        public CheckoutBrandingShopifyFontQueryBuilder Sources()
        {
            base.InnerQuery.AddField("sources");
            return this;
        }

        public CheckoutBrandingShopifyFontQueryBuilder Weight()
        {
            base.InnerQuery.AddField("weight");
            return this;
        }
    }
}