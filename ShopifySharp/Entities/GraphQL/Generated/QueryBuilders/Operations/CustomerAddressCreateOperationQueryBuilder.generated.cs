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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
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

        public CustomerAddressCreateOperationQueryBuilder Address(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public CustomerAddressCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}