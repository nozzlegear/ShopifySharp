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
    public sealed class CheckoutBrandingUpsertArgumentsBuilder : ArgumentsBuilderBase<CheckoutBrandingUpsertPayload, CheckoutBrandingUpsertArgumentsBuilder>
    {
        protected override CheckoutBrandingUpsertArgumentsBuilder Self => this;

        public CheckoutBrandingUpsertArgumentsBuilder(IQuery<CheckoutBrandingUpsertPayload> query) : base(query)
        {
        }

        public CheckoutBrandingUpsertArgumentsBuilder CheckoutBrandingInput(CheckoutBrandingInput? checkoutBrandingInput)
        {
            base.InnerQuery.AddArgument("checkoutBrandingInput", checkoutBrandingInput);
            return this;
        }

        public CheckoutBrandingUpsertArgumentsBuilder CheckoutProfileId(string? checkoutProfileId)
        {
            base.InnerQuery.AddArgument("checkoutProfileId", checkoutProfileId);
            return this;
        }
    }
}