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
    public sealed class CustomerSendAccountInviteEmailOperationQueryBuilder : FieldsQueryBuilderBase<CustomerSendAccountInviteEmailPayload, CustomerSendAccountInviteEmailOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerSendAccountInviteEmailPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerSendAccountInviteEmailArgumentsBuilder Arguments { get; }
        protected override CustomerSendAccountInviteEmailOperationQueryBuilder Self => this;

        public CustomerSendAccountInviteEmailOperationQueryBuilder() : this("customerSendAccountInviteEmail")
        {
        }

        public CustomerSendAccountInviteEmailOperationQueryBuilder(string name) : base(new Query<CustomerSendAccountInviteEmailPayload>(name))
        {
            Arguments = new CustomerSendAccountInviteEmailArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSendAccountInviteEmailOperationQueryBuilder(IQuery<CustomerSendAccountInviteEmailPayload> query) : base(query)
        {
            Arguments = new CustomerSendAccountInviteEmailArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSendAccountInviteEmailOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerSendAccountInviteEmailOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSendAccountInviteEmailUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerSendAccountInviteEmailUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSendAccountInviteEmailUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSendAccountInviteEmailUserError>(query);
            return this;
        }
    }
}