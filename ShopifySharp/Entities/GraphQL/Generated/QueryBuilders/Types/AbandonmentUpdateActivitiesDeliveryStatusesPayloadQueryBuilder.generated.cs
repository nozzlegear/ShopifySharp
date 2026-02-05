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
    public sealed class AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder : FieldsQueryBuilderBase<AbandonmentUpdateActivitiesDeliveryStatusesPayload, AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder>
    {
        protected override AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder Self => this;

        public AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder() : this("abandonmentUpdateActivitiesDeliveryStatusesPayload")
        {
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder(string name) : base(new Query<AbandonmentUpdateActivitiesDeliveryStatusesPayload>(name))
        {
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder(IQuery<AbandonmentUpdateActivitiesDeliveryStatusesPayload> query) : base(query)
        {
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder Abandonment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentQueryBuilder> build)
        {
            var query = new Query<Abandonment>("abandonment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Abandonment>(query);
            return this;
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder> build)
        {
            var query = new Query<AbandonmentUpdateActivitiesDeliveryStatusesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonmentUpdateActivitiesDeliveryStatusesUserError>(query);
            return this;
        }
    }
}