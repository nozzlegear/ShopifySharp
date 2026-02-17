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
    public sealed class CompanyContactAssignRolesOperationQueryBuilder : FieldsQueryBuilderBase<CompanyContactAssignRolesPayload, CompanyContactAssignRolesOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyContactAssignRolesPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyContactAssignRolesArgumentsBuilder Arguments { get; }
        protected override CompanyContactAssignRolesOperationQueryBuilder Self => this;

        public CompanyContactAssignRolesOperationQueryBuilder() : this("companyContactAssignRoles")
        {
        }

        public CompanyContactAssignRolesOperationQueryBuilder(string name) : base(new Query<CompanyContactAssignRolesPayload>(name))
        {
            Arguments = new CompanyContactAssignRolesArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactAssignRolesOperationQueryBuilder(IQuery<CompanyContactAssignRolesPayload> query) : base(query)
        {
            Arguments = new CompanyContactAssignRolesArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactAssignRolesOperationQueryBuilder RoleAssignments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignment>("roleAssignments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignment>(query);
            return this;
        }

        public CompanyContactAssignRolesOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}