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
    public sealed class MetafieldsDeleteOperationQueryBuilder : FieldsQueryBuilderBase<MetafieldsDeletePayload, MetafieldsDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<MetafieldsDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetafieldsDeleteArgumentsBuilder Arguments { get; }
        protected override MetafieldsDeleteOperationQueryBuilder Self => this;

        public MetafieldsDeleteOperationQueryBuilder() : this("metafieldsDelete")
        {
        }

        public MetafieldsDeleteOperationQueryBuilder(string name) : base(new Query<MetafieldsDeletePayload>(name))
        {
            Arguments = new MetafieldsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldsDeleteOperationQueryBuilder(IQuery<MetafieldsDeletePayload> query) : base(query)
        {
            Arguments = new MetafieldsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldsDeleteOperationQueryBuilder DeletedMetafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldIdentifierQueryBuilder> build)
        {
            var query = new Query<MetafieldIdentifier>("deletedMetafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldIdentifierQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldIdentifier>(query);
            return this;
        }

        public MetafieldsDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}