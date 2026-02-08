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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class DeliveryPromiseProviderUpsertPayloadQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseProviderUpsertPayload, DeliveryPromiseProviderUpsertPayloadQueryBuilder>
    {
        protected override DeliveryPromiseProviderUpsertPayloadQueryBuilder Self => this;

        public DeliveryPromiseProviderUpsertPayloadQueryBuilder() : this("deliveryPromiseProviderUpsertPayload")
        {
        }

        public DeliveryPromiseProviderUpsertPayloadQueryBuilder(string name) : base(new Query<DeliveryPromiseProviderUpsertPayload>(name))
        {
        }

        public DeliveryPromiseProviderUpsertPayloadQueryBuilder(IQuery<DeliveryPromiseProviderUpsertPayload> query) : base(query)
        {
        }

        public DeliveryPromiseProviderUpsertPayloadQueryBuilder DeliveryPromiseProvider(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseProviderQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseProvider>("deliveryPromiseProvider");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseProviderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseProvider>(query);
            return this;
        }

        public DeliveryPromiseProviderUpsertPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseProviderUpsertUserErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryPromiseProviderUpsertUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryPromiseProviderUpsertUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryPromiseProviderUpsertUserError>(query);
            return this;
        }
    }
}