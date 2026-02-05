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
    public sealed class CompanyDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CompanyDeletePayload, CompanyDeletePayloadQueryBuilder>
    {
        protected override CompanyDeletePayloadQueryBuilder Self => this;

        public CompanyDeletePayloadQueryBuilder() : this("companyDeletePayload")
        {
        }

        public CompanyDeletePayloadQueryBuilder(string name) : base(new Query<CompanyDeletePayload>(name))
        {
        }

        public CompanyDeletePayloadQueryBuilder(IQuery<CompanyDeletePayload> query) : base(query)
        {
        }

        public CompanyDeletePayloadQueryBuilder DeletedCompanyId()
        {
            base.InnerQuery.AddField("deletedCompanyId");
            return this;
        }

        public CompanyDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}