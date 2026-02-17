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

        public DeliverySettingQueryBuilder LegacyModeBlocked(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLegacyModeBlockedQueryBuilder> build)
        {
            var query = new Query<DeliveryLegacyModeBlocked>("legacyModeBlocked");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryLegacyModeBlockedQueryBuilder(query);
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