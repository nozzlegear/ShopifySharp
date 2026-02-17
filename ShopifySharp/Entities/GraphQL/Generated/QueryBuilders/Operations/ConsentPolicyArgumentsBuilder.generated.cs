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
    public sealed class ConsentPolicyArgumentsBuilder : ArgumentsBuilderBase<ConsentPolicy, ConsentPolicyArgumentsBuilder>
    {
        protected override ConsentPolicyArgumentsBuilder Self => this;

        public ConsentPolicyArgumentsBuilder(IQuery<ConsentPolicy> query) : base(query)
        {
        }

        public ConsentPolicyArgumentsBuilder ConsentRequired(bool? consentRequired)
        {
            base.InnerQuery.AddArgument("consentRequired", consentRequired);
            return this;
        }

        public ConsentPolicyArgumentsBuilder CountryCode(PrivacyCountryCode? countryCode)
        {
            base.InnerQuery.AddArgument("countryCode", countryCode);
            return this;
        }

        public ConsentPolicyArgumentsBuilder DataSaleOptOutRequired(bool? dataSaleOptOutRequired)
        {
            base.InnerQuery.AddArgument("dataSaleOptOutRequired", dataSaleOptOutRequired);
            return this;
        }

        public ConsentPolicyArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public ConsentPolicyArgumentsBuilder RegionCode(string? regionCode)
        {
            base.InnerQuery.AddArgument("regionCode", regionCode);
            return this;
        }
    }
}