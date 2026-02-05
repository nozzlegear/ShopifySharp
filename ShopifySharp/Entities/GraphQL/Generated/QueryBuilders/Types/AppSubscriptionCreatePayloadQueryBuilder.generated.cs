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
    public sealed class AppSubscriptionCreatePayloadQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionCreatePayload, AppSubscriptionCreatePayloadQueryBuilder>
    {
        protected override AppSubscriptionCreatePayloadQueryBuilder Self => this;

        public AppSubscriptionCreatePayloadQueryBuilder() : this("appSubscriptionCreatePayload")
        {
        }

        public AppSubscriptionCreatePayloadQueryBuilder(string name) : base(new Query<AppSubscriptionCreatePayload>(name))
        {
        }

        public AppSubscriptionCreatePayloadQueryBuilder(IQuery<AppSubscriptionCreatePayload> query) : base(query)
        {
        }

        public AppSubscriptionCreatePayloadQueryBuilder AppSubscription(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("appSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscription>(query);
            return this;
        }

        public AppSubscriptionCreatePayloadQueryBuilder ConfirmationUrl()
        {
            base.InnerQuery.AddField("confirmationUrl");
            return this;
        }

        public AppSubscriptionCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}