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
    public sealed class ScriptTagDeletePayloadQueryBuilder : FieldsQueryBuilderBase<ScriptTagDeletePayload, ScriptTagDeletePayloadQueryBuilder>
    {
        protected override ScriptTagDeletePayloadQueryBuilder Self => this;

        public ScriptTagDeletePayloadQueryBuilder() : this("scriptTagDeletePayload")
        {
        }

        public ScriptTagDeletePayloadQueryBuilder(string name) : base(new Query<ScriptTagDeletePayload>(name))
        {
        }

        public ScriptTagDeletePayloadQueryBuilder(IQuery<ScriptTagDeletePayload> query) : base(query)
        {
        }

        public ScriptTagDeletePayloadQueryBuilder DeletedScriptTagId()
        {
            base.InnerQuery.AddField("deletedScriptTagId");
            return this;
        }

        public ScriptTagDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}