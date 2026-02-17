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
    public sealed class StandardMetafieldDefinitionEnableOperationQueryBuilder : FieldsQueryBuilderBase<StandardMetafieldDefinitionEnablePayload, StandardMetafieldDefinitionEnableOperationQueryBuilder>, IGraphOperationQueryBuilder<StandardMetafieldDefinitionEnablePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public StandardMetafieldDefinitionEnableArgumentsBuilder Arguments { get; }
        protected override StandardMetafieldDefinitionEnableOperationQueryBuilder Self => this;

        public StandardMetafieldDefinitionEnableOperationQueryBuilder() : this("standardMetafieldDefinitionEnable")
        {
        }

        public StandardMetafieldDefinitionEnableOperationQueryBuilder(string name) : base(new Query<StandardMetafieldDefinitionEnablePayload>(name))
        {
            Arguments = new StandardMetafieldDefinitionEnableArgumentsBuilder(base.InnerQuery);
        }

        public StandardMetafieldDefinitionEnableOperationQueryBuilder(IQuery<StandardMetafieldDefinitionEnablePayload> query) : base(query)
        {
            Arguments = new StandardMetafieldDefinitionEnableArgumentsBuilder(base.InnerQuery);
        }

        public StandardMetafieldDefinitionEnableOperationQueryBuilder CreatedDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("createdDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public StandardMetafieldDefinitionEnableOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StandardMetafieldDefinitionEnableUserErrorQueryBuilder> build)
        {
            var query = new Query<StandardMetafieldDefinitionEnableUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StandardMetafieldDefinitionEnableUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardMetafieldDefinitionEnableUserError>(query);
            return this;
        }
    }
}