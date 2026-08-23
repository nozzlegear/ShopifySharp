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
    public sealed class CollectionConditionsSourceUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CollectionConditionsSourceUpdatePayload, CollectionConditionsSourceUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionConditionsSourceUpdatePayload>, IHasArguments<CollectionConditionsSourceUpdateArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CollectionConditionsSourceUpdateArgumentsBuilder Arguments { get; }
        protected override CollectionConditionsSourceUpdateOperationQueryBuilder Self => this;

        public CollectionConditionsSourceUpdateOperationQueryBuilder() : this("collectionConditionsSourceUpdate")
        {
        }

        public CollectionConditionsSourceUpdateOperationQueryBuilder(string name) : base(new Query<CollectionConditionsSourceUpdatePayload>(name))
        {
            Arguments = new CollectionConditionsSourceUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourceUpdateOperationQueryBuilder(IQuery<CollectionConditionsSourceUpdatePayload> query) : base(query)
        {
            Arguments = new CollectionConditionsSourceUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourceUpdateOperationQueryBuilder SetArguments(Action<CollectionConditionsSourceUpdateArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionConditionsSourceUpdateOperationQueryBuilder Source(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSource>("source");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSource>(query);
            return this;
        }

        public CollectionConditionsSourceUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}