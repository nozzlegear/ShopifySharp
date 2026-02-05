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
    public sealed class ReverseDeliveryShippingUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryShippingUpdatePayload, ReverseDeliveryShippingUpdatePayloadQueryBuilder>
    {
        protected override ReverseDeliveryShippingUpdatePayloadQueryBuilder Self => this;

        public ReverseDeliveryShippingUpdatePayloadQueryBuilder() : this("reverseDeliveryShippingUpdatePayload")
        {
        }

        public ReverseDeliveryShippingUpdatePayloadQueryBuilder(string name) : base(new Query<ReverseDeliveryShippingUpdatePayload>(name))
        {
        }

        public ReverseDeliveryShippingUpdatePayloadQueryBuilder(IQuery<ReverseDeliveryShippingUpdatePayload> query) : base(query)
        {
        }

        public ReverseDeliveryShippingUpdatePayloadQueryBuilder ReverseDelivery(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryQueryBuilder> build)
        {
            var query = new Query<ReverseDelivery>("reverseDelivery");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDelivery>(query);
            return this;
        }

        public ReverseDeliveryShippingUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}