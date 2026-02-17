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
    public sealed class CompanyLocationAssignStaffMembersOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocationAssignStaffMembersPayload, CompanyLocationAssignStaffMembersOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocationAssignStaffMembersPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CompanyLocationAssignStaffMembersArgumentsBuilder Arguments { get; }
        protected override CompanyLocationAssignStaffMembersOperationQueryBuilder Self => this;

        public CompanyLocationAssignStaffMembersOperationQueryBuilder() : this("companyLocationAssignStaffMembers")
        {
        }

        public CompanyLocationAssignStaffMembersOperationQueryBuilder(string name) : base(new Query<CompanyLocationAssignStaffMembersPayload>(name))
        {
            Arguments = new CompanyLocationAssignStaffMembersArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationAssignStaffMembersOperationQueryBuilder(IQuery<CompanyLocationAssignStaffMembersPayload> query) : base(query)
        {
            Arguments = new CompanyLocationAssignStaffMembersArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationAssignStaffMembersOperationQueryBuilder CompanyLocationStaffMemberAssignments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyLocationStaffMemberAssignment>("companyLocationStaffMemberAssignments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationStaffMemberAssignment>(query);
            return this;
        }

        public CompanyLocationAssignStaffMembersOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}