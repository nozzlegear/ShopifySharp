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
    public sealed class CollectionCreateOperationQueryBuilder : FieldsQueryBuilderBase<CollectionCreatePayload, CollectionCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CollectionCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CollectionCreateArgumentsBuilder Arguments { get; }
        protected override CollectionCreateOperationQueryBuilder Self => this;

        public CollectionCreateOperationQueryBuilder() : this("collectionCreate")
        {
        }

        public CollectionCreateOperationQueryBuilder(string name) : base(new Query<CollectionCreatePayload>(name))
        {
            Arguments = new CollectionCreateArgumentsBuilder(base.InnerQuery);
        }

        public CollectionCreateOperationQueryBuilder(IQuery<CollectionCreatePayload> query) : base(query)
        {
            Arguments = new CollectionCreateArgumentsBuilder(base.InnerQuery);
        }

        public CollectionCreateOperationQueryBuilder Collection(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("collection");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public CollectionCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}