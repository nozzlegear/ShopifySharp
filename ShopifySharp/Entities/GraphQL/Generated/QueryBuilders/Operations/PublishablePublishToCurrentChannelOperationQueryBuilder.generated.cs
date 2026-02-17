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
    public sealed class PublishablePublishToCurrentChannelOperationQueryBuilder : FieldsQueryBuilderBase<PublishablePublishToCurrentChannelPayload, PublishablePublishToCurrentChannelOperationQueryBuilder>, IGraphOperationQueryBuilder<PublishablePublishToCurrentChannelPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PublishablePublishToCurrentChannelArgumentsBuilder Arguments { get; }
        protected override PublishablePublishToCurrentChannelOperationQueryBuilder Self => this;

        public PublishablePublishToCurrentChannelOperationQueryBuilder() : this("publishablePublishToCurrentChannel")
        {
        }

        public PublishablePublishToCurrentChannelOperationQueryBuilder(string name) : base(new Query<PublishablePublishToCurrentChannelPayload>(name))
        {
            Arguments = new PublishablePublishToCurrentChannelArgumentsBuilder(base.InnerQuery);
        }

        public PublishablePublishToCurrentChannelOperationQueryBuilder(IQuery<PublishablePublishToCurrentChannelPayload> query) : base(query)
        {
            Arguments = new PublishablePublishToCurrentChannelArgumentsBuilder(base.InnerQuery);
        }

        public PublishablePublishToCurrentChannelOperationQueryBuilder Publishable(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublishableQueryBuilder> build)
        {
            var query = new Query<IPublishable>("publishable");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublishableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IPublishable>(query);
            return this;
        }

        public PublishablePublishToCurrentChannelOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public PublishablePublishToCurrentChannelOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}