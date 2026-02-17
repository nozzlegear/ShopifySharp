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
    public sealed class AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder : FieldsQueryBuilderBase<AbandonmentUpdateActivitiesDeliveryStatusesUserError, AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder>
    {
        protected override AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder Self => this;

        public AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder() : this("abandonmentUpdateActivitiesDeliveryStatusesUserError")
        {
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder(string name) : base(new Query<AbandonmentUpdateActivitiesDeliveryStatusesUserError>(name))
        {
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder(IQuery<AbandonmentUpdateActivitiesDeliveryStatusesUserError> query) : base(query)
        {
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}