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
    public sealed class ShopPolicyUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<ShopPolicyUpdatePayload, ShopPolicyUpdatePayloadQueryBuilder>
    {
        protected override ShopPolicyUpdatePayloadQueryBuilder Self => this;

        public ShopPolicyUpdatePayloadQueryBuilder() : this("shopPolicyUpdatePayload")
        {
        }

        public ShopPolicyUpdatePayloadQueryBuilder(string name) : base(new Query<ShopPolicyUpdatePayload>(name))
        {
        }

        public ShopPolicyUpdatePayloadQueryBuilder(IQuery<ShopPolicyUpdatePayload> query) : base(query)
        {
        }

        public ShopPolicyUpdatePayloadQueryBuilder ShopPolicy(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPolicyQueryBuilder> build)
        {
            var query = new Query<ShopPolicy>("shopPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPolicy>(query);
            return this;
        }

        public ShopPolicyUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPolicyUserErrorQueryBuilder> build)
        {
            var query = new Query<ShopPolicyUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopPolicyUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPolicyUserError>(query);
            return this;
        }
    }
}