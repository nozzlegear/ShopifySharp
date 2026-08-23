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
    public sealed class ChannelCreateOperationQueryBuilder : FieldsQueryBuilderBase<ChannelCreatePayload, ChannelCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<ChannelCreatePayload>, IHasArguments<ChannelCreateArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ChannelCreateArgumentsBuilder Arguments { get; }
        protected override ChannelCreateOperationQueryBuilder Self => this;

        public ChannelCreateOperationQueryBuilder() : this("channelCreate")
        {
        }

        public ChannelCreateOperationQueryBuilder(string name) : base(new Query<ChannelCreatePayload>(name))
        {
            Arguments = new ChannelCreateArgumentsBuilder(base.InnerQuery);
        }

        public ChannelCreateOperationQueryBuilder(IQuery<ChannelCreatePayload> query) : base(query)
        {
            Arguments = new ChannelCreateArgumentsBuilder(base.InnerQuery);
        }

        public ChannelCreateOperationQueryBuilder SetArguments(Action<ChannelCreateArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ChannelCreateOperationQueryBuilder Channel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder> build)
        {
            var query = new Query<Channel>("channel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Channel>(query);
            return this;
        }

        public ChannelCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<ChannelCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelCreateUserError>(query);
            return this;
        }
    }
}