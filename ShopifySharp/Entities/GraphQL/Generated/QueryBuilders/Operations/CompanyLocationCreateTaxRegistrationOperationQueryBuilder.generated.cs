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
    public sealed class CompanyLocationCreateTaxRegistrationOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationCreateTaxRegistrationPayload, CompanyLocationCreateTaxRegistrationOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationCreateTaxRegistrationPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationCreateTaxRegistrationArgumentsBuilder Arguments { get; }
        protected override CompanyLocationCreateTaxRegistrationOperationQueryBuilder Self => this;

        public CompanyLocationCreateTaxRegistrationOperationQueryBuilder() : this("companyLocationCreateTaxRegistration")
        {
        }

        public CompanyLocationCreateTaxRegistrationOperationQueryBuilder(string name) : base(new Query<CompanyLocationCreateTaxRegistrationPayload>(name))
        {
            Arguments = new CompanyLocationCreateTaxRegistrationArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationCreateTaxRegistrationOperationQueryBuilder(IQuery<CompanyLocationCreateTaxRegistrationPayload> query) : base(query)
        {
            Arguments = new CompanyLocationCreateTaxRegistrationArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationCreateTaxRegistrationOperationQueryBuilder CompanyLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("companyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyLocationCreateTaxRegistrationOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}