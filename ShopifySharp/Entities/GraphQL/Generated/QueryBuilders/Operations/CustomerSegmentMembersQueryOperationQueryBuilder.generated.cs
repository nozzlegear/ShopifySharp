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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CustomerSegmentMembersQueryOperationQueryBuilder : FieldsQueryBuilderBase<CustomerSegmentMembersQuery, CustomerSegmentMembersQueryOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerSegmentMembersQuery>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CustomerSegmentMembersQueryArgumentsBuilder Arguments { get; }
        protected override CustomerSegmentMembersQueryOperationQueryBuilder Self => this;

        public CustomerSegmentMembersQueryOperationQueryBuilder() : this("customerSegmentMembersQuery")
        {
        }

        public CustomerSegmentMembersQueryOperationQueryBuilder(string name) : base(new Query<CustomerSegmentMembersQuery>(name))
        {
            Arguments = new CustomerSegmentMembersQueryArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSegmentMembersQueryOperationQueryBuilder(IQuery<CustomerSegmentMembersQuery> query) : base(query)
        {
            Arguments = new CustomerSegmentMembersQueryArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSegmentMembersQueryOperationQueryBuilder CurrentCount()
        {
            base.InnerQuery.AddField("currentCount");
            return this;
        }

        public CustomerSegmentMembersQueryOperationQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public CustomerSegmentMembersQueryOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}