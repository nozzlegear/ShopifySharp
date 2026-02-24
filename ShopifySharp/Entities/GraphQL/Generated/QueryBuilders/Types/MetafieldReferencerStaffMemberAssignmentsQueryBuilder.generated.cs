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
    public sealed class MetafieldReferencerStaffMemberAssignmentsQueryBuilder : FieldsQueryBuilderBase<CompanyLocationStaffMemberAssignmentConnection, MetafieldReferencerStaffMemberAssignmentsQueryBuilder>, IHasArguments<MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder>
    {
        public MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerStaffMemberAssignmentsQueryBuilder Self => this;

        public MetafieldReferencerStaffMemberAssignmentsQueryBuilder(string name) : base(new Query<CompanyLocationStaffMemberAssignmentConnection>(name))
        {
            Arguments = new MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerStaffMemberAssignmentsQueryBuilder(IQuery<CompanyLocationStaffMemberAssignmentConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerStaffMemberAssignmentsQueryBuilder SetArguments(Action<MetafieldReferencerStaffMemberAssignmentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerStaffMemberAssignmentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyLocationStaffMemberAssignmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationStaffMemberAssignmentEdge>(query);
            return this;
        }

        public MetafieldReferencerStaffMemberAssignmentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentQueryBuilder> build)
        {
            var query = new Query<CompanyLocationStaffMemberAssignment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationStaffMemberAssignment>(query);
            return this;
        }

        public MetafieldReferencerStaffMemberAssignmentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}