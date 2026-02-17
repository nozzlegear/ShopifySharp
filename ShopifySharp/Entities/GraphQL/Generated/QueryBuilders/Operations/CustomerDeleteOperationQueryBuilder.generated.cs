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
    public sealed class CustomerDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CustomerDeletePayload, CustomerDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerDeleteArgumentsBuilder Arguments { get; }
        protected override CustomerDeleteOperationQueryBuilder Self => this;

        public CustomerDeleteOperationQueryBuilder() : this("customerDelete")
        {
        }

        public CustomerDeleteOperationQueryBuilder(string name) : base(new Query<CustomerDeletePayload>(name))
        {
            Arguments = new CustomerDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CustomerDeleteOperationQueryBuilder(IQuery<CustomerDeletePayload> query) : base(query)
        {
            Arguments = new CustomerDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CustomerDeleteOperationQueryBuilder DeletedCustomerId()
        {
            base.InnerQuery.AddField("deletedCustomerId");
            return this;
        }

        public CustomerDeleteOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public CustomerDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}