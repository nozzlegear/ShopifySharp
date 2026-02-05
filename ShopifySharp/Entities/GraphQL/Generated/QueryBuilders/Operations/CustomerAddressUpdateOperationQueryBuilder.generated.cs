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
    public sealed class CustomerAddressUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CustomerAddressUpdatePayload, CustomerAddressUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerAddressUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerAddressUpdateArgumentsBuilder Arguments { get; }
        protected override CustomerAddressUpdateOperationQueryBuilder Self => this;

        public CustomerAddressUpdateOperationQueryBuilder() : this("customerAddressUpdate")
        {
        }

        public CustomerAddressUpdateOperationQueryBuilder(string name) : base(new Query<CustomerAddressUpdatePayload>(name))
        {
            Arguments = new CustomerAddressUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAddressUpdateOperationQueryBuilder(IQuery<CustomerAddressUpdatePayload> query) : base(query)
        {
            Arguments = new CustomerAddressUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAddressUpdateOperationQueryBuilder Address(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public CustomerAddressUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}