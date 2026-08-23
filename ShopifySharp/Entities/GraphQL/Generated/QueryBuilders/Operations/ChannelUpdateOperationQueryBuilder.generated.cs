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
    public sealed class ChannelUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ChannelUpdatePayload, ChannelUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ChannelUpdatePayload>, IHasArguments<ChannelUpdateArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ChannelUpdateArgumentsBuilder Arguments { get; }
        protected override ChannelUpdateOperationQueryBuilder Self => this;

        public ChannelUpdateOperationQueryBuilder() : this("channelUpdate")
        {
        }

        public ChannelUpdateOperationQueryBuilder(string name) : base(new Query<ChannelUpdatePayload>(name))
        {
            Arguments = new ChannelUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ChannelUpdateOperationQueryBuilder(IQuery<ChannelUpdatePayload> query) : base(query)
        {
            Arguments = new ChannelUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ChannelUpdateOperationQueryBuilder SetArguments(Action<ChannelUpdateArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ChannelUpdateOperationQueryBuilder Channel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("channel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }

        public ChannelUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<ChannelUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelUpdateUserError>(query);
            return this;
        }
    }
}