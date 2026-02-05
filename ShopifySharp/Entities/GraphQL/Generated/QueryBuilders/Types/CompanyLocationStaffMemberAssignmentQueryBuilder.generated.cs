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
    public sealed class CompanyLocationStaffMemberAssignmentQueryBuilder : FieldsQueryBuilderBase<CompanyLocationStaffMemberAssignment, CompanyLocationStaffMemberAssignmentQueryBuilder>
    {
        protected override CompanyLocationStaffMemberAssignmentQueryBuilder Self => this;

        public CompanyLocationStaffMemberAssignmentQueryBuilder() : this("companyLocationStaffMemberAssignment")
        {
        }

        public CompanyLocationStaffMemberAssignmentQueryBuilder(string name) : base(new Query<CompanyLocationStaffMemberAssignment>(name))
        {
        }

        public CompanyLocationStaffMemberAssignmentQueryBuilder(IQuery<CompanyLocationStaffMemberAssignment> query) : base(query)
        {
        }

        public CompanyLocationStaffMemberAssignmentQueryBuilder CompanyLocation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("companyLocation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }

        public CompanyLocationStaffMemberAssignmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CompanyLocationStaffMemberAssignmentQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }
    }
}