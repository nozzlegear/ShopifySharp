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
    public sealed class DeliveryCustomizationUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomizationUpdatePayload, DeliveryCustomizationUpdatePayloadQueryBuilder>
    {
        protected override DeliveryCustomizationUpdatePayloadQueryBuilder Self => this;

        public DeliveryCustomizationUpdatePayloadQueryBuilder() : this("deliveryCustomizationUpdatePayload")
        {
        }

        public DeliveryCustomizationUpdatePayloadQueryBuilder(string name) : base(new Query<DeliveryCustomizationUpdatePayload>(name))
        {
        }

        public DeliveryCustomizationUpdatePayloadQueryBuilder(IQuery<DeliveryCustomizationUpdatePayload> query) : base(query)
        {
        }

        public DeliveryCustomizationUpdatePayloadQueryBuilder DeliveryCustomization(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomization>("deliveryCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomization>(query);
            return this;
        }

        public DeliveryCustomizationUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomizationError>(query);
            return this;
        }
    }
}