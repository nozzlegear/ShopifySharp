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