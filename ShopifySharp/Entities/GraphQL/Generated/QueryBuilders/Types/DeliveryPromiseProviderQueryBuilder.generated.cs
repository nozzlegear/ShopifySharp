#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class DeliveryPromiseProviderQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseProvider, DeliveryPromiseProviderQueryBuilder>
    {
        protected override DeliveryPromiseProviderQueryBuilder Self => this;

        public DeliveryPromiseProviderQueryBuilder() : this("deliveryPromiseProvider")
        {
        }

        public DeliveryPromiseProviderQueryBuilder(string name) : base(new Query<DeliveryPromiseProvider>(name))
        {
        }

        public DeliveryPromiseProviderQueryBuilder(IQuery<DeliveryPromiseProvider> query) : base(query)
        {
        }

        public DeliveryPromiseProviderQueryBuilder Active()
        {
            base.InnerQuery.AddField("active");
            return this;
        }

        public DeliveryPromiseProviderQueryBuilder FulfillmentDelay()
        {
            base.InnerQuery.AddField("fulfillmentDelay");
            return this;
        }

        public DeliveryPromiseProviderQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryPromiseProviderQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public DeliveryPromiseProviderQueryBuilder TimeZone()
        {
            base.InnerQuery.AddField("timeZone");
            return this;
        }
    }
}