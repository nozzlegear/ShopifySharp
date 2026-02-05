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
    public sealed class DeliveryProfileUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<DeliveryProfileUpdatePayload, DeliveryProfileUpdatePayloadQueryBuilder>
    {
        protected override DeliveryProfileUpdatePayloadQueryBuilder Self => this;

        public DeliveryProfileUpdatePayloadQueryBuilder() : this("deliveryProfileUpdatePayload")
        {
        }

        public DeliveryProfileUpdatePayloadQueryBuilder(string name) : base(new Query<DeliveryProfileUpdatePayload>(name))
        {
        }

        public DeliveryProfileUpdatePayloadQueryBuilder(IQuery<DeliveryProfileUpdatePayload> query) : base(query)
        {
        }

        public DeliveryProfileUpdatePayloadQueryBuilder Profile(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder> build)
        {
            var query = new Query<DeliveryProfile>("profile");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfile>(query);
            return this;
        }

        public DeliveryProfileUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}