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

        public CustomerAddressUpdateOperationQueryBuilder Address(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public CustomerAddressUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}