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
    public sealed class DelegateAccessTokenCreatePayloadQueryBuilder : FieldsQueryBuilderBase<DelegateAccessTokenCreatePayload, DelegateAccessTokenCreatePayloadQueryBuilder>
    {
        protected override DelegateAccessTokenCreatePayloadQueryBuilder Self => this;

        public DelegateAccessTokenCreatePayloadQueryBuilder() : this("delegateAccessTokenCreatePayload")
        {
        }

        public DelegateAccessTokenCreatePayloadQueryBuilder(string name) : base(new Query<DelegateAccessTokenCreatePayload>(name))
        {
        }

        public DelegateAccessTokenCreatePayloadQueryBuilder(IQuery<DelegateAccessTokenCreatePayload> query) : base(query)
        {
        }

        public DelegateAccessTokenCreatePayloadQueryBuilder DelegateAccessToken(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DelegateAccessTokenQueryBuilder> build)
        {
            var query = new Query<DelegateAccessToken>("delegateAccessToken");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DelegateAccessTokenQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DelegateAccessToken>(query);
            return this;
        }

        public DelegateAccessTokenCreatePayloadQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public DelegateAccessTokenCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DelegateAccessTokenCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<DelegateAccessTokenCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DelegateAccessTokenCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DelegateAccessTokenCreateUserError>(query);
            return this;
        }
    }
}