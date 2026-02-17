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
    public sealed class CustomerAddressCreateOperationQueryBuilder : FieldsQueryBuilderBase<CustomerAddressCreatePayload, CustomerAddressCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerAddressCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerAddressCreateArgumentsBuilder Arguments { get; }
        protected override CustomerAddressCreateOperationQueryBuilder Self => this;

        public CustomerAddressCreateOperationQueryBuilder() : this("customerAddressCreate")
        {
        }

        public CustomerAddressCreateOperationQueryBuilder(string name) : base(new Query<CustomerAddressCreatePayload>(name))
        {
            Arguments = new CustomerAddressCreateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAddressCreateOperationQueryBuilder(IQuery<CustomerAddressCreatePayload> query) : base(query)
        {
            Arguments = new CustomerAddressCreateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAddressCreateOperationQueryBuilder Address(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public CustomerAddressCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}