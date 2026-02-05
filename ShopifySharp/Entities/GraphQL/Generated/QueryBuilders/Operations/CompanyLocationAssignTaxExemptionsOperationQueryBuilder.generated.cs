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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    [Obsolete("Use `companyLocationTaxSettingsUpdate` instead.")]
    public sealed class CompanyLocationAssignTaxExemptionsOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationAssignTaxExemptionsPayload, CompanyLocationAssignTaxExemptionsOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationAssignTaxExemptionsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationAssignTaxExemptionsArgumentsBuilder Arguments { get; }
        protected override CompanyLocationAssignTaxExemptionsOperationQueryBuilder Self => this;

        public CompanyLocationAssignTaxExemptionsOperationQueryBuilder() : this("companyLocationAssignTaxExemptions")
        {
        }

        public CompanyLocationAssignTaxExemptionsOperationQueryBuilder(string name) : base(new Query<CompanyLocationAssignTaxExemptionsPayload>(name))
        {
            Arguments = new CompanyLocationAssignTaxExemptionsArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationAssignTaxExemptionsOperationQueryBuilder(IQuery<CompanyLocationAssignTaxExemptionsPayload> query) : base(query)
        {
            Arguments = new CompanyLocationAssignTaxExemptionsArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationAssignTaxExemptionsOperationQueryBuilder CompanyLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("companyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyLocationAssignTaxExemptionsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}