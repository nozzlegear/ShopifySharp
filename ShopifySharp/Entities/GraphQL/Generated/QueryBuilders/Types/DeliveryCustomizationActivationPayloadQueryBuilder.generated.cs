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
    public sealed class DeliveryCustomizationActivationPayloadQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomizationActivationPayload, DeliveryCustomizationActivationPayloadQueryBuilder>
    {
        protected override DeliveryCustomizationActivationPayloadQueryBuilder Self => this;

        public DeliveryCustomizationActivationPayloadQueryBuilder() : this("deliveryCustomizationActivationPayload")
        {
        }

        public DeliveryCustomizationActivationPayloadQueryBuilder(string name) : base(new Query<DeliveryCustomizationActivationPayload>(name))
        {
        }

        public DeliveryCustomizationActivationPayloadQueryBuilder(IQuery<DeliveryCustomizationActivationPayload> query) : base(query)
        {
        }

        public DeliveryCustomizationActivationPayloadQueryBuilder Ids()
        {
            base.InnerQuery.AddField("ids");
            return this;
        }

        public DeliveryCustomizationActivationPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomizationError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCustomizationErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomizationError>(query);
            return this;
        }
    }
}