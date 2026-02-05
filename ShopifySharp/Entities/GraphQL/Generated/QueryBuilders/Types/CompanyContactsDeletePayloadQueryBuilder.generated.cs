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
    public sealed class CompanyContactsDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CompanyContactsDeletePayload, CompanyContactsDeletePayloadQueryBuilder>
    {
        protected override CompanyContactsDeletePayloadQueryBuilder Self => this;

        public CompanyContactsDeletePayloadQueryBuilder() : this("companyContactsDeletePayload")
        {
        }

        public CompanyContactsDeletePayloadQueryBuilder(string name) : base(new Query<CompanyContactsDeletePayload>(name))
        {
        }

        public CompanyContactsDeletePayloadQueryBuilder(IQuery<CompanyContactsDeletePayload> query) : base(query)
        {
        }

        public CompanyContactsDeletePayloadQueryBuilder DeletedCompanyContactIds()
        {
            base.InnerQuery.AddField("deletedCompanyContactIds");
            return this;
        }

        public CompanyContactsDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}