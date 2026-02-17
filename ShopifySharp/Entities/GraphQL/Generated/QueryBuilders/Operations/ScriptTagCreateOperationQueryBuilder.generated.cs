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
    public sealed class ScriptTagCreateOperationQueryBuilder : FieldsQueryBuilderBase<ScriptTagCreatePayload, ScriptTagCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<ScriptTagCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ScriptTagCreateArgumentsBuilder Arguments { get; }
        protected override ScriptTagCreateOperationQueryBuilder Self => this;

        public ScriptTagCreateOperationQueryBuilder() : this("scriptTagCreate")
        {
        }

        public ScriptTagCreateOperationQueryBuilder(string name) : base(new Query<ScriptTagCreatePayload>(name))
        {
            Arguments = new ScriptTagCreateArgumentsBuilder(base.InnerQuery);
        }

        public ScriptTagCreateOperationQueryBuilder(IQuery<ScriptTagCreatePayload> query) : base(query)
        {
            Arguments = new ScriptTagCreateArgumentsBuilder(base.InnerQuery);
        }

        public ScriptTagCreateOperationQueryBuilder ScriptTag(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ScriptTagQueryBuilder> build)
        {
            var query = new Query<ScriptTag>("scriptTag");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ScriptTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ScriptTag>(query);
            return this;
        }

        public ScriptTagCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}