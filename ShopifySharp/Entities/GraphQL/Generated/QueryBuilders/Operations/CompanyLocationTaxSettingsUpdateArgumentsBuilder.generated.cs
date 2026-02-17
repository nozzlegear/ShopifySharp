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
    public sealed class CompanyLocationTaxSettingsUpdateArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationTaxSettingsUpdatePayload, CompanyLocationTaxSettingsUpdateArgumentsBuilder>
    {
        protected override CompanyLocationTaxSettingsUpdateArgumentsBuilder Self => this;

        public CompanyLocationTaxSettingsUpdateArgumentsBuilder(IQuery<CompanyLocationTaxSettingsUpdatePayload> query) : base(query)
        {
        }

        public CompanyLocationTaxSettingsUpdateArgumentsBuilder CompanyLocationId(string? companyLocationId)
        {
            base.InnerQuery.AddArgument("companyLocationId", companyLocationId);
            return this;
        }

        public CompanyLocationTaxSettingsUpdateArgumentsBuilder ExemptionsToAssign(ICollection<TaxExemption>? exemptionsToAssign)
        {
            base.InnerQuery.AddArgument("exemptionsToAssign", exemptionsToAssign);
            return this;
        }

        public CompanyLocationTaxSettingsUpdateArgumentsBuilder ExemptionsToRemove(ICollection<TaxExemption>? exemptionsToRemove)
        {
            base.InnerQuery.AddArgument("exemptionsToRemove", exemptionsToRemove);
            return this;
        }

        public CompanyLocationTaxSettingsUpdateArgumentsBuilder TaxExempt(bool? taxExempt)
        {
            base.InnerQuery.AddArgument("taxExempt", taxExempt);
            return this;
        }

        public CompanyLocationTaxSettingsUpdateArgumentsBuilder TaxRegistrationId(string? taxRegistrationId)
        {
            base.InnerQuery.AddArgument("taxRegistrationId", taxRegistrationId);
            return this;
        }
    }
}