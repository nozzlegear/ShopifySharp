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
    public sealed class AppSubscriptionCancelOperationQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionCancelPayload, AppSubscriptionCancelOperationQueryBuilder>, IGraphOperationQueryBuilder<AppSubscriptionCancelPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public AppSubscriptionCancelArgumentsBuilder Arguments { get; }
        protected override AppSubscriptionCancelOperationQueryBuilder Self => this;

        public AppSubscriptionCancelOperationQueryBuilder() : this("appSubscriptionCancel")
        {
        }

        public AppSubscriptionCancelOperationQueryBuilder(string name) : base(new Query<AppSubscriptionCancelPayload>(name))
        {
            Arguments = new AppSubscriptionCancelArgumentsBuilder(base.InnerQuery);
        }

        public AppSubscriptionCancelOperationQueryBuilder(IQuery<AppSubscriptionCancelPayload> query) : base(query)
        {
            Arguments = new AppSubscriptionCancelArgumentsBuilder(base.InnerQuery);
        }

        public AppSubscriptionCancelOperationQueryBuilder AppSubscription(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("appSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscription>(query);
            return this;
        }

        public AppSubscriptionCancelOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}