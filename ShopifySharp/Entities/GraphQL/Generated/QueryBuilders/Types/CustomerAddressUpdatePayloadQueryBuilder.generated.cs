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
    public sealed class CustomerAddressUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerAddressUpdatePayload, CustomerAddressUpdatePayloadQueryBuilder>
    {
        protected override CustomerAddressUpdatePayloadQueryBuilder Self => this;

        public CustomerAddressUpdatePayloadQueryBuilder() : this("customerAddressUpdatePayload")
        {
        }

        public CustomerAddressUpdatePayloadQueryBuilder(string name) : base(new Query<CustomerAddressUpdatePayload>(name))
        {
        }

        public CustomerAddressUpdatePayloadQueryBuilder(IQuery<CustomerAddressUpdatePayload> query) : base(query)
        {
        }

        public CustomerAddressUpdatePayloadQueryBuilder Address(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public CustomerAddressUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}