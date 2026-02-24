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
    public sealed class QueryRootStaffMembersQueryBuilder : FieldsQueryBuilderBase<StaffMemberConnection, QueryRootStaffMembersQueryBuilder>, IHasArguments<QueryRootStaffMembersArgumentsBuilder>
    {
        public QueryRootStaffMembersArgumentsBuilder Arguments { get; }
        protected override QueryRootStaffMembersQueryBuilder Self => this;

        public QueryRootStaffMembersQueryBuilder(string name) : base(new Query<StaffMemberConnection>(name))
        {
            Arguments = new QueryRootStaffMembersArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootStaffMembersQueryBuilder(IQuery<StaffMemberConnection> query) : base(query)
        {
            Arguments = new QueryRootStaffMembersArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootStaffMembersQueryBuilder SetArguments(Action<QueryRootStaffMembersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootStaffMembersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberEdgeQueryBuilder> build)
        {
            var query = new Query<StaffMemberEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMemberEdge>(query);
            return this;
        }

        public QueryRootStaffMembersQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public QueryRootStaffMembersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}