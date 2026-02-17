#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ScriptTagQueryBuilder : FieldsQueryBuilderBase<ScriptTag, ScriptTagQueryBuilder>
    {
        protected override ScriptTagQueryBuilder Self => this;

        public ScriptTagQueryBuilder() : this("scriptTag")
        {
        }

        public ScriptTagQueryBuilder(string name) : base(new Query<ScriptTag>(name))
        {
        }

        public ScriptTagQueryBuilder(IQuery<ScriptTag> query) : base(query)
        {
        }

        public ScriptTagQueryBuilder Cache()
        {
            base.InnerQuery.AddField("cache");
            return this;
        }

        public ScriptTagQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ScriptTagQueryBuilder DisplayScope()
        {
            base.InnerQuery.AddField("displayScope");
            return this;
        }

        public ScriptTagQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ScriptTagQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public ScriptTagQueryBuilder Src()
        {
            base.InnerQuery.AddField("src");
            return this;
        }

        public ScriptTagQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}