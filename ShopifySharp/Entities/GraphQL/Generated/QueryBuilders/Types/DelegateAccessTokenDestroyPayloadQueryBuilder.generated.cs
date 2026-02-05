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
    public sealed class DelegateAccessTokenDestroyPayloadQueryBuilder : FieldsQueryBuilderBase<DelegateAccessTokenDestroyPayload, DelegateAccessTokenDestroyPayloadQueryBuilder>
    {
        protected override DelegateAccessTokenDestroyPayloadQueryBuilder Self => this;

        public DelegateAccessTokenDestroyPayloadQueryBuilder() : this("delegateAccessTokenDestroyPayload")
        {
        }

        public DelegateAccessTokenDestroyPayloadQueryBuilder(string name) : base(new Query<DelegateAccessTokenDestroyPayload>(name))
        {
        }

        public DelegateAccessTokenDestroyPayloadQueryBuilder(IQuery<DelegateAccessTokenDestroyPayload> query) : base(query)
        {
        }

        public DelegateAccessTokenDestroyPayloadQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public DelegateAccessTokenDestroyPayloadQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public DelegateAccessTokenDestroyPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DelegateAccessTokenDestroyUserErrorQueryBuilder> build)
        {
            var query = new Query<DelegateAccessTokenDestroyUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DelegateAccessTokenDestroyUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DelegateAccessTokenDestroyUserError>(query);
            return this;
        }
    }
}