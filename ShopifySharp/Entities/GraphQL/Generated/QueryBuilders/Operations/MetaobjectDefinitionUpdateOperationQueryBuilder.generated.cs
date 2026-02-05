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
    public sealed class MetaobjectDefinitionUpdateOperationQueryBuilder : FieldsQueryBuilderBase<MetaobjectDefinitionUpdatePayload, MetaobjectDefinitionUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<MetaobjectDefinitionUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetaobjectDefinitionUpdateArgumentsBuilder Arguments { get; }
        protected override MetaobjectDefinitionUpdateOperationQueryBuilder Self => this;

        public MetaobjectDefinitionUpdateOperationQueryBuilder() : this("metaobjectDefinitionUpdate")
        {
        }

        public MetaobjectDefinitionUpdateOperationQueryBuilder(string name) : base(new Query<MetaobjectDefinitionUpdatePayload>(name))
        {
            Arguments = new MetaobjectDefinitionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectDefinitionUpdateOperationQueryBuilder(IQuery<MetaobjectDefinitionUpdatePayload> query) : base(query)
        {
            Arguments = new MetaobjectDefinitionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectDefinitionUpdateOperationQueryBuilder MetaobjectDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder> build)
        {
            var query = new Query<MetaobjectDefinition>("metaobjectDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectDefinition>(query);
            return this;
        }

        public MetaobjectDefinitionUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}