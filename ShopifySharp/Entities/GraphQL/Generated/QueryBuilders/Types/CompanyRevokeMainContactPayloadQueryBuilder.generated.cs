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
    public sealed class CompanyRevokeMainContactPayloadQueryBuilder : FieldsQueryBuilderBase<CompanyRevokeMainContactPayload, CompanyRevokeMainContactPayloadQueryBuilder>
    {
        protected override CompanyRevokeMainContactPayloadQueryBuilder Self => this;

        public CompanyRevokeMainContactPayloadQueryBuilder() : this("companyRevokeMainContactPayload")
        {
        }

        public CompanyRevokeMainContactPayloadQueryBuilder(string name) : base(new Query<CompanyRevokeMainContactPayload>(name))
        {
        }

        public CompanyRevokeMainContactPayloadQueryBuilder(IQuery<CompanyRevokeMainContactPayload> query) : base(query)
        {
        }

        public CompanyRevokeMainContactPayloadQueryBuilder Company(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("company");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public CompanyRevokeMainContactPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}