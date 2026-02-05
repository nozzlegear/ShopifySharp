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
    public sealed class FulfillmentServiceQueryBuilder : FieldsQueryBuilderBase<FulfillmentService, FulfillmentServiceQueryBuilder>
    {
        protected override FulfillmentServiceQueryBuilder Self => this;

        public FulfillmentServiceQueryBuilder() : this("fulfillmentService")
        {
        }

        public FulfillmentServiceQueryBuilder(string name) : base(new Query<FulfillmentService>(name))
        {
        }

        public FulfillmentServiceQueryBuilder(IQuery<FulfillmentService> query) : base(query)
        {
        }

        public FulfillmentServiceQueryBuilder CallbackUrl()
        {
            base.InnerQuery.AddField("callbackUrl");
            return this;
        }

        [Obsolete("Migration period ended. All correctly functioning fulfillment services have `fulfillmentOrdersOptIn` set to `true`.")]
        public FulfillmentServiceQueryBuilder FulfillmentOrdersOptIn()
        {
            base.InnerQuery.AddField("fulfillmentOrdersOptIn");
            return this;
        }

        public FulfillmentServiceQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public FulfillmentServiceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FulfillmentServiceQueryBuilder InventoryManagement()
        {
            base.InnerQuery.AddField("inventoryManagement");
            return this;
        }

        public FulfillmentServiceQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        [Obsolete("Fulfillment services are all migrating to permit SKU sharing. Setting permits SKU sharing to false [is no longer supported](https://shopify.dev/changelog/setting-permitsskusharing-argument-to-false-when-creating-a-fulfillment-service-returns-an-error). As of API version `2026-04` this field will be removed. ")]
        public FulfillmentServiceQueryBuilder PermitsSkuSharing()
        {
            base.InnerQuery.AddField("permitsSkuSharing");
            return this;
        }

        public FulfillmentServiceQueryBuilder RequiresShippingMethod()
        {
            base.InnerQuery.AddField("requiresShippingMethod");
            return this;
        }

        public FulfillmentServiceQueryBuilder ServiceName()
        {
            base.InnerQuery.AddField("serviceName");
            return this;
        }

        public FulfillmentServiceQueryBuilder TrackingSupport()
        {
            base.InnerQuery.AddField("trackingSupport");
            return this;
        }

        public FulfillmentServiceQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}