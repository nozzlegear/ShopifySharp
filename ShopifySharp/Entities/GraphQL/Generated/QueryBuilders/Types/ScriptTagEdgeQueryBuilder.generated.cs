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
    public sealed class ScriptTagEdgeQueryBuilder : FieldsQueryBuilderBase<ScriptTagEdge, ScriptTagEdgeQueryBuilder>
    {
        protected override ScriptTagEdgeQueryBuilder Self => this;

        public ScriptTagEdgeQueryBuilder() : this("scriptTagEdge")
        {
        }

        public ScriptTagEdgeQueryBuilder(string name) : base(new Query<ScriptTagEdge>(name))
        {
        }

        public ScriptTagEdgeQueryBuilder(IQuery<ScriptTagEdge> query) : base(query)
        {
        }

        public ScriptTagEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ScriptTagEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ScriptTagQueryBuilder> build)
        {
            var query = new Query<ScriptTag>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ScriptTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ScriptTag>(query);
            return this;
        }
    }
}