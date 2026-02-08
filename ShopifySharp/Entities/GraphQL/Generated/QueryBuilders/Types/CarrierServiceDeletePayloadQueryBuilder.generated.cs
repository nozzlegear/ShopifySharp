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
    public sealed class CarrierServiceDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CarrierServiceDeletePayload, CarrierServiceDeletePayloadQueryBuilder>
    {
        protected override CarrierServiceDeletePayloadQueryBuilder Self => this;

        public CarrierServiceDeletePayloadQueryBuilder() : this("carrierServiceDeletePayload")
        {
        }

        public CarrierServiceDeletePayloadQueryBuilder(string name) : base(new Query<CarrierServiceDeletePayload>(name))
        {
        }

        public CarrierServiceDeletePayloadQueryBuilder(IQuery<CarrierServiceDeletePayload> query) : base(query)
        {
        }

        public CarrierServiceDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public CarrierServiceDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CarrierServiceDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<CarrierServiceDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CarrierServiceDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CarrierServiceDeleteUserError>(query);
            return this;
        }
    }
}