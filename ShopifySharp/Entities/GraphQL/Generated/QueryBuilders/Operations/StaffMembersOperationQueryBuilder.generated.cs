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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class StaffMembersOperationQueryBuilder : FieldsQueryBuilderBase<StaffMemberConnection, StaffMembersOperationQueryBuilder>, IGraphOperationQueryBuilder<StaffMemberConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public StaffMembersArgumentsBuilder Arguments { get; }
        protected override StaffMembersOperationQueryBuilder Self => this;

        public StaffMembersOperationQueryBuilder() : this("staffMembers")
        {
        }

        public StaffMembersOperationQueryBuilder(string name) : base(new Query<StaffMemberConnection>(name))
        {
            Arguments = new StaffMembersArgumentsBuilder(base.InnerQuery);
        }

        public StaffMembersOperationQueryBuilder(IQuery<StaffMemberConnection> query) : base(query)
        {
            Arguments = new StaffMembersArgumentsBuilder(base.InnerQuery);
        }

        public StaffMembersOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberEdgeQueryBuilder> build)
        {
            var query = new Query<StaffMemberEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMemberEdge>(query);
            return this;
        }

        public StaffMembersOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public StaffMembersOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}