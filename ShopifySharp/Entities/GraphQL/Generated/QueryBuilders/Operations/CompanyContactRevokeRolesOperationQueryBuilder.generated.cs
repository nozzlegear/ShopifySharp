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
    public sealed class CompanyContactRevokeRolesOperationQueryBuilder : FieldsQueryBuilderBase<CompanyContactRevokeRolesPayload, CompanyContactRevokeRolesOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyContactRevokeRolesPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyContactRevokeRolesArgumentsBuilder Arguments { get; }
        protected override CompanyContactRevokeRolesOperationQueryBuilder Self => this;

        public CompanyContactRevokeRolesOperationQueryBuilder() : this("companyContactRevokeRoles")
        {
        }

        public CompanyContactRevokeRolesOperationQueryBuilder(string name) : base(new Query<CompanyContactRevokeRolesPayload>(name))
        {
            Arguments = new CompanyContactRevokeRolesArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactRevokeRolesOperationQueryBuilder(IQuery<CompanyContactRevokeRolesPayload> query) : base(query)
        {
            Arguments = new CompanyContactRevokeRolesArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactRevokeRolesOperationQueryBuilder RevokedRoleAssignmentIds()
        {
            base.InnerQuery.AddField("revokedRoleAssignmentIds");
            return this;
        }

        public CompanyContactRevokeRolesOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}