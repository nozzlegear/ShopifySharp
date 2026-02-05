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

        public AppSubscriptionCancelOperationQueryBuilder AppSubscription(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("appSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscription>(query);
            return this;
        }

        public AppSubscriptionCancelOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}