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
    public sealed class ScriptTagOperationQueryBuilder : FieldsQueryBuilderBase<ScriptTag, ScriptTagOperationQueryBuilder>, IGraphOperationQueryBuilder<ScriptTag>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ScriptTagArgumentsBuilder Arguments { get; }
        protected override ScriptTagOperationQueryBuilder Self => this;

        public ScriptTagOperationQueryBuilder() : this("scriptTag")
        {
        }

        public ScriptTagOperationQueryBuilder(string name) : base(new Query<ScriptTag>(name))
        {
            Arguments = new ScriptTagArgumentsBuilder(base.InnerQuery);
        }

        public ScriptTagOperationQueryBuilder(IQuery<ScriptTag> query) : base(query)
        {
            Arguments = new ScriptTagArgumentsBuilder(base.InnerQuery);
        }

        public ScriptTagOperationQueryBuilder Cache()
        {
            base.InnerQuery.AddField("cache");
            return this;
        }

        public ScriptTagOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ScriptTagOperationQueryBuilder DisplayScope()
        {
            base.InnerQuery.AddField("displayScope");
            return this;
        }

        public ScriptTagOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ScriptTagOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public ScriptTagOperationQueryBuilder Src()
        {
            base.InnerQuery.AddField("src");
            return this;
        }

        public ScriptTagOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}