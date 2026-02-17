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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class FulfillmentServiceOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentService, FulfillmentServiceOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentService>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public FulfillmentServiceArgumentsBuilder Arguments { get; }
        protected override FulfillmentServiceOperationQueryBuilder Self => this;

        public FulfillmentServiceOperationQueryBuilder() : this("fulfillmentService")
        {
        }

        public FulfillmentServiceOperationQueryBuilder(string name) : base(new Query<FulfillmentService>(name))
        {
            Arguments = new FulfillmentServiceArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentServiceOperationQueryBuilder(IQuery<FulfillmentService> query) : base(query)
        {
            Arguments = new FulfillmentServiceArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentServiceOperationQueryBuilder CallbackUrl()
        {
            base.InnerQuery.AddField("callbackUrl");
            return this;
        }

        [Obsolete("Migration period ended. All correctly functioning fulfillment services have `fulfillmentOrdersOptIn` set to `true`.")]
        public FulfillmentServiceOperationQueryBuilder FulfillmentOrdersOptIn()
        {
            base.InnerQuery.AddField("fulfillmentOrdersOptIn");
            return this;
        }

        public FulfillmentServiceOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public FulfillmentServiceOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FulfillmentServiceOperationQueryBuilder InventoryManagement()
        {
            base.InnerQuery.AddField("inventoryManagement");
            return this;
        }

        public FulfillmentServiceOperationQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        [Obsolete("Fulfillment services are all migrating to permit SKU sharing. Setting permits SKU sharing to false [is no longer supported](https://shopify.dev/changelog/setting-permitsskusharing-argument-to-false-when-creating-a-fulfillment-service-returns-an-error). As of API version `2026-04` this field will be removed. ")]
        public FulfillmentServiceOperationQueryBuilder PermitsSkuSharing()
        {
            base.InnerQuery.AddField("permitsSkuSharing");
            return this;
        }

        public FulfillmentServiceOperationQueryBuilder RequiresShippingMethod()
        {
            base.InnerQuery.AddField("requiresShippingMethod");
            return this;
        }

        public FulfillmentServiceOperationQueryBuilder ServiceName()
        {
            base.InnerQuery.AddField("serviceName");
            return this;
        }

        public FulfillmentServiceOperationQueryBuilder TrackingSupport()
        {
            base.InnerQuery.AddField("trackingSupport");
            return this;
        }

        public FulfillmentServiceOperationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}