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
    public sealed class CustomerSegmentMembersQueryQueryBuilder : FieldsQueryBuilderBase<CustomerSegmentMembersQuery, CustomerSegmentMembersQueryQueryBuilder>
    {
        protected override CustomerSegmentMembersQueryQueryBuilder Self => this;

        public CustomerSegmentMembersQueryQueryBuilder() : this("customerSegmentMembersQuery")
        {
        }

        public CustomerSegmentMembersQueryQueryBuilder(string name) : base(new Query<CustomerSegmentMembersQuery>(name))
        {
        }

        public CustomerSegmentMembersQueryQueryBuilder(IQuery<CustomerSegmentMembersQuery> query) : base(query)
        {
        }

        public CustomerSegmentMembersQueryQueryBuilder CurrentCount()
        {
            base.InnerQuery.AddField("currentCount");
            return this;
        }

        public CustomerSegmentMembersQueryQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public CustomerSegmentMembersQueryQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}