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
    public sealed class CompanyDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CompanyDeletePayload, CompanyDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyDeleteArgumentsBuilder Arguments { get; }
        protected override CompanyDeleteOperationQueryBuilder Self => this;

        public CompanyDeleteOperationQueryBuilder() : this("companyDelete")
        {
        }

        public CompanyDeleteOperationQueryBuilder(string name) : base(new Query<CompanyDeletePayload>(name))
        {
            Arguments = new CompanyDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompanyDeleteOperationQueryBuilder(IQuery<CompanyDeletePayload> query) : base(query)
        {
            Arguments = new CompanyDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CompanyDeleteOperationQueryBuilder DeletedCompanyId()
        {
            base.InnerQuery.AddField("deletedCompanyId");
            return this;
        }

        public CompanyDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}