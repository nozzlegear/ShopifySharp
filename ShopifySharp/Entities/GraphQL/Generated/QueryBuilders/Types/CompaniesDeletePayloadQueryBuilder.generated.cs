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
    public sealed class CompaniesDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CompaniesDeletePayload, CompaniesDeletePayloadQueryBuilder>
    {
        protected override CompaniesDeletePayloadQueryBuilder Self => this;

        public CompaniesDeletePayloadQueryBuilder() : this("companiesDeletePayload")
        {
        }

        public CompaniesDeletePayloadQueryBuilder(string name) : base(new Query<CompaniesDeletePayload>(name))
        {
        }

        public CompaniesDeletePayloadQueryBuilder(IQuery<CompaniesDeletePayload> query) : base(query)
        {
        }

        public CompaniesDeletePayloadQueryBuilder DeletedCompanyIds()
        {
            base.InnerQuery.AddField("deletedCompanyIds");
            return this;
        }

        public CompaniesDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}