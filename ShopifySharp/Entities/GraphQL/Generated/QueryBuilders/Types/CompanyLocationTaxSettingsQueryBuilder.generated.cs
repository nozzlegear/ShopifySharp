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
    public sealed class CompanyLocationTaxSettingsQueryBuilder : FieldsQueryBuilderBase<CompanyLocationTaxSettings, CompanyLocationTaxSettingsQueryBuilder>
    {
        protected override CompanyLocationTaxSettingsQueryBuilder Self => this;

        public CompanyLocationTaxSettingsQueryBuilder() : this("companyLocationTaxSettings")
        {
        }

        public CompanyLocationTaxSettingsQueryBuilder(string name) : base(new Query<CompanyLocationTaxSettings>(name))
        {
        }

        public CompanyLocationTaxSettingsQueryBuilder(IQuery<CompanyLocationTaxSettings> query) : base(query)
        {
        }

        public CompanyLocationTaxSettingsQueryBuilder TaxExempt()
        {
            base.InnerQuery.AddField("taxExempt");
            return this;
        }

        public CompanyLocationTaxSettingsQueryBuilder TaxExemptions()
        {
            base.InnerQuery.AddField("taxExemptions");
            return this;
        }

        public CompanyLocationTaxSettingsQueryBuilder TaxRegistrationId()
        {
            base.InnerQuery.AddField("taxRegistrationId");
            return this;
        }
    }
}