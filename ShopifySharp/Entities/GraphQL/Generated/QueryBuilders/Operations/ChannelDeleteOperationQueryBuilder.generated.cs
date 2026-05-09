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
    public sealed class ChannelDeleteOperationQueryBuilder : FieldsQueryBuilderBase<ChannelDeletePayload, ChannelDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<ChannelDeletePayload>, IHasArguments<ChannelDeleteArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ChannelDeleteArgumentsBuilder Arguments { get; }
        protected override ChannelDeleteOperationQueryBuilder Self => this;

        public ChannelDeleteOperationQueryBuilder() : this("channelDelete")
        {
        }

        public ChannelDeleteOperationQueryBuilder(string name) : base(new Query<ChannelDeletePayload>(name))
        {
            Arguments = new ChannelDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ChannelDeleteOperationQueryBuilder(IQuery<ChannelDeletePayload> query) : base(query)
        {
            Arguments = new ChannelDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ChannelDeleteOperationQueryBuilder SetArguments(Action<ChannelDeleteArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ChannelDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public ChannelDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<ChannelDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelDeleteUserError>(query);
            return this;
        }
    }
}