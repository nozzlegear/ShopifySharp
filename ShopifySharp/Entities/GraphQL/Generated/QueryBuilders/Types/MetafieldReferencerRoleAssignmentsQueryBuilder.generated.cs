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
    public sealed class MetafieldReferencerRoleAssignmentsQueryBuilder : FieldsQueryBuilderBase<CompanyContactRoleAssignmentConnection, MetafieldReferencerRoleAssignmentsQueryBuilder>, IHasArguments<MetafieldReferencerRoleAssignmentsArgumentsBuilder>
    {
        public MetafieldReferencerRoleAssignmentsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerRoleAssignmentsQueryBuilder Self => this;

        public MetafieldReferencerRoleAssignmentsQueryBuilder(string name) : base(new Query<CompanyContactRoleAssignmentConnection>(name))
        {
            Arguments = new MetafieldReferencerRoleAssignmentsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerRoleAssignmentsQueryBuilder(IQuery<CompanyContactRoleAssignmentConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerRoleAssignmentsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerRoleAssignmentsQueryBuilder SetArguments(Action<MetafieldReferencerRoleAssignmentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerRoleAssignmentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignmentEdge>(query);
            return this;
        }

        public MetafieldReferencerRoleAssignmentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignment>(query);
            return this;
        }

        public MetafieldReferencerRoleAssignmentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}