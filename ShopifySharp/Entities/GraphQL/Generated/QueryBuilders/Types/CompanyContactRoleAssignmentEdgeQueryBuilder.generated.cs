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
    public sealed class CompanyContactRoleAssignmentEdgeQueryBuilder : FieldsQueryBuilderBase<CompanyContactRoleAssignmentEdge, CompanyContactRoleAssignmentEdgeQueryBuilder>
    {
        protected override CompanyContactRoleAssignmentEdgeQueryBuilder Self => this;

        public CompanyContactRoleAssignmentEdgeQueryBuilder() : this("companyContactRoleAssignmentEdge")
        {
        }

        public CompanyContactRoleAssignmentEdgeQueryBuilder(string name) : base(new Query<CompanyContactRoleAssignmentEdge>(name))
        {
        }

        public CompanyContactRoleAssignmentEdgeQueryBuilder(IQuery<CompanyContactRoleAssignmentEdge> query) : base(query)
        {
        }

        public CompanyContactRoleAssignmentEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CompanyContactRoleAssignmentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignment>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignment>(query);
            return this;
        }
    }
}