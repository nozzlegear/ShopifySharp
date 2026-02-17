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
    public sealed class AppSubscriptionTrialExtendOperationQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionTrialExtendPayload, AppSubscriptionTrialExtendOperationQueryBuilder>, IGraphOperationQueryBuilder<AppSubscriptionTrialExtendPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public AppSubscriptionTrialExtendArgumentsBuilder Arguments { get; }
        protected override AppSubscriptionTrialExtendOperationQueryBuilder Self => this;

        public AppSubscriptionTrialExtendOperationQueryBuilder() : this("appSubscriptionTrialExtend")
        {
        }

        public AppSubscriptionTrialExtendOperationQueryBuilder(string name) : base(new Query<AppSubscriptionTrialExtendPayload>(name))
        {
            Arguments = new AppSubscriptionTrialExtendArgumentsBuilder(base.InnerQuery);
        }

        public AppSubscriptionTrialExtendOperationQueryBuilder(IQuery<AppSubscriptionTrialExtendPayload> query) : base(query)
        {
            Arguments = new AppSubscriptionTrialExtendArgumentsBuilder(base.InnerQuery);
        }

        public AppSubscriptionTrialExtendOperationQueryBuilder AppSubscription(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("appSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscription>(query);
            return this;
        }

        public AppSubscriptionTrialExtendOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionTrialExtendUserErrorQueryBuilder> build)
        {
            var query = new Query<AppSubscriptionTrialExtendUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionTrialExtendUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscriptionTrialExtendUserError>(query);
            return this;
        }
    }
}