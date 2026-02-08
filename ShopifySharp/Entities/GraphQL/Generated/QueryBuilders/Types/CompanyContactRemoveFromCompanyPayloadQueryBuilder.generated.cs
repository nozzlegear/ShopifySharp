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
    public sealed class CompanyContactRemoveFromCompanyPayloadQueryBuilder : FieldsQueryBuilderBase<CompanyContactRemoveFromCompanyPayload, CompanyContactRemoveFromCompanyPayloadQueryBuilder>
    {
        protected override CompanyContactRemoveFromCompanyPayloadQueryBuilder Self => this;

        public CompanyContactRemoveFromCompanyPayloadQueryBuilder() : this("companyContactRemoveFromCompanyPayload")
        {
        }

        public CompanyContactRemoveFromCompanyPayloadQueryBuilder(string name) : base(new Query<CompanyContactRemoveFromCompanyPayload>(name))
        {
        }

        public CompanyContactRemoveFromCompanyPayloadQueryBuilder(IQuery<CompanyContactRemoveFromCompanyPayload> query) : base(query)
        {
        }

        public CompanyContactRemoveFromCompanyPayloadQueryBuilder RemovedCompanyContactId()
        {
            base.InnerQuery.AddField("removedCompanyContactId");
            return this;
        }

        public CompanyContactRemoveFromCompanyPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}