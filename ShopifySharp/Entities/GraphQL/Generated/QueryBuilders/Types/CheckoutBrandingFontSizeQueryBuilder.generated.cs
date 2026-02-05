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
    public sealed class CheckoutBrandingFontSizeQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingFontSize, CheckoutBrandingFontSizeQueryBuilder>
    {
        protected override CheckoutBrandingFontSizeQueryBuilder Self => this;

        public CheckoutBrandingFontSizeQueryBuilder() : this("checkoutBrandingFontSize")
        {
        }

        public CheckoutBrandingFontSizeQueryBuilder(string name) : base(new Query<CheckoutBrandingFontSize>(name))
        {
        }

        public CheckoutBrandingFontSizeQueryBuilder(IQuery<CheckoutBrandingFontSize> query) : base(query)
        {
        }

        public CheckoutBrandingFontSizeQueryBuilder Base()
        {
            base.InnerQuery.AddField("base");
            return this;
        }

        public CheckoutBrandingFontSizeQueryBuilder Ratio()
        {
            base.InnerQuery.AddField("ratio");
            return this;
        }
    }
}