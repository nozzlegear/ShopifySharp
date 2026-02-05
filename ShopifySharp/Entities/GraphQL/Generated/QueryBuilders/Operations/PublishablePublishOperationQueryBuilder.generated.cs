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
    public sealed class PublishablePublishOperationQueryBuilder : FieldsQueryBuilderBase<PublishablePublishPayload, PublishablePublishOperationQueryBuilder>, IGraphOperationQueryBuilder<PublishablePublishPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PublishablePublishArgumentsBuilder Arguments { get; }
        protected override PublishablePublishOperationQueryBuilder Self => this;

        public PublishablePublishOperationQueryBuilder() : this("publishablePublish")
        {
        }

        public PublishablePublishOperationQueryBuilder(string name) : base(new Query<PublishablePublishPayload>(name))
        {
            Arguments = new PublishablePublishArgumentsBuilder(base.InnerQuery);
        }

        public PublishablePublishOperationQueryBuilder(IQuery<PublishablePublishPayload> query) : base(query)
        {
            Arguments = new PublishablePublishArgumentsBuilder(base.InnerQuery);
        }

        public PublishablePublishOperationQueryBuilder Publishable(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublishableQueryBuilder> build)
        {
            var query = new Query<IPublishable>("publishable");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublishableQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IPublishable>(query);
            return this;
        }

        public PublishablePublishOperationQueryBuilder Shop(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder> build)
        {
            var query = new Query<Shop>("shop");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Shop>(query);
            return this;
        }

        public PublishablePublishOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}