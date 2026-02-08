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
    public sealed class MetafieldDefinitionCreateOperationQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionCreatePayload, MetafieldDefinitionCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<MetafieldDefinitionCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetafieldDefinitionCreateArgumentsBuilder Arguments { get; }
        protected override MetafieldDefinitionCreateOperationQueryBuilder Self => this;

        public MetafieldDefinitionCreateOperationQueryBuilder() : this("metafieldDefinitionCreate")
        {
        }

        public MetafieldDefinitionCreateOperationQueryBuilder(string name) : base(new Query<MetafieldDefinitionCreatePayload>(name))
        {
            Arguments = new MetafieldDefinitionCreateArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionCreateOperationQueryBuilder(IQuery<MetafieldDefinitionCreatePayload> query) : base(query)
        {
            Arguments = new MetafieldDefinitionCreateArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionCreateOperationQueryBuilder CreatedDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("createdDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public MetafieldDefinitionCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionCreateUserError>(query);
            return this;
        }
    }
}