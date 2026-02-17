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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class CompanyLocationStaffMemberAssignmentConnectionQueryBuilder : FieldsQueryBuilderBase<CompanyLocationStaffMemberAssignmentConnection, CompanyLocationStaffMemberAssignmentConnectionQueryBuilder>
    {
        protected override CompanyLocationStaffMemberAssignmentConnectionQueryBuilder Self => this;

        public CompanyLocationStaffMemberAssignmentConnectionQueryBuilder() : this("companyLocationStaffMemberAssignmentConnection")
        {
        }

        public CompanyLocationStaffMemberAssignmentConnectionQueryBuilder(string name) : base(new Query<CompanyLocationStaffMemberAssignmentConnection>(name))
        {
        }

        public CompanyLocationStaffMemberAssignmentConnectionQueryBuilder(IQuery<CompanyLocationStaffMemberAssignmentConnection> query) : base(query)
        {
        }

        public CompanyLocationStaffMemberAssignmentConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyLocationStaffMemberAssignmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationStaffMemberAssignmentEdge>(query);
            return this;
        }

        public CompanyLocationStaffMemberAssignmentConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyLocationStaffMemberAssignment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationStaffMemberAssignment>(query);
            return this;
        }

        public CompanyLocationStaffMemberAssignmentConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}