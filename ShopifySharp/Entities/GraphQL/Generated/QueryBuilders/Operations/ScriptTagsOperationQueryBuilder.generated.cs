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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class ScriptTagsOperationQueryBuilder : FieldsQueryBuilderBase<ScriptTagConnection, ScriptTagsOperationQueryBuilder>, IGraphOperationQueryBuilder<ScriptTagConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ScriptTagsArgumentsBuilder Arguments { get; }
        protected override ScriptTagsOperationQueryBuilder Self => this;

        public ScriptTagsOperationQueryBuilder() : this("scriptTags")
        {
        }

        public ScriptTagsOperationQueryBuilder(string name) : base(new Query<ScriptTagConnection>(name))
        {
            Arguments = new ScriptTagsArgumentsBuilder(base.InnerQuery);
        }

        public ScriptTagsOperationQueryBuilder(IQuery<ScriptTagConnection> query) : base(query)
        {
            Arguments = new ScriptTagsArgumentsBuilder(base.InnerQuery);
        }

        public ScriptTagsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ScriptTagEdgeQueryBuilder> build)
        {
            var query = new Query<ScriptTagEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ScriptTagEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ScriptTagEdge>(query);
            return this;
        }

        public ScriptTagsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ScriptTagQueryBuilder> build)
        {
            var query = new Query<ScriptTag>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ScriptTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ScriptTag>(query);
            return this;
        }

        public ScriptTagsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}