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
    public sealed class CompanyContactAssignRoleOperationQueryBuilder : FieldsQueryBuilderBase<CompanyContactAssignRolePayload, CompanyContactAssignRoleOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyContactAssignRolePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyContactAssignRoleArgumentsBuilder Arguments { get; }
        protected override CompanyContactAssignRoleOperationQueryBuilder Self => this;

        public CompanyContactAssignRoleOperationQueryBuilder() : this("companyContactAssignRole")
        {
        }

        public CompanyContactAssignRoleOperationQueryBuilder(string name) : base(new Query<CompanyContactAssignRolePayload>(name))
        {
            Arguments = new CompanyContactAssignRoleArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactAssignRoleOperationQueryBuilder(IQuery<CompanyContactAssignRolePayload> query) : base(query)
        {
            Arguments = new CompanyContactAssignRoleArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactAssignRoleOperationQueryBuilder CompanyContactRoleAssignment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignment>("companyContactRoleAssignment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignment>(query);
            return this;
        }

        public CompanyContactAssignRoleOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}