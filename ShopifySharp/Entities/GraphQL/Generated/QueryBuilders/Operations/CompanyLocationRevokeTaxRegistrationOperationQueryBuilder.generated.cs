#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    [Obsolete("Use `companyLocationTaxSettingsUpdate` instead.")]
    public sealed class CompanyLocationRevokeTaxRegistrationOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationRevokeTaxRegistrationPayload, CompanyLocationRevokeTaxRegistrationOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationRevokeTaxRegistrationPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationRevokeTaxRegistrationArgumentsBuilder Arguments { get; }
        protected override CompanyLocationRevokeTaxRegistrationOperationQueryBuilder Self => this;

        public CompanyLocationRevokeTaxRegistrationOperationQueryBuilder() : this("companyLocationRevokeTaxRegistration")
        {
        }

        public CompanyLocationRevokeTaxRegistrationOperationQueryBuilder(string name) : base(new Query<CompanyLocationRevokeTaxRegistrationPayload>(name))
        {
            Arguments = new CompanyLocationRevokeTaxRegistrationArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationRevokeTaxRegistrationOperationQueryBuilder(IQuery<CompanyLocationRevokeTaxRegistrationPayload> query) : base(query)
        {
            Arguments = new CompanyLocationRevokeTaxRegistrationArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationRevokeTaxRegistrationOperationQueryBuilder CompanyLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("companyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyLocationRevokeTaxRegistrationOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}