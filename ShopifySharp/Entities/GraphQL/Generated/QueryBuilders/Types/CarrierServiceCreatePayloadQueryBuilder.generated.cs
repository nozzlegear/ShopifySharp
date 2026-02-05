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
    public sealed class CarrierServiceCreatePayloadQueryBuilder : FieldsQueryBuilderBase<CarrierServiceCreatePayload, CarrierServiceCreatePayloadQueryBuilder>
    {
        protected override CarrierServiceCreatePayloadQueryBuilder Self => this;

        public CarrierServiceCreatePayloadQueryBuilder() : this("carrierServiceCreatePayload")
        {
        }

        public CarrierServiceCreatePayloadQueryBuilder(string name) : base(new Query<CarrierServiceCreatePayload>(name))
        {
        }

        public CarrierServiceCreatePayloadQueryBuilder(IQuery<CarrierServiceCreatePayload> query) : base(query)
        {
        }

        public CarrierServiceCreatePayloadQueryBuilder CarrierService(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("carrierService");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }

        public CarrierServiceCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CarrierServiceCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<CarrierServiceCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CarrierServiceCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CarrierServiceCreateUserError>(query);
            return this;
        }
    }
}