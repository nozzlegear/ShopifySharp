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
    public sealed class MetafieldReferencerStaffMembersQueryBuilder : FieldsQueryBuilderBase<StaffMemberConnection, MetafieldReferencerStaffMembersQueryBuilder>, IHasArguments<MetafieldReferencerStaffMembersArgumentsBuilder>
    {
        public MetafieldReferencerStaffMembersArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerStaffMembersQueryBuilder Self => this;

        public MetafieldReferencerStaffMembersQueryBuilder(string name) : base(new Query<StaffMemberConnection>(name))
        {
            Arguments = new MetafieldReferencerStaffMembersArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerStaffMembersQueryBuilder(IQuery<StaffMemberConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerStaffMembersArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerStaffMembersQueryBuilder SetArguments(Action<MetafieldReferencerStaffMembersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerStaffMembersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberEdgeQueryBuilder> build)
        {
            var query = new Query<StaffMemberEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMemberEdge>(query);
            return this;
        }

        public MetafieldReferencerStaffMembersQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public MetafieldReferencerStaffMembersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}