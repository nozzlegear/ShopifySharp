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
    public sealed class CollectionConditionsSourceDeleteOperationQueryBuilder : FieldsQueryBuilderBase<CollectionConditionsSourceDeletePayload, CollectionConditionsSourceDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionConditionsSourceDeletePayload>, IHasArguments<CollectionConditionsSourceDeleteArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CollectionConditionsSourceDeleteArgumentsBuilder Arguments { get; }
        protected override CollectionConditionsSourceDeleteOperationQueryBuilder Self => this;

        public CollectionConditionsSourceDeleteOperationQueryBuilder() : this("collectionConditionsSourceDelete")
        {
        }

        public CollectionConditionsSourceDeleteOperationQueryBuilder(string name) : base(new Query<CollectionConditionsSourceDeletePayload>(name))
        {
            Arguments = new CollectionConditionsSourceDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourceDeleteOperationQueryBuilder(IQuery<CollectionConditionsSourceDeletePayload> query) : base(query)
        {
            Arguments = new CollectionConditionsSourceDeleteArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourceDeleteOperationQueryBuilder SetArguments(Action<CollectionConditionsSourceDeleteArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionConditionsSourceDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public CollectionConditionsSourceDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}