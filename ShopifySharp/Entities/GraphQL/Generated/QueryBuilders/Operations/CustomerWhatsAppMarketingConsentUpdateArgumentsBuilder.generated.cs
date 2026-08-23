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
    public sealed class CustomerWhatsAppMarketingConsentUpdateArgumentsBuilder : ArgumentsBuilderBase<CustomerWhatsAppMarketingConsentUpdatePayload, CustomerWhatsAppMarketingConsentUpdateArgumentsBuilder>
    {
        protected override CustomerWhatsAppMarketingConsentUpdateArgumentsBuilder Self => this;

        public CustomerWhatsAppMarketingConsentUpdateArgumentsBuilder(IQuery<CustomerWhatsAppMarketingConsentUpdatePayload> query) : base(query)
        {
        }

        public CustomerWhatsAppMarketingConsentUpdateArgumentsBuilder Input(CustomerWhatsAppMarketingConsentUpdateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}