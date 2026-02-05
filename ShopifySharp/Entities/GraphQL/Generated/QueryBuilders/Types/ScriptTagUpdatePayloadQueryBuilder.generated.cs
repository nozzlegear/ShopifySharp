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
    public sealed class ScriptTagUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<ScriptTagUpdatePayload, ScriptTagUpdatePayloadQueryBuilder>
    {
        protected override ScriptTagUpdatePayloadQueryBuilder Self => this;

        public ScriptTagUpdatePayloadQueryBuilder() : this("scriptTagUpdatePayload")
        {
        }

        public ScriptTagUpdatePayloadQueryBuilder(string name) : base(new Query<ScriptTagUpdatePayload>(name))
        {
        }

        public ScriptTagUpdatePayloadQueryBuilder(IQuery<ScriptTagUpdatePayload> query) : base(query)
        {
        }

        public ScriptTagUpdatePayloadQueryBuilder ScriptTag(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ScriptTagQueryBuilder> build)
        {
            var query = new Query<ScriptTag>("scriptTag");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ScriptTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ScriptTag>(query);
            return this;
        }

        public ScriptTagUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}