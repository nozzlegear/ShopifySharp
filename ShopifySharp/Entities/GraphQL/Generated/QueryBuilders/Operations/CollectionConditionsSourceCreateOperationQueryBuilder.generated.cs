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
    public sealed class CollectionConditionsSourceCreateOperationQueryBuilder : FieldsQueryBuilderBase<CollectionConditionsSourceCreatePayload, CollectionConditionsSourceCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionConditionsSourceCreatePayload>, IHasArguments<CollectionConditionsSourceCreateArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CollectionConditionsSourceCreateArgumentsBuilder Arguments { get; }
        protected override CollectionConditionsSourceCreateOperationQueryBuilder Self => this;

        public CollectionConditionsSourceCreateOperationQueryBuilder() : this("collectionConditionsSourceCreate")
        {
        }

        public CollectionConditionsSourceCreateOperationQueryBuilder(string name) : base(new Query<CollectionConditionsSourceCreatePayload>(name))
        {
            Arguments = new CollectionConditionsSourceCreateArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourceCreateOperationQueryBuilder(IQuery<CollectionConditionsSourceCreatePayload> query) : base(query)
        {
            Arguments = new CollectionConditionsSourceCreateArgumentsBuilder(base.InnerQuery);
        }

        public CollectionConditionsSourceCreateOperationQueryBuilder SetArguments(Action<CollectionConditionsSourceCreateArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionConditionsSourceCreateOperationQueryBuilder Source(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSource>("source");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConditionsSource>(query);
            return this;
        }

        public CollectionConditionsSourceCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}