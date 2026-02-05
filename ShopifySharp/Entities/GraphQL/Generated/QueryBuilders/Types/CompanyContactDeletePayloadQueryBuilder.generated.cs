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
    public sealed class CompanyContactDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CompanyContactDeletePayload, CompanyContactDeletePayloadQueryBuilder>
    {
        protected override CompanyContactDeletePayloadQueryBuilder Self => this;

        public CompanyContactDeletePayloadQueryBuilder() : this("companyContactDeletePayload")
        {
        }

        public CompanyContactDeletePayloadQueryBuilder(string name) : base(new Query<CompanyContactDeletePayload>(name))
        {
        }

        public CompanyContactDeletePayloadQueryBuilder(IQuery<CompanyContactDeletePayload> query) : base(query)
        {
        }

        public CompanyContactDeletePayloadQueryBuilder DeletedCompanyContactId()
        {
            base.InnerQuery.AddField("deletedCompanyContactId");
            return this;
        }

        public CompanyContactDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}