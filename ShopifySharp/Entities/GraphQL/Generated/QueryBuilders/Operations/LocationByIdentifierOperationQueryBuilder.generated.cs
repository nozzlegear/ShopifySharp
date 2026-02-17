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
    public sealed class LocationByIdentifierOperationQueryBuilder : FieldsQueryBuilderBase<Location, LocationByIdentifierOperationQueryBuilder>, IGraphOperationQueryBuilder<Location>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public LocationByIdentifierArgumentsBuilder Arguments { get; }
        protected override LocationByIdentifierOperationQueryBuilder Self => this;

        public LocationByIdentifierOperationQueryBuilder() : this("locationByIdentifier")
        {
        }

        public LocationByIdentifierOperationQueryBuilder(string name) : base(new Query<Location>(name))
        {
            Arguments = new LocationByIdentifierArgumentsBuilder(base.InnerQuery);
        }

        public LocationByIdentifierOperationQueryBuilder(IQuery<Location> query) : base(query)
        {
            Arguments = new LocationByIdentifierArgumentsBuilder(base.InnerQuery);
        }

        public LocationByIdentifierOperationQueryBuilder Activatable()
        {
            base.InnerQuery.AddField("activatable");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder Address(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationAddressQueryBuilder> build)
        {
            var query = new Query<LocationAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationAddress>(query);
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder AddressVerified()
        {
            base.InnerQuery.AddField("addressVerified");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder Deactivatable()
        {
            base.InnerQuery.AddField("deactivatable");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder DeactivatedAt()
        {
            base.InnerQuery.AddField("deactivatedAt");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder Deletable()
        {
            base.InnerQuery.AddField("deletable");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder FulfillmentService(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("fulfillmentService");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder FulfillsOnlineOrders()
        {
            base.InnerQuery.AddField("fulfillsOnlineOrders");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder HasActiveInventory()
        {
            base.InnerQuery.AddField("hasActiveInventory");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder HasUnfulfilledOrders()
        {
            base.InnerQuery.AddField("hasUnfulfilledOrders");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder InventoryLevel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("inventoryLevel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder InventoryLevels(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryLevelConnection>("inventoryLevels");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevelConnection>(query);
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder IsActive()
        {
            base.InnerQuery.AddField("isActive");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder IsFulfillmentService()
        {
            base.InnerQuery.AddField("isFulfillmentService");
            return this;
        }

        [Obsolete("The concept of a primary location is deprecated, shipsInventory can be used to get a fallback location")]
        public LocationByIdentifierOperationQueryBuilder IsPrimary()
        {
            base.InnerQuery.AddField("isPrimary");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder LocalPickupSettingsV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocalPickupSettingsQueryBuilder> build)
        {
            var query = new Query<DeliveryLocalPickupSettings>("localPickupSettingsV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLocalPickupSettingsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLocalPickupSettings>(query);
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder ShipsInventory()
        {
            base.InnerQuery.AddField("shipsInventory");
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder SuggestedAddresses(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationSuggestedAddressQueryBuilder> build)
        {
            var query = new Query<LocationSuggestedAddress>("suggestedAddresses");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationSuggestedAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationSuggestedAddress>(query);
            return this;
        }

        public LocationByIdentifierOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}