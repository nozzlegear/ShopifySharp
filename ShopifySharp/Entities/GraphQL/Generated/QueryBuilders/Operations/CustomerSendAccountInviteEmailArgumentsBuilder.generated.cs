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
    public sealed class CustomerSendAccountInviteEmailArgumentsBuilder : ArgumentsBuilderBase<CustomerSendAccountInviteEmailPayload, CustomerSendAccountInviteEmailArgumentsBuilder>
    {
        protected override CustomerSendAccountInviteEmailArgumentsBuilder Self => this;

        public CustomerSendAccountInviteEmailArgumentsBuilder(IQuery<CustomerSendAccountInviteEmailPayload> query) : base(query)
        {
        }

        public CustomerSendAccountInviteEmailArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }

        public CustomerSendAccountInviteEmailArgumentsBuilder Email(EmailInput? email)
        {
            base.InnerQuery.AddArgument("email", email);
            return this;
        }
    }
}