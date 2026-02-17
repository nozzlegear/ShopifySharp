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
    public sealed class CheckoutBrandingExpressCheckoutQueryBuilder : FieldsQueryBuilderBase<CheckoutBrandingExpressCheckout, CheckoutBrandingExpressCheckoutQueryBuilder>
    {
        protected override CheckoutBrandingExpressCheckoutQueryBuilder Self => this;

        public CheckoutBrandingExpressCheckoutQueryBuilder() : this("checkoutBrandingExpressCheckout")
        {
        }

        public CheckoutBrandingExpressCheckoutQueryBuilder(string name) : base(new Query<CheckoutBrandingExpressCheckout>(name))
        {
        }

        public CheckoutBrandingExpressCheckoutQueryBuilder(IQuery<CheckoutBrandingExpressCheckout> query) : base(query)
        {
        }

        public CheckoutBrandingExpressCheckoutQueryBuilder Button(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingExpressCheckoutButtonQueryBuilder> build)
        {
            var query = new Query<CheckoutBrandingExpressCheckoutButton>("button");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutBrandingExpressCheckoutButtonQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutBrandingExpressCheckoutButton>(query);
            return this;
        }
    }
}