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
    public sealed class CheckoutBrandingExpressCheckoutButtonQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingExpressCheckoutButton, CheckoutBrandingExpressCheckoutButtonQueryBuilder>
    {
        protected override CheckoutBrandingExpressCheckoutButtonQueryBuilder Self => this;

        public CheckoutBrandingExpressCheckoutButtonQueryBuilder() : this("checkoutBrandingExpressCheckoutButton")
        {
        }

        public CheckoutBrandingExpressCheckoutButtonQueryBuilder(string name) : base(new Query<CheckoutBrandingExpressCheckoutButton>(name))
        {
        }

        public CheckoutBrandingExpressCheckoutButtonQueryBuilder(IQuery<CheckoutBrandingExpressCheckoutButton> query) : base(query)
        {
        }

        public CheckoutBrandingExpressCheckoutButtonQueryBuilder CornerRadius()
        {
            base.InnerQuery.AddField("cornerRadius");
            return this;
        }
    }
}