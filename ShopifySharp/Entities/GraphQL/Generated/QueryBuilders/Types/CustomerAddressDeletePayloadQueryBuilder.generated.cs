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
    public sealed class CustomerAddressDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerAddressDeletePayload, CustomerAddressDeletePayloadQueryBuilder>
    {
        protected override CustomerAddressDeletePayloadQueryBuilder Self => this;

        public CustomerAddressDeletePayloadQueryBuilder() : this("customerAddressDeletePayload")
        {
        }

        public CustomerAddressDeletePayloadQueryBuilder(string name) : base(new Query<CustomerAddressDeletePayload>(name))
        {
        }

        public CustomerAddressDeletePayloadQueryBuilder(IQuery<CustomerAddressDeletePayload> query) : base(query)
        {
        }

        public CustomerAddressDeletePayloadQueryBuilder DeletedAddressId()
        {
            base.InnerQuery.AddField("deletedAddressId");
            return this;
        }

        public CustomerAddressDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}