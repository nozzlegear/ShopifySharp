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
    public sealed class CustomerSendAccountInviteEmailPayloadQueryBuilder : FieldsQueryBuilderBase<CustomerSendAccountInviteEmailPayload, CustomerSendAccountInviteEmailPayloadQueryBuilder>
    {
        protected override CustomerSendAccountInviteEmailPayloadQueryBuilder Self => this;

        public CustomerSendAccountInviteEmailPayloadQueryBuilder() : this("customerSendAccountInviteEmailPayload")
        {
        }

        public CustomerSendAccountInviteEmailPayloadQueryBuilder(string name) : base(new Query<CustomerSendAccountInviteEmailPayload>(name))
        {
        }

        public CustomerSendAccountInviteEmailPayloadQueryBuilder(IQuery<CustomerSendAccountInviteEmailPayload> query) : base(query)
        {
        }

        public CustomerSendAccountInviteEmailPayloadQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerSendAccountInviteEmailPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSendAccountInviteEmailUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerSendAccountInviteEmailUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSendAccountInviteEmailUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSendAccountInviteEmailUserError>(query);
            return this;
        }
    }
}