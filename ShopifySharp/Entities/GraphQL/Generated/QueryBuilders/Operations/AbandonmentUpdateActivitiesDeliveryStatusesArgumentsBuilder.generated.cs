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
    public sealed class AbandonmentUpdateActivitiesDeliveryStatusesArgumentsBuilder : ArgumentsBuilderBase<AbandonmentUpdateActivitiesDeliveryStatusesPayload, AbandonmentUpdateActivitiesDeliveryStatusesArgumentsBuilder>
    {
        protected override AbandonmentUpdateActivitiesDeliveryStatusesArgumentsBuilder Self => this;

        public AbandonmentUpdateActivitiesDeliveryStatusesArgumentsBuilder(IQuery<AbandonmentUpdateActivitiesDeliveryStatusesPayload> query) : base(query)
        {
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesArgumentsBuilder AbandonmentId(string? abandonmentId)
        {
            base.InnerQuery.AddArgument("abandonmentId", abandonmentId);
            return this;
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesArgumentsBuilder DeliveredAt(DateTimeOffset? deliveredAt)
        {
            base.InnerQuery.AddArgument("deliveredAt", deliveredAt);
            return this;
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesArgumentsBuilder DeliveryStatus(AbandonmentDeliveryState? deliveryStatus)
        {
            base.InnerQuery.AddArgument("deliveryStatus", deliveryStatus);
            return this;
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesArgumentsBuilder DeliveryStatusChangeReason(string? deliveryStatusChangeReason)
        {
            base.InnerQuery.AddArgument("deliveryStatusChangeReason", deliveryStatusChangeReason);
            return this;
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesArgumentsBuilder MarketingActivityId(string? marketingActivityId)
        {
            base.InnerQuery.AddArgument("marketingActivityId", marketingActivityId);
            return this;
        }
    }
}