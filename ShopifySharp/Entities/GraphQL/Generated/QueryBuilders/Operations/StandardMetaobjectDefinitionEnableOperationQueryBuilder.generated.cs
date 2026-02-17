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
    public sealed class StandardMetaobjectDefinitionEnableOperationQueryBuilder : FieldsQueryBuilderBase<StandardMetaobjectDefinitionEnablePayload, StandardMetaobjectDefinitionEnableOperationQueryBuilder>, IGraphOperationQueryBuilder<StandardMetaobjectDefinitionEnablePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public StandardMetaobjectDefinitionEnableArgumentsBuilder Arguments { get; }
        protected override StandardMetaobjectDefinitionEnableOperationQueryBuilder Self => this;

        public StandardMetaobjectDefinitionEnableOperationQueryBuilder() : this("standardMetaobjectDefinitionEnable")
        {
        }

        public StandardMetaobjectDefinitionEnableOperationQueryBuilder(string name) : base(new Query<StandardMetaobjectDefinitionEnablePayload>(name))
        {
            Arguments = new StandardMetaobjectDefinitionEnableArgumentsBuilder(base.InnerQuery);
        }

        public StandardMetaobjectDefinitionEnableOperationQueryBuilder(IQuery<StandardMetaobjectDefinitionEnablePayload> query) : base(query)
        {
            Arguments = new StandardMetaobjectDefinitionEnableArgumentsBuilder(base.InnerQuery);
        }

        public StandardMetaobjectDefinitionEnableOperationQueryBuilder MetaobjectDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("metaobjectDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinition>(query);
            return this;
        }

        public StandardMetaobjectDefinitionEnableOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}