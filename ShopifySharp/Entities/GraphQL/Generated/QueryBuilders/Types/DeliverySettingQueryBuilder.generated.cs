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
    public sealed class DeliverySettingQueryBuilder : FieldsQueryBuilderBase<DeliverySetting, DeliverySettingQueryBuilder>
    {
        protected override DeliverySettingQueryBuilder Self => this;

        public DeliverySettingQueryBuilder() : this("deliverySetting")
        {
        }

        public DeliverySettingQueryBuilder(string name) : base(new Query<DeliverySetting>(name))
        {
        }

        public DeliverySettingQueryBuilder(IQuery<DeliverySetting> query) : base(query)
        {
        }

        public DeliverySettingQueryBuilder LegacyModeBlocked(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLegacyModeBlockedQueryBuilder> build)
        {
            var query = new Query<DeliveryLegacyModeBlocked>("legacyModeBlocked");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryLegacyModeBlockedQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryLegacyModeBlocked>(query);
            return this;
        }

        public DeliverySettingQueryBuilder LegacyModeProfiles()
        {
            base.InnerQuery.AddField("legacyModeProfiles");
            return this;
        }
    }
}