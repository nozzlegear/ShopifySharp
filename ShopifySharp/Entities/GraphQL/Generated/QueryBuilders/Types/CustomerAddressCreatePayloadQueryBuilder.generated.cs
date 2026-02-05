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
    public sealed class CustomerAddressCreatePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerAddressCreatePayload, CustomerAddressCreatePayloadQueryBuilder>
    {
        protected override CustomerAddressCreatePayloadQueryBuilder Self => this;

        public CustomerAddressCreatePayloadQueryBuilder() : this("customerAddressCreatePayload")
        {
        }

        public CustomerAddressCreatePayloadQueryBuilder(string name) : base(new Query<CustomerAddressCreatePayload>(name))
        {
        }

        public CustomerAddressCreatePayloadQueryBuilder(IQuery<CustomerAddressCreatePayload> query) : base(query)
        {
        }

        public CustomerAddressCreatePayloadQueryBuilder Address(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public CustomerAddressCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}