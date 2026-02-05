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
    public sealed class DeliveryShippingOriginAssignPayloadQueryBuilder : FieldsQueryBuilderBase<DeliveryShippingOriginAssignPayload, DeliveryShippingOriginAssignPayloadQueryBuilder>
    {
        protected override DeliveryShippingOriginAssignPayloadQueryBuilder Self => this;

        public DeliveryShippingOriginAssignPayloadQueryBuilder() : this("deliveryShippingOriginAssignPayload")
        {
        }

        public DeliveryShippingOriginAssignPayloadQueryBuilder(string name) : base(new Query<DeliveryShippingOriginAssignPayload>(name))
        {
        }

        public DeliveryShippingOriginAssignPayloadQueryBuilder(IQuery<DeliveryShippingOriginAssignPayload> query) : base(query)
        {
        }

        public DeliveryShippingOriginAssignPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}