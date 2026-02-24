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
    public sealed class QueryRootScriptTagQueryBuilder : FieldsQueryBuilderBase<ScriptTag, QueryRootScriptTagQueryBuilder>, IHasArguments<QueryRootScriptTagArgumentsBuilder>
    {
        public QueryRootScriptTagArgumentsBuilder Arguments { get; }
        protected override QueryRootScriptTagQueryBuilder Self => this;

        public QueryRootScriptTagQueryBuilder(string name) : base(new Query<ScriptTag>(name))
        {
            Arguments = new QueryRootScriptTagArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootScriptTagQueryBuilder(IQuery<ScriptTag> query) : base(query)
        {
            Arguments = new QueryRootScriptTagArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootScriptTagQueryBuilder SetArguments(Action<QueryRootScriptTagArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootScriptTagQueryBuilder Cache()
        {
            base.InnerQuery.AddField("cache");
            return this;
        }

        public QueryRootScriptTagQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootScriptTagQueryBuilder DisplayScope()
        {
            base.InnerQuery.AddField("displayScope");
            return this;
        }

        public QueryRootScriptTagQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootScriptTagQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public QueryRootScriptTagQueryBuilder Src()
        {
            base.InnerQuery.AddField("src");
            return this;
        }

        public QueryRootScriptTagQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}