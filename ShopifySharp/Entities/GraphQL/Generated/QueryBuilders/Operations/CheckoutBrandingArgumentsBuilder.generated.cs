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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
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