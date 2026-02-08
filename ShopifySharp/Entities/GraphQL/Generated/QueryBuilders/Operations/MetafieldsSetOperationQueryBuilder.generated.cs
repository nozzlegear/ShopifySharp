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
    public sealed class MetafieldsSetOperationQueryBuilder : FieldsQueryBuilderBase<MetafieldsSetPayload, MetafieldsSetOperationQueryBuilder>, IGraphOperationQueryBuilder<MetafieldsSetPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetafieldsSetArgumentsBuilder Arguments { get; }
        protected override MetafieldsSetOperationQueryBuilder Self => this;

        public MetafieldsSetOperationQueryBuilder() : this("metafieldsSet")
        {
        }

        public MetafieldsSetOperationQueryBuilder(string name) : base(new Query<MetafieldsSetPayload>(name))
        {
            Arguments = new MetafieldsSetArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldsSetOperationQueryBuilder(IQuery<MetafieldsSetPayload> query) : base(query)
        {
            Arguments = new MetafieldsSetArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldsSetOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public MetafieldsSetOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldsSetUserErrorQueryBuilder> build)
        {
            var query = new Query<MetafieldsSetUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldsSetUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldsSetUserError>(query);
            return this;
        }
    }
}