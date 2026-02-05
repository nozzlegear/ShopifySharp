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
    public sealed class CompanyLocationRevokeTaxRegistrationPayloadQueryBuilder : FieldsQueryBuilderBase<CompanyLocationRevokeTaxRegistrationPayload, CompanyLocationRevokeTaxRegistrationPayloadQueryBuilder>
    {
        protected override CompanyLocationRevokeTaxRegistrationPayloadQueryBuilder Self => this;

        public CompanyLocationRevokeTaxRegistrationPayloadQueryBuilder() : this("companyLocationRevokeTaxRegistrationPayload")
        {
        }

        public CompanyLocationRevokeTaxRegistrationPayloadQueryBuilder(string name) : base(new Query<CompanyLocationRevokeTaxRegistrationPayload>(name))
        {
        }

        public CompanyLocationRevokeTaxRegistrationPayloadQueryBuilder(IQuery<CompanyLocationRevokeTaxRegistrationPayload> query) : base(query)
        {
        }

        public CompanyLocationRevokeTaxRegistrationPayloadQueryBuilder CompanyLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("companyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyLocationRevokeTaxRegistrationPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}