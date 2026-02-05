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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CheckoutBrandingArgumentsBuilder : ArgumentsBuilderBase<CheckoutBranding, CheckoutBrandingArgumentsBuilder>
    {
        protected override CheckoutBrandingArgumentsBuilder Self => this;

        public CheckoutBrandingArgumentsBuilder(IQuery<CheckoutBranding> query) : base(query)
        {
        }

        public CheckoutBrandingArgumentsBuilder CheckoutProfileId(string? checkoutProfileId)
        {
            base.InnerQuery.AddArgument("checkoutProfileId", checkoutProfileId);
            return this;
        }
    }
}