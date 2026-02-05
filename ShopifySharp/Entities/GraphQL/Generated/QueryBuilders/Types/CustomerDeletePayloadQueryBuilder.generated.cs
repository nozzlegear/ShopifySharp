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
    public sealed class CustomerDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CustomerDeletePayload, CustomerDeletePayloadQueryBuilder>
    {
        protected override CustomerDeletePayloadQueryBuilder Self => this;

        public CustomerDeletePayloadQueryBuilder() : this("customerDeletePayload")
        {
        }

        public CustomerDeletePayloadQueryBuilder(string name) : base(new Query<CustomerDeletePayload>(name))
        {
        }

        public CustomerDeletePayloadQueryBuilder(IQuery<CustomerDeletePayload> query) : base(query)
        {
        }

        public CustomerDeletePayloadQueryBuilder DeletedCustomerId()
        {
            base.InnerQuery.AddField("deletedCustomerId");
            return this;
        }

        public CustomerDeletePayloadQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public CustomerDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}