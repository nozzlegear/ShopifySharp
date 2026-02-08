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
    public sealed class AppSubscriptionTrialExtendPayloadQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionTrialExtendPayload, AppSubscriptionTrialExtendPayloadQueryBuilder>
    {
        protected override AppSubscriptionTrialExtendPayloadQueryBuilder Self => this;

        public AppSubscriptionTrialExtendPayloadQueryBuilder() : this("appSubscriptionTrialExtendPayload")
        {
        }

        public AppSubscriptionTrialExtendPayloadQueryBuilder(string name) : base(new Query<AppSubscriptionTrialExtendPayload>(name))
        {
        }

        public AppSubscriptionTrialExtendPayloadQueryBuilder(IQuery<AppSubscriptionTrialExtendPayload> query) : base(query)
        {
        }

        public AppSubscriptionTrialExtendPayloadQueryBuilder AppSubscription(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("appSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscription>(query);
            return this;
        }

        public AppSubscriptionTrialExtendPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionTrialExtendUserErrorQueryBuilder> build)
        {
            var query = new Query<AppSubscriptionTrialExtendUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionTrialExtendUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscriptionTrialExtendUserError>(query);
            return this;
        }
    }
}