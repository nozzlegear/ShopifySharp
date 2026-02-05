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
    public sealed class CompanyLocationRemoveStaffMembersOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationRemoveStaffMembersPayload, CompanyLocationRemoveStaffMembersOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationRemoveStaffMembersPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationRemoveStaffMembersArgumentsBuilder Arguments { get; }
        protected override CompanyLocationRemoveStaffMembersOperationQueryBuilder Self => this;

        public CompanyLocationRemoveStaffMembersOperationQueryBuilder() : this("companyLocationRemoveStaffMembers")
        {
        }

        public CompanyLocationRemoveStaffMembersOperationQueryBuilder(string name) : base(new Query<CompanyLocationRemoveStaffMembersPayload>(name))
        {
            Arguments = new CompanyLocationRemoveStaffMembersArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationRemoveStaffMembersOperationQueryBuilder(IQuery<CompanyLocationRemoveStaffMembersPayload> query) : base(query)
        {
            Arguments = new CompanyLocationRemoveStaffMembersArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationRemoveStaffMembersOperationQueryBuilder DeletedCompanyLocationStaffMemberAssignmentIds()
        {
            base.InnerQuery.AddField("deletedCompanyLocationStaffMemberAssignmentIds");
            return this;
        }

        public CompanyLocationRemoveStaffMembersOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}