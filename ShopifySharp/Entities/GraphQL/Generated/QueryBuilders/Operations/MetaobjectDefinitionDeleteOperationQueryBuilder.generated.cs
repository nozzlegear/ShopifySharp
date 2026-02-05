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
    public sealed class MetaobjectDefinitionDeleteOperationQueryBuilder : FieldsQueryBuilderBase<MetaobjectDefinitionDeletePayload, MetaobjectDefinitionDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<MetaobjectDefinitionDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetaobjectDefinitionDeleteArgumentsBuilder Arguments { get; }
        protected override MetaobjectDefinitionDeleteOperationQueryBuilder Self => this;

        public MetaobjectDefinitionDeleteOperationQueryBuilder() : this("metaobjectDefinitionDelete")
        {
        }

        public MetaobjectDefinitionDeleteOperationQueryBuilder(string name) : base(new Query<MetaobjectDefinitionDeletePayload>(name))
        {
            Arguments = new MetaobjectDefinitionDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectDefinitionDeleteOperationQueryBuilder(IQuery<MetaobjectDefinitionDeletePayload> query) : base(query)
        {
            Arguments = new MetaobjectDefinitionDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectDefinitionDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public MetaobjectDefinitionDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}