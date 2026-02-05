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
    public sealed class ScriptTagCreatePayloadQueryBuilder : FieldsQueryBuilderBase<ScriptTagCreatePayload, ScriptTagCreatePayloadQueryBuilder>
    {
        protected override ScriptTagCreatePayloadQueryBuilder Self => this;

        public ScriptTagCreatePayloadQueryBuilder() : this("scriptTagCreatePayload")
        {
        }

        public ScriptTagCreatePayloadQueryBuilder(string name) : base(new Query<ScriptTagCreatePayload>(name))
        {
        }

        public ScriptTagCreatePayloadQueryBuilder(IQuery<ScriptTagCreatePayload> query) : base(query)
        {
        }

        public ScriptTagCreatePayloadQueryBuilder ScriptTag(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ScriptTagQueryBuilder> build)
        {
            var query = new Query<ScriptTag>("scriptTag");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ScriptTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ScriptTag>(query);
            return this;
        }

        public ScriptTagCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}