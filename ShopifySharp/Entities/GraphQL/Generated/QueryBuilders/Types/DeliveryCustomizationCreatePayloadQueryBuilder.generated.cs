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
    public sealed class DeliveryCustomizationCreatePayloadQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomizationCreatePayload, DeliveryCustomizationCreatePayloadQueryBuilder>
    {
        protected override DeliveryCustomizationCreatePayloadQueryBuilder Self => this;

        public DeliveryCustomizationCreatePayloadQueryBuilder() : this("deliveryCustomizationCreatePayload")
        {
        }

        public DeliveryCustomizationCreatePayloadQueryBuilder(string name) : base(new Query<DeliveryCustomizationCreatePayload>(name))
        {
        }

        public DeliveryCustomizationCreatePayloadQueryBuilder(IQuery<DeliveryCustomizationCreatePayload> query) : base(query)
        {
        }

        public DeliveryCustomizationCreatePayloadQueryBuilder DeliveryCustomization(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomization>("deliveryCustomization");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomization>(query);
            return this;
        }

        public DeliveryCustomizationCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomizationError>(query);
            return this;
        }
    }
}