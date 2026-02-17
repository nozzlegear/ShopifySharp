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
    public sealed class DeliveryPromiseProviderUpsertOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseProviderUpsertPayload, DeliveryPromiseProviderUpsertOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryPromiseProviderUpsertPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DeliveryPromiseProviderUpsertArgumentsBuilder Arguments { get; }
        protected override DeliveryPromiseProviderUpsertOperationQueryBuilder Self => this;

        public DeliveryPromiseProviderUpsertOperationQueryBuilder() : this("deliveryPromiseProviderUpsert")
        {
        }

        public DeliveryPromiseProviderUpsertOperationQueryBuilder(string name) : base(new Query<DeliveryPromiseProviderUpsertPayload>(name))
        {
            Arguments = new DeliveryPromiseProviderUpsertArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseProviderUpsertOperationQueryBuilder(IQuery<DeliveryPromiseProviderUpsertPayload> query) : base(query)
        {
            Arguments = new DeliveryPromiseProviderUpsertArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseProviderUpsertOperationQueryBuilder DeliveryPromiseProvider(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseProviderQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseProvider>("deliveryPromiseProvider");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseProviderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseProvider>(query);
            return this;
        }

        public DeliveryPromiseProviderUpsertOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseProviderUpsertUserErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseProviderUpsertUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryPromiseProviderUpsertUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseProviderUpsertUserError>(query);
            return this;
        }
    }
}