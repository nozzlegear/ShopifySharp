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
    public sealed class StaffMemberEdgeQueryBuilder : FieldsQueryBuilderBase<StaffMemberEdge, StaffMemberEdgeQueryBuilder>
    {
        protected override StaffMemberEdgeQueryBuilder Self => this;

        public StaffMemberEdgeQueryBuilder() : this("staffMemberEdge")
        {
        }

        public StaffMemberEdgeQueryBuilder(string name) : base(new Query<StaffMemberEdge>(name))
        {
        }

        public StaffMemberEdgeQueryBuilder(IQuery<StaffMemberEdge> query) : base(query)
        {
        }

        public StaffMemberEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public StaffMemberEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }
    }
}