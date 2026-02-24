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
    public sealed class CompanyContactRoleAssignmentConnectionQueryBuilder : FieldsQueryBuilderBase<CompanyContactRoleAssignmentConnection, CompanyContactRoleAssignmentConnectionQueryBuilder>, IHasArguments<CompanyContactRoleAssignmentConnectionArgumentsBuilder>
    {
        public CompanyContactRoleAssignmentConnectionArgumentsBuilder Arguments { get; }
        protected override CompanyContactRoleAssignmentConnectionQueryBuilder Self => this;

        public CompanyContactRoleAssignmentConnectionQueryBuilder() : this("companyContactRoleAssignmentConnection")
        {
        }

        public CompanyContactRoleAssignmentConnectionQueryBuilder(string name) : base(new Query<CompanyContactRoleAssignmentConnection>(name))
        {
            Arguments = new CompanyContactRoleAssignmentConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactRoleAssignmentConnectionQueryBuilder(IQuery<CompanyContactRoleAssignmentConnection> query) : base(query)
        {
            Arguments = new CompanyContactRoleAssignmentConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactRoleAssignmentConnectionQueryBuilder SetArguments(Action<CompanyContactRoleAssignmentConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CompanyContactRoleAssignmentConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignmentEdge>(query);
            return this;
        }

        public CompanyContactRoleAssignmentConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignment>(query);
            return this;
        }

        public CompanyContactRoleAssignmentConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}