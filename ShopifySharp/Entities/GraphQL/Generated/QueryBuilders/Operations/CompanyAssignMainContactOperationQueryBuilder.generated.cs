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
    public sealed class CompanyAssignMainContactOperationQueryBuilder : FieldsQueryBuilderBase<CompanyAssignMainContactPayload, CompanyAssignMainContactOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyAssignMainContactPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyAssignMainContactArgumentsBuilder Arguments { get; }
        protected override CompanyAssignMainContactOperationQueryBuilder Self => this;

        public CompanyAssignMainContactOperationQueryBuilder() : this("companyAssignMainContact")
        {
        }

        public CompanyAssignMainContactOperationQueryBuilder(string name) : base(new Query<CompanyAssignMainContactPayload>(name))
        {
            Arguments = new CompanyAssignMainContactArgumentsBuilder(base.InnerQuery);
        }

        public CompanyAssignMainContactOperationQueryBuilder(IQuery<CompanyAssignMainContactPayload> query) : base(query)
        {
            Arguments = new CompanyAssignMainContactArgumentsBuilder(base.InnerQuery);
        }

        public CompanyAssignMainContactOperationQueryBuilder Company(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("company");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public CompanyAssignMainContactOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}