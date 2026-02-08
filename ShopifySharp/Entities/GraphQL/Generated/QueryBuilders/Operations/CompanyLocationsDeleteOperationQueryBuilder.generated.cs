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
    public sealed class CompanyLocationsDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationsDeletePayload, CompanyLocationsDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationsDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationsDeleteArgumentsBuilder Arguments { get; }
        protected override CompanyLocationsDeleteOperationQueryBuilder Self => this;

        public CompanyLocationsDeleteOperationQueryBuilder() : this("companyLocationsDelete")
        {
        }

        public CompanyLocationsDeleteOperationQueryBuilder(string name) : base(new Query<CompanyLocationsDeletePayload>(name))
        {
            Arguments = new CompanyLocationsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationsDeleteOperationQueryBuilder(IQuery<CompanyLocationsDeletePayload> query) : base(query)
        {
            Arguments = new CompanyLocationsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationsDeleteOperationQueryBuilder DeletedCompanyLocationIds()
        {
            base.InnerQuery.AddField("deletedCompanyLocationIds");
            return this;
        }

        public CompanyLocationsDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}