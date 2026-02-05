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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ScriptTagDeleteOperationQueryBuilder : FieldsQueryBuilderBase<ScriptTagDeletePayload, ScriptTagDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<ScriptTagDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ScriptTagDeleteArgumentsBuilder Arguments { get; }
        protected override ScriptTagDeleteOperationQueryBuilder Self => this;

        public ScriptTagDeleteOperationQueryBuilder() : this("scriptTagDelete")
        {
        }

        public ScriptTagDeleteOperationQueryBuilder(string name) : base(new Query<ScriptTagDeletePayload>(name))
        {
            Arguments = new ScriptTagDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ScriptTagDeleteOperationQueryBuilder(IQuery<ScriptTagDeletePayload> query) : base(query)
        {
            Arguments = new ScriptTagDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ScriptTagDeleteOperationQueryBuilder DeletedScriptTagId()
        {
            base.InnerQuery.AddField("deletedScriptTagId");
            return this;
        }

        public ScriptTagDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}