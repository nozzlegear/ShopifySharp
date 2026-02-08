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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CompanyLocationAssignStaffMembersPayloadQueryBuilder : FieldsQueryBuilderBase<CompanyLocationAssignStaffMembersPayload, CompanyLocationAssignStaffMembersPayloadQueryBuilder>
    {
        protected override CompanyLocationAssignStaffMembersPayloadQueryBuilder Self => this;

        public CompanyLocationAssignStaffMembersPayloadQueryBuilder() : this("companyLocationAssignStaffMembersPayload")
        {
        }

        public CompanyLocationAssignStaffMembersPayloadQueryBuilder(string name) : base(new Query<CompanyLocationAssignStaffMembersPayload>(name))
        {
        }

        public CompanyLocationAssignStaffMembersPayloadQueryBuilder(IQuery<CompanyLocationAssignStaffMembersPayload> query) : base(query)
        {
        }

        public CompanyLocationAssignStaffMembersPayloadQueryBuilder CompanyLocationStaffMemberAssignments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyLocationStaffMemberAssignment>("companyLocationStaffMemberAssignments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationStaffMemberAssignment>(query);
            return this;
        }

        public CompanyLocationAssignStaffMembersPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<BusinessCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BusinessCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessCustomerUserError>(query);
            return this;
        }
    }
}