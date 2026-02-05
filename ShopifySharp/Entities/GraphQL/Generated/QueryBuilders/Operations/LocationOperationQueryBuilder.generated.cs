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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class LocationOperationQueryBuilder : FieldsQueryBuilderBase<Location, LocationOperationQueryBuilder>, IGraphOperationQueryBuilder<Location>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public LocationArgumentsBuilder Arguments { get; }
        protected override LocationOperationQueryBuilder Self => this;

        public LocationOperationQueryBuilder() : this("location")
        {
        }

        public LocationOperationQueryBuilder(string name) : base(new Query<Location>(name))
        {
            Arguments = new LocationArgumentsBuilder(base.InnerQuery);
        }

        public LocationOperationQueryBuilder(IQuery<Location> query) : base(query)
        {
            Arguments = new LocationArgumentsBuilder(base.InnerQuery);
        }

        public LocationOperationQueryBuilder Activatable()
        {
            base.InnerQuery.AddField("activatable");
            return this;
        }

        public LocationOperationQueryBuilder Address(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationAddressQueryBuilder> build)
        {
            var query = new Query<LocationAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationAddress>(query);
            return this;
        }

        public LocationOperationQueryBuilder AddressVerified()
        {
            base.InnerQuery.AddField("addressVerified");
            return this;
        }

        public LocationOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public LocationOperationQueryBuilder Deactivatable()
        {
            base.InnerQuery.AddField("deactivatable");
            return this;
        }

        public LocationOperationQueryBuilder DeactivatedAt()
        {
            base.InnerQuery.AddField("deactivatedAt");
            return this;
        }

        public LocationOperationQueryBuilder Deletable()
        {
            base.InnerQuery.AddField("deletable");
            return this;
        }

        public LocationOperationQueryBuilder FulfillmentService(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("fulfillmentService");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        public LocationOperationQueryBuilder FulfillsOnlineOrders()
        {
            base.InnerQuery.AddField("fulfillsOnlineOrders");
            return this;
        }

        public LocationOperationQueryBuilder HasActiveInventory()
        {
            base.InnerQuery.AddField("hasActiveInventory");
            return this;
        }

        public LocationOperationQueryBuilder HasUnfulfilledOrders()
        {
            base.InnerQuery.AddField("hasUnfulfilledOrders");
            return this;
        }

        public LocationOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public LocationOperationQueryBuilder InventoryLevel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("inventoryLevel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public LocationOperationQueryBuilder InventoryLevels(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryLevelConnection>("inventoryLevels");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevelConnection>(query);
            return this;
        }

        public LocationOperationQueryBuilder IsActive()
        {
            base.InnerQuery.AddField("isActive");
            return this;
        }

        public LocationOperationQueryBuilder IsFulfillmentService()
        {
            base.InnerQuery.AddField("isFulfillmentService");
            return this;
        }

        [Obsolete("The concept of a primary location is deprecated, shipsInventory can be used to get a fallback location")]
        public LocationOperationQueryBuilder IsPrimary()
        {
            base.InnerQuery.AddField("isPrimary");
            return this;
        }

        public LocationOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public LocationOperationQueryBuilder LocalPickupSettingsV2(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocalPickupSettingsQueryBuilder> build)
        {
            var query = new Query<DeliveryLocalPickupSettings>("localPickupSettingsV2");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLocalPickupSettingsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocalPickupSettings>(query);
            return this;
        }

        public LocationOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public LocationOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public LocationOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public LocationOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public LocationOperationQueryBuilder ShipsInventory()
        {
            base.InnerQuery.AddField("shipsInventory");
            return this;
        }

        public LocationOperationQueryBuilder SuggestedAddresses(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationSuggestedAddressQueryBuilder> build)
        {
            var query = new Query<LocationSuggestedAddress>("suggestedAddresses");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationSuggestedAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationSuggestedAddress>(query);
            return this;
        }

        public LocationOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}