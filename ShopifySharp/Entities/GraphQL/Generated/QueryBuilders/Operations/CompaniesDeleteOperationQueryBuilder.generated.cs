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
    public sealed class CompaniesDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CompaniesDeletePayload, CompaniesDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CompaniesDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompaniesDeleteArgumentsBuilder Arguments { get; }
        protected override CompaniesDeleteOperationQueryBuilder Self => this;

        public CompaniesDeleteOperationQueryBuilder() : this("companiesDelete")
        {
        }

        public CompaniesDeleteOperationQueryBuilder(string name) : base(new Query<CompaniesDeletePayload>(name))
        {
            Arguments = new CompaniesDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompaniesDeleteOperationQueryBuilder(IQuery<CompaniesDeletePayload> query) : base(query)
        {
            Arguments = new CompaniesDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompaniesDeleteOperationQueryBuilder DeletedCompanyIds()
        {
            base.InnerQuery.AddField("deletedCompanyIds");
            return this;
        }

        public CompaniesDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}