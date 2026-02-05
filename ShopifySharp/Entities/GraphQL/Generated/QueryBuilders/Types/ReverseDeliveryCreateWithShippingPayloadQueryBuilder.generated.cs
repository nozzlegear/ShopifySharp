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
    public sealed class ReverseDeliveryCreateWithShippingPayloadQueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryCreateWithShippingPayload, ReverseDeliveryCreateWithShippingPayloadQueryBuilder>
    {
        protected override ReverseDeliveryCreateWithShippingPayloadQueryBuilder Self => this;

        public ReverseDeliveryCreateWithShippingPayloadQueryBuilder() : this("reverseDeliveryCreateWithShippingPayload")
        {
        }

        public ReverseDeliveryCreateWithShippingPayloadQueryBuilder(string name) : base(new Query<ReverseDeliveryCreateWithShippingPayload>(name))
        {
        }

        public ReverseDeliveryCreateWithShippingPayloadQueryBuilder(IQuery<ReverseDeliveryCreateWithShippingPayload> query) : base(query)
        {
        }

        public ReverseDeliveryCreateWithShippingPayloadQueryBuilder ReverseDelivery(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryQueryBuilder> build)
        {
            var query = new Query<ReverseDelivery>("reverseDelivery");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDelivery>(query);
            return this;
        }

        public ReverseDeliveryCreateWithShippingPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}