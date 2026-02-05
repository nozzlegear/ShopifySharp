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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CustomerSendAccountInviteEmailUserErrorQueryBuilder : FieldsQueryBuilderBase<CustomerSendAccountInviteEmailUserError, CustomerSendAccountInviteEmailUserErrorQueryBuilder>
    {
        protected override CustomerSendAccountInviteEmailUserErrorQueryBuilder Self => this;

        public CustomerSendAccountInviteEmailUserErrorQueryBuilder() : this("customerSendAccountInviteEmailUserError")
        {
        }

        public CustomerSendAccountInviteEmailUserErrorQueryBuilder(string name) : base(new Query<CustomerSendAccountInviteEmailUserError>(name))
        {
        }

        public CustomerSendAccountInviteEmailUserErrorQueryBuilder(IQuery<CustomerSendAccountInviteEmailUserError> query) : base(query)
        {
        }

        public CustomerSendAccountInviteEmailUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CustomerSendAccountInviteEmailUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CustomerSendAccountInviteEmailUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}