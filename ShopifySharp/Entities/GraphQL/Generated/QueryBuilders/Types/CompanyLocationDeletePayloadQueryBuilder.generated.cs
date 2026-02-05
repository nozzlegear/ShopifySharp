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
    public sealed class CompanyLocationDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CompanyLocationDeletePayload, CompanyLocationDeletePayloadQueryBuilder>
    {
        protected override CompanyLocationDeletePayloadQueryBuilder Self => this;

        public CompanyLocationDeletePayloadQueryBuilder() : this("companyLocationDeletePayload")
        {
        }

        public CompanyLocationDeletePayloadQueryBuilder(string name) : base(new Query<CompanyLocationDeletePayload>(name))
        {
        }

        public CompanyLocationDeletePayloadQueryBuilder(IQuery<CompanyLocationDeletePayload> query) : base(query)
        {
        }

        public CompanyLocationDeletePayloadQueryBuilder DeletedCompanyLocationId()
        {
            base.InnerQuery.AddField("deletedCompanyLocationId");
            return this;
        }

        public CompanyLocationDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}