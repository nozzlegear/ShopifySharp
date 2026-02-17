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
    public sealed class CompanyLocationRevokeTaxExemptionsOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationRevokeTaxExemptionsPayload, CompanyLocationRevokeTaxExemptionsOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationRevokeTaxExemptionsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationRevokeTaxExemptionsArgumentsBuilder Arguments { get; }
        protected override CompanyLocationRevokeTaxExemptionsOperationQueryBuilder Self => this;

        public CompanyLocationRevokeTaxExemptionsOperationQueryBuilder() : this("companyLocationRevokeTaxExemptions")
        {
        }

        public CompanyLocationRevokeTaxExemptionsOperationQueryBuilder(string name) : base(new Query<CompanyLocationRevokeTaxExemptionsPayload>(name))
        {
            Arguments = new CompanyLocationRevokeTaxExemptionsArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationRevokeTaxExemptionsOperationQueryBuilder(IQuery<CompanyLocationRevokeTaxExemptionsPayload> query) : base(query)
        {
            Arguments = new CompanyLocationRevokeTaxExemptionsArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationRevokeTaxExemptionsOperationQueryBuilder CompanyLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("companyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyLocationRevokeTaxExemptionsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}