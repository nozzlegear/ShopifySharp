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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CompanyLocationTaxSettingsUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<CompanyLocationTaxSettingsUpdatePayload, CompanyLocationTaxSettingsUpdatePayloadQueryBuilder>
    {
        protected override CompanyLocationTaxSettingsUpdatePayloadQueryBuilder Self => this;

        public CompanyLocationTaxSettingsUpdatePayloadQueryBuilder() : this("companyLocationTaxSettingsUpdatePayload")
        {
        }

        public CompanyLocationTaxSettingsUpdatePayloadQueryBuilder(string name) : base(new Query<CompanyLocationTaxSettingsUpdatePayload>(name))
        {
        }

        public CompanyLocationTaxSettingsUpdatePayloadQueryBuilder(IQuery<CompanyLocationTaxSettingsUpdatePayload> query) : base(query)
        {
        }

        public CompanyLocationTaxSettingsUpdatePayloadQueryBuilder CompanyLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("companyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyLocationTaxSettingsUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}