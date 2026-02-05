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
    public sealed class DeliveryCustomizationDeletePayloadQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomizationDeletePayload, DeliveryCustomizationDeletePayloadQueryBuilder>
    {
        protected override DeliveryCustomizationDeletePayloadQueryBuilder Self => this;

        public DeliveryCustomizationDeletePayloadQueryBuilder() : this("deliveryCustomizationDeletePayload")
        {
        }

        public DeliveryCustomizationDeletePayloadQueryBuilder(string name) : base(new Query<DeliveryCustomizationDeletePayload>(name))
        {
        }

        public DeliveryCustomizationDeletePayloadQueryBuilder(IQuery<DeliveryCustomizationDeletePayload> query) : base(query)
        {
        }

        public DeliveryCustomizationDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public DeliveryCustomizationDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomizationError>(query);
            return this;
        }
    }
}