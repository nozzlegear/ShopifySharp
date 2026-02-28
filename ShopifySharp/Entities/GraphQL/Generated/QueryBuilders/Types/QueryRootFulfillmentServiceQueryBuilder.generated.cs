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
    public sealed class QueryRootFulfillmentServiceQueryBuilder : FieldsQueryBuilderBase<FulfillmentService, QueryRootFulfillmentServiceQueryBuilder>, IHasArguments<QueryRootFulfillmentServiceArgumentsBuilder>
    {
        public QueryRootFulfillmentServiceArgumentsBuilder Arguments { get; }
        protected override QueryRootFulfillmentServiceQueryBuilder Self => this;

        public QueryRootFulfillmentServiceQueryBuilder(string name) : base(new Query<FulfillmentService>(name))
        {
            Arguments = new QueryRootFulfillmentServiceArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootFulfillmentServiceQueryBuilder(IQuery<FulfillmentService> query) : base(query)
        {
            Arguments = new QueryRootFulfillmentServiceArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootFulfillmentServiceQueryBuilder SetArguments(Action<QueryRootFulfillmentServiceArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootFulfillmentServiceQueryBuilder CallbackUrl()
        {
            base.InnerQuery.AddField("callbackUrl");
            return this;
        }

        [Obsolete("Migration period ended. All correctly functioning fulfillment services have `fulfillmentOrdersOptIn` set to `true`.")]
        public QueryRootFulfillmentServiceQueryBuilder FulfillmentOrdersOptIn()
        {
            base.InnerQuery.AddField("fulfillmentOrdersOptIn");
            return this;
        }

        public QueryRootFulfillmentServiceQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public QueryRootFulfillmentServiceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootFulfillmentServiceQueryBuilder InventoryManagement()
        {
            base.InnerQuery.AddField("inventoryManagement");
            return this;
        }

        public QueryRootFulfillmentServiceQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        [Obsolete("Fulfillment services are all migrating to permit SKU sharing. Setting permits SKU sharing to false [is no longer supported](https://shopify.dev/changelog/setting-permitsskusharing-argument-to-false-when-creating-a-fulfillment-service-returns-an-error). As of API version `2026-04` this field will be removed. ")]
        public QueryRootFulfillmentServiceQueryBuilder PermitsSkuSharing()
        {
            base.InnerQuery.AddField("permitsSkuSharing");
            return this;
        }

        public QueryRootFulfillmentServiceQueryBuilder RequiresShippingMethod()
        {
            base.InnerQuery.AddField("requiresShippingMethod");
            return this;
        }

        public QueryRootFulfillmentServiceQueryBuilder ServiceName()
        {
            base.InnerQuery.AddField("serviceName");
            return this;
        }

        public QueryRootFulfillmentServiceQueryBuilder TrackingSupport()
        {
            base.InnerQuery.AddField("trackingSupport");
            return this;
        }

        public QueryRootFulfillmentServiceQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}