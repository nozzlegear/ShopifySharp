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
    public sealed class CompanyLocationStaffMemberAssignmentEdgeQueryBuilder : FieldsQueryBuilderBase<CompanyLocationStaffMemberAssignmentEdge, CompanyLocationStaffMemberAssignmentEdgeQueryBuilder>
    {
        protected override CompanyLocationStaffMemberAssignmentEdgeQueryBuilder Self => this;

        public CompanyLocationStaffMemberAssignmentEdgeQueryBuilder() : this("companyLocationStaffMemberAssignmentEdge")
        {
        }

        public CompanyLocationStaffMemberAssignmentEdgeQueryBuilder(string name) : base(new Query<CompanyLocationStaffMemberAssignmentEdge>(name))
        {
        }

        public CompanyLocationStaffMemberAssignmentEdgeQueryBuilder(IQuery<CompanyLocationStaffMemberAssignmentEdge> query) : base(query)
        {
        }

        public CompanyLocationStaffMemberAssignmentEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CompanyLocationStaffMemberAssignmentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyLocationStaffMemberAssignment>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationStaffMemberAssignment>(query);
            return this;
        }
    }
}