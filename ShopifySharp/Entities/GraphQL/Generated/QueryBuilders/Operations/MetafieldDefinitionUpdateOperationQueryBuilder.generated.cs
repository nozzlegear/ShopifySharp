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
    public sealed class MetafieldDefinitionUpdateOperationQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionUpdatePayload, MetafieldDefinitionUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<MetafieldDefinitionUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetafieldDefinitionUpdateArgumentsBuilder Arguments { get; }
        protected override MetafieldDefinitionUpdateOperationQueryBuilder Self => this;

        public MetafieldDefinitionUpdateOperationQueryBuilder() : this("metafieldDefinitionUpdate")
        {
        }

        public MetafieldDefinitionUpdateOperationQueryBuilder(string name) : base(new Query<MetafieldDefinitionUpdatePayload>(name))
        {
            Arguments = new MetafieldDefinitionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionUpdateOperationQueryBuilder(IQuery<MetafieldDefinitionUpdatePayload> query) : base(query)
        {
            Arguments = new MetafieldDefinitionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionUpdateOperationQueryBuilder UpdatedDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("updatedDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public MetafieldDefinitionUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionUpdateUserError>(query);
            return this;
        }

        public MetafieldDefinitionUpdateOperationQueryBuilder ValidationJob(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("validationJob");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }
    }
}