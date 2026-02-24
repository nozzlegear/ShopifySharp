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
    public sealed class QueryRootConsentPolicyArgumentsBuilder : ArgumentsBuilderBase<ConsentPolicy?, QueryRootConsentPolicyArgumentsBuilder>
    {
        protected override QueryRootConsentPolicyArgumentsBuilder Self => this;

        public QueryRootConsentPolicyArgumentsBuilder(IQuery<ConsentPolicy?> query) : base(query)
        {
        }

        public QueryRootConsentPolicyArgumentsBuilder ConsentRequired(bool? consentRequired)
        {
            base.InnerQuery.AddArgument("consentRequired", consentRequired);
            return this;
        }

        public QueryRootConsentPolicyArgumentsBuilder CountryCode(PrivacyCountryCode? countryCode)
        {
            base.InnerQuery.AddArgument("countryCode", countryCode);
            return this;
        }

        public QueryRootConsentPolicyArgumentsBuilder DataSaleOptOutRequired(bool? dataSaleOptOutRequired)
        {
            base.InnerQuery.AddArgument("dataSaleOptOutRequired", dataSaleOptOutRequired);
            return this;
        }

        public QueryRootConsentPolicyArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public QueryRootConsentPolicyArgumentsBuilder RegionCode(string? regionCode)
        {
            base.InnerQuery.AddArgument("regionCode", regionCode);
            return this;
        }
    }
}