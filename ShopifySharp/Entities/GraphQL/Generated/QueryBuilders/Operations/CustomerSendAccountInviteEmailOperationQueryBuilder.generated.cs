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

        public CustomerSendAccountInviteEmailOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerSendAccountInviteEmailOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSendAccountInviteEmailUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerSendAccountInviteEmailUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerSendAccountInviteEmailUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSendAccountInviteEmailUserError>(query);
            return this;
        }
    }
}