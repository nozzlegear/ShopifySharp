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
    public sealed class MetaobjectUpsertOperationQueryBuilder : FieldsQueryBuilderBase<MetaobjectUpsertPayload, MetaobjectUpsertOperationQueryBuilder>, IGraphOperationQueryBuilder<MetaobjectUpsertPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetaobjectUpsertArgumentsBuilder Arguments { get; }
        protected override MetaobjectUpsertOperationQueryBuilder Self => this;

        public MetaobjectUpsertOperationQueryBuilder() : this("metaobjectUpsert")
        {
        }

        public MetaobjectUpsertOperationQueryBuilder(string name) : base(new Query<MetaobjectUpsertPayload>(name))
        {
            Arguments = new MetaobjectUpsertArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectUpsertOperationQueryBuilder(IQuery<MetaobjectUpsertPayload> query) : base(query)
        {
            Arguments = new MetaobjectUpsertArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectUpsertOperationQueryBuilder Metaobject(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("metaobject");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metaobject>(query);
            return this;
        }

        public MetaobjectUpsertOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}