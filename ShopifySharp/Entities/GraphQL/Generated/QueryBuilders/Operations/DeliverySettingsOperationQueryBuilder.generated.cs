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
    public sealed class DeliverySettingsOperationQueryBuilder : FieldsQueryBuilderBase<DeliverySetting, DeliverySettingsOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliverySetting>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override DeliverySettingsOperationQueryBuilder Self => this;

        public DeliverySettingsOperationQueryBuilder() : this("deliverySettings")
        {
        }

        public DeliverySettingsOperationQueryBuilder(string name) : base(new Query<DeliverySetting>(name))
        {
        }

        public DeliverySettingsOperationQueryBuilder(IQuery<DeliverySetting> query) : base(query)
        {
        }

        public DeliverySettingsOperationQueryBuilder LegacyModeBlocked(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLegacyModeBlockedQueryBuilder> build)
        {
            var query = new Query<DeliveryLegacyModeBlocked>("legacyModeBlocked");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLegacyModeBlockedQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLegacyModeBlocked>(query);
            return this;
        }

        public DeliverySettingsOperationQueryBuilder LegacyModeProfiles()
        {
            base.InnerQuery.AddField("legacyModeProfiles");
            return this;
        }
    }
}