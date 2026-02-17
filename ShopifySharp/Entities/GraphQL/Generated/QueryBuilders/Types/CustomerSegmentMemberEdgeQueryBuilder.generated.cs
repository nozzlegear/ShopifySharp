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
    public sealed class CustomerSegmentMemberEdgeQueryBuilder : FieldsQueryBuilderBase<CustomerSegmentMemberEdge, CustomerSegmentMemberEdgeQueryBuilder>
    {
        protected override CustomerSegmentMemberEdgeQueryBuilder Self => this;

        public CustomerSegmentMemberEdgeQueryBuilder() : this("customerSegmentMemberEdge")
        {
        }

        public CustomerSegmentMemberEdgeQueryBuilder(string name) : base(new Query<CustomerSegmentMemberEdge>(name))
        {
        }

        public CustomerSegmentMemberEdgeQueryBuilder(IQuery<CustomerSegmentMemberEdge> query) : base(query)
        {
        }

        public CustomerSegmentMemberEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CustomerSegmentMemberEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSegmentMemberQueryBuilder> build)
        {
            var query = new Query<CustomerSegmentMember>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSegmentMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSegmentMember>(query);
            return this;
        }
    }
}