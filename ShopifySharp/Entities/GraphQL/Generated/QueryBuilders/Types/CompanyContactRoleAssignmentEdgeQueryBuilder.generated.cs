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

        public CompanyContactRoleAssignmentEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignment>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignment>(query);
            return this;
        }
    }
}