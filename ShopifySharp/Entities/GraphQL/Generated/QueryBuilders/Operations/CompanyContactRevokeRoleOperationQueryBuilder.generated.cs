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
    public sealed class CompanyContactRevokeRoleOperationQueryBuilder : FieldsQueryBuilderBase<CompanyContactRevokeRolePayload, CompanyContactRevokeRoleOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyContactRevokeRolePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyContactRevokeRoleArgumentsBuilder Arguments { get; }
        protected override CompanyContactRevokeRoleOperationQueryBuilder Self => this;

        public CompanyContactRevokeRoleOperationQueryBuilder() : this("companyContactRevokeRole")
        {
        }

        public CompanyContactRevokeRoleOperationQueryBuilder(string name) : base(new Query<CompanyContactRevokeRolePayload>(name))
        {
            Arguments = new CompanyContactRevokeRoleArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactRevokeRoleOperationQueryBuilder(IQuery<CompanyContactRevokeRolePayload> query) : base(query)
        {
            Arguments = new CompanyContactRevokeRoleArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactRevokeRoleOperationQueryBuilder RevokedCompanyContactRoleAssignmentId()
        {
            base.InnerQuery.AddField("revokedCompanyContactRoleAssignmentId");
            return this;
        }

        public CompanyContactRevokeRoleOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}