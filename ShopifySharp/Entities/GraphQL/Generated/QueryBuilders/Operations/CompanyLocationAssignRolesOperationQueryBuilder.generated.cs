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
    public sealed class CompanyLocationAssignRolesOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationAssignRolesPayload, CompanyLocationAssignRolesOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationAssignRolesPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationAssignRolesArgumentsBuilder Arguments { get; }
        protected override CompanyLocationAssignRolesOperationQueryBuilder Self => this;

        public CompanyLocationAssignRolesOperationQueryBuilder() : this("companyLocationAssignRoles")
        {
        }

        public CompanyLocationAssignRolesOperationQueryBuilder(string name) : base(new Query<CompanyLocationAssignRolesPayload>(name))
        {
            Arguments = new CompanyLocationAssignRolesArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationAssignRolesOperationQueryBuilder(IQuery<CompanyLocationAssignRolesPayload> query) : base(query)
        {
            Arguments = new CompanyLocationAssignRolesArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationAssignRolesOperationQueryBuilder RoleAssignments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignment>("roleAssignments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignment>(query);
            return this;
        }

        public CompanyLocationAssignRolesOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}