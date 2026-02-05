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
    public sealed class CompanyLocationsDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CompanyLocationsDeletePayload, CompanyLocationsDeletePayloadQueryBuilder>
    {
        protected override CompanyLocationsDeletePayloadQueryBuilder Self => this;

        public CompanyLocationsDeletePayloadQueryBuilder() : this("companyLocationsDeletePayload")
        {
        }

        public CompanyLocationsDeletePayloadQueryBuilder(string name) : base(new Query<CompanyLocationsDeletePayload>(name))
        {
        }

        public CompanyLocationsDeletePayloadQueryBuilder(IQuery<CompanyLocationsDeletePayload> query) : base(query)
        {
        }

        public CompanyLocationsDeletePayloadQueryBuilder DeletedCompanyLocationIds()
        {
            base.InnerQuery.AddField("deletedCompanyLocationIds");
            return this;
        }

        public CompanyLocationsDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}