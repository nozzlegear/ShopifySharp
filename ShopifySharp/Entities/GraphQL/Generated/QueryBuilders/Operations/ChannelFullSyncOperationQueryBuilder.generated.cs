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
    public sealed class ChannelFullSyncOperationQueryBuilder : FieldsQueryBuilderBase<ChannelFullSyncPayload, ChannelFullSyncOperationQueryBuilder>, IGraphOperationQueryBuilder<ChannelFullSyncPayload>, IHasArguments<ChannelFullSyncArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ChannelFullSyncArgumentsBuilder Arguments { get; }
        protected override ChannelFullSyncOperationQueryBuilder Self => this;

        public ChannelFullSyncOperationQueryBuilder() : this("channelFullSync")
        {
        }

        public ChannelFullSyncOperationQueryBuilder(string name) : base(new Query<ChannelFullSyncPayload>(name))
        {
            Arguments = new ChannelFullSyncArgumentsBuilder(base.InnerQuery);
        }

        public ChannelFullSyncOperationQueryBuilder(IQuery<ChannelFullSyncPayload> query) : base(query)
        {
            Arguments = new ChannelFullSyncArgumentsBuilder(base.InnerQuery);
        }

        public ChannelFullSyncOperationQueryBuilder SetArguments(Action<ChannelFullSyncArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ChannelFullSyncOperationQueryBuilder FullSyncTraceInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FullSyncTraceInfoQueryBuilder> build)
        {
            var query = new Query<FullSyncTraceInfo>("fullSyncTraceInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FullSyncTraceInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FullSyncTraceInfo>(query);
            return this;
        }

        public ChannelFullSyncOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelFullSyncUserErrorQueryBuilder> build)
        {
            var query = new Query<ChannelFullSyncUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelFullSyncUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelFullSyncUserError>(query);
            return this;
        }
    }
}