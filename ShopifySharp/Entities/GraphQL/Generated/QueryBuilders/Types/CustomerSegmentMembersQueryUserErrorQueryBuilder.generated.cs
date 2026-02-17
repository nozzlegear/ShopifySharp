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
    public sealed class CustomerSegmentMembersQueryUserErrorQueryBuilder : FieldsQueryBuilderBase<CustomerSegmentMembersQueryUserError, CustomerSegmentMembersQueryUserErrorQueryBuilder>
    {
        protected override CustomerSegmentMembersQueryUserErrorQueryBuilder Self => this;

        public CustomerSegmentMembersQueryUserErrorQueryBuilder() : this("customerSegmentMembersQueryUserError")
        {
        }

        public CustomerSegmentMembersQueryUserErrorQueryBuilder(string name) : base(new Query<CustomerSegmentMembersQueryUserError>(name))
        {
        }

        public CustomerSegmentMembersQueryUserErrorQueryBuilder(IQuery<CustomerSegmentMembersQueryUserError> query) : base(query)
        {
        }

        public CustomerSegmentMembersQueryUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerSegmentMembersQueryUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerSegmentMembersQueryUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}