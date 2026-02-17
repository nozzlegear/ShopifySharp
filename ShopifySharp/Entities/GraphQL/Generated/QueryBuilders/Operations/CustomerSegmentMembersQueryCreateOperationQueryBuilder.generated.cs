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
    public sealed class CustomerSegmentMembersQueryCreateOperationQueryBuilder : FieldsQueryBuilderBase<CustomerSegmentMembersQueryCreatePayload, CustomerSegmentMembersQueryCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerSegmentMembersQueryCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerSegmentMembersQueryCreateArgumentsBuilder Arguments { get; }
        protected override CustomerSegmentMembersQueryCreateOperationQueryBuilder Self => this;

        public CustomerSegmentMembersQueryCreateOperationQueryBuilder() : this("customerSegmentMembersQueryCreate")
        {
        }

        public CustomerSegmentMembersQueryCreateOperationQueryBuilder(string name) : base(new Query<CustomerSegmentMembersQueryCreatePayload>(name))
        {
            Arguments = new CustomerSegmentMembersQueryCreateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSegmentMembersQueryCreateOperationQueryBuilder(IQuery<CustomerSegmentMembersQueryCreatePayload> query) : base(query)
        {
            Arguments = new CustomerSegmentMembersQueryCreateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSegmentMembersQueryCreateOperationQueryBuilder CustomerSegmentMembersQuery(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSegmentMembersQueryQueryBuilder> build)
        {
            var query = new Query<CustomerSegmentMembersQuery>("customerSegmentMembersQuery");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSegmentMembersQueryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSegmentMembersQuery>(query);
            return this;
        }

        public CustomerSegmentMembersQueryCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSegmentMembersQueryUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerSegmentMembersQueryUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSegmentMembersQueryUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSegmentMembersQueryUserError>(query);
            return this;
        }
    }
}