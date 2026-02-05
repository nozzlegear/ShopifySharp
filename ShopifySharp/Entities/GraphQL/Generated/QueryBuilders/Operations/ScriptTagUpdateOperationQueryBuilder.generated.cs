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
    public sealed class ScriptTagUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ScriptTagUpdatePayload, ScriptTagUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ScriptTagUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ScriptTagUpdateArgumentsBuilder Arguments { get; }
        protected override ScriptTagUpdateOperationQueryBuilder Self => this;

        public ScriptTagUpdateOperationQueryBuilder() : this("scriptTagUpdate")
        {
        }

        public ScriptTagUpdateOperationQueryBuilder(string name) : base(new Query<ScriptTagUpdatePayload>(name))
        {
            Arguments = new ScriptTagUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ScriptTagUpdateOperationQueryBuilder(IQuery<ScriptTagUpdatePayload> query) : base(query)
        {
            Arguments = new ScriptTagUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ScriptTagUpdateOperationQueryBuilder ScriptTag(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ScriptTagQueryBuilder> build)
        {
            var query = new Query<ScriptTag>("scriptTag");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ScriptTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ScriptTag>(query);
            return this;
        }

        public ScriptTagUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}