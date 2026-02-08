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
    public sealed class CompanyLocationRevokeRolesOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationRevokeRolesPayload, CompanyLocationRevokeRolesOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationRevokeRolesPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationRevokeRolesArgumentsBuilder Arguments { get; }
        protected override CompanyLocationRevokeRolesOperationQueryBuilder Self => this;

        public CompanyLocationRevokeRolesOperationQueryBuilder() : this("companyLocationRevokeRoles")
        {
        }

        public CompanyLocationRevokeRolesOperationQueryBuilder(string name) : base(new Query<CompanyLocationRevokeRolesPayload>(name))
        {
            Arguments = new CompanyLocationRevokeRolesArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationRevokeRolesOperationQueryBuilder(IQuery<CompanyLocationRevokeRolesPayload> query) : base(query)
        {
            Arguments = new CompanyLocationRevokeRolesArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationRevokeRolesOperationQueryBuilder RevokedRoleAssignmentIds()
        {
            base.InnerQuery.AddField("revokedRoleAssignmentIds");
            return this;
        }

        public CompanyLocationRevokeRolesOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}