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

        public StaffMemberEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }
    }
}