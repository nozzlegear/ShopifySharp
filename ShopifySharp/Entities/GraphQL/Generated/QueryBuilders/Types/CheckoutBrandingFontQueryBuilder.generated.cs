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
    public sealed class CheckoutBrandingFontQueryBuilder : FieldsQueryBuilderBase<ICheckoutBrandingFont, CheckoutBrandingFontQueryBuilder>
    {
        protected override CheckoutBrandingFontQueryBuilder Self => this;

        public CheckoutBrandingFontQueryBuilder() : this("checkoutBrandingFont")
        {
        }

        public CheckoutBrandingFontQueryBuilder(string name) : base(new Query<ICheckoutBrandingFont>(name))
        {
        }

        public CheckoutBrandingFontQueryBuilder(IQuery<ICheckoutBrandingFont> query) : base(query)
        {
        }

        public CheckoutBrandingFontQueryBuilder Sources()
        {
            base.InnerQuery.AddField("sources");
            return this;
        }

        public CheckoutBrandingFontQueryBuilder Weight()
        {
            base.InnerQuery.AddField("weight");
            return this;
        }
    }
}