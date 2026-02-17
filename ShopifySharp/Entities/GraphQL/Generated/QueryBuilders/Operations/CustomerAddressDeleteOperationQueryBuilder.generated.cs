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
    public sealed class CustomerAddressDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CustomerAddressDeletePayload, CustomerAddressDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerAddressDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerAddressDeleteArgumentsBuilder Arguments { get; }
        protected override CustomerAddressDeleteOperationQueryBuilder Self => this;

        public CustomerAddressDeleteOperationQueryBuilder() : this("customerAddressDelete")
        {
        }

        public CustomerAddressDeleteOperationQueryBuilder(string name) : base(new Query<CustomerAddressDeletePayload>(name))
        {
            Arguments = new CustomerAddressDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAddressDeleteOperationQueryBuilder(IQuery<CustomerAddressDeletePayload> query) : base(query)
        {
            Arguments = new CustomerAddressDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAddressDeleteOperationQueryBuilder DeletedAddressId()
        {
            base.InnerQuery.AddField("deletedAddressId");
            return this;
        }

        public CustomerAddressDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}