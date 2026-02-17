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

        public ScriptTagUpdateOperationQueryBuilder ScriptTag(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ScriptTagQueryBuilder> build)
        {
            var query = new Query<ScriptTag>("scriptTag");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ScriptTagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ScriptTag>(query);
            return this;
        }

        public ScriptTagUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}