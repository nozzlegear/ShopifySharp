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
    public sealed class DeliveryProfileCreatePayloadQueryBuilder : FieldsQueryBuilderBase<DeliveryProfileCreatePayload, DeliveryProfileCreatePayloadQueryBuilder>
    {
        protected override DeliveryProfileCreatePayloadQueryBuilder Self => this;

        public DeliveryProfileCreatePayloadQueryBuilder() : this("deliveryProfileCreatePayload")
        {
        }

        public DeliveryProfileCreatePayloadQueryBuilder(string name) : base(new Query<DeliveryProfileCreatePayload>(name))
        {
        }

        public DeliveryProfileCreatePayloadQueryBuilder(IQuery<DeliveryProfileCreatePayload> query) : base(query)
        {
        }

        public DeliveryProfileCreatePayloadQueryBuilder Profile(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder> build)
        {
            var query = new Query<DeliveryProfile>("profile");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfile>(query);
            return this;
        }

        public DeliveryProfileCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}