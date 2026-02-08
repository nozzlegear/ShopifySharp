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
    public sealed class CompanyAssignMainContactPayloadQueryBuilder : FieldsQueryBuilderBase<CompanyAssignMainContactPayload, CompanyAssignMainContactPayloadQueryBuilder>
    {
        protected override CompanyAssignMainContactPayloadQueryBuilder Self => this;

        public CompanyAssignMainContactPayloadQueryBuilder() : this("companyAssignMainContactPayload")
        {
        }

        public CompanyAssignMainContactPayloadQueryBuilder(string name) : base(new Query<CompanyAssignMainContactPayload>(name))
        {
        }

        public CompanyAssignMainContactPayloadQueryBuilder(IQuery<CompanyAssignMainContactPayload> query) : base(query)
        {
        }

        public CompanyAssignMainContactPayloadQueryBuilder Company(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("company");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public CompanyAssignMainContactPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}