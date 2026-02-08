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