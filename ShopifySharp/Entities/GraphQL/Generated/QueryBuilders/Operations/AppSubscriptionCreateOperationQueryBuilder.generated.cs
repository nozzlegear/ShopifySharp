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
    public sealed class AppSubscriptionCreateOperationQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionCreatePayload, AppSubscriptionCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<AppSubscriptionCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public AppSubscriptionCreateArgumentsBuilder Arguments { get; }
        protected override AppSubscriptionCreateOperationQueryBuilder Self => this;

        public AppSubscriptionCreateOperationQueryBuilder() : this("appSubscriptionCreate")
        {
        }

        public AppSubscriptionCreateOperationQueryBuilder(string name) : base(new Query<AppSubscriptionCreatePayload>(name))
        {
            Arguments = new AppSubscriptionCreateArgumentsBuilder(base.InnerQuery);
        }

        public AppSubscriptionCreateOperationQueryBuilder(IQuery<AppSubscriptionCreatePayload> query) : base(query)
        {
            Arguments = new AppSubscriptionCreateArgumentsBuilder(base.InnerQuery);
        }

        public AppSubscriptionCreateOperationQueryBuilder AppSubscription(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("appSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscription>(query);
            return this;
        }

        public AppSubscriptionCreateOperationQueryBuilder ConfirmationUrl()
        {
            base.InnerQuery.AddField("confirmationUrl");
            return this;
        }

        public AppSubscriptionCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}