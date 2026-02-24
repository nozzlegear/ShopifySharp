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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class DeliveryPromiseParticipantOwnerMediaQueryBuilder : FieldsQueryBuilderBase<MediaConnection, DeliveryPromiseParticipantOwnerMediaQueryBuilder>, IHasArguments<DeliveryPromiseParticipantOwnerMediaArgumentsBuilder>
    {
        public DeliveryPromiseParticipantOwnerMediaArgumentsBuilder Arguments { get; }
        protected override DeliveryPromiseParticipantOwnerMediaQueryBuilder Self => this;

        public DeliveryPromiseParticipantOwnerMediaQueryBuilder(string name) : base(new Query<MediaConnection>(name))
        {
            Arguments = new DeliveryPromiseParticipantOwnerMediaArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantOwnerMediaQueryBuilder(IQuery<MediaConnection> query) : base(query)
        {
            Arguments = new DeliveryPromiseParticipantOwnerMediaArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantOwnerMediaQueryBuilder SetArguments(Action<DeliveryPromiseParticipantOwnerMediaArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryPromiseParticipantOwnerMediaQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaEdgeQueryBuilder> build)
        {
            var query = new Query<MediaEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaEdge>(query);
            return this;
        }

        public DeliveryPromiseParticipantOwnerMediaQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaQueryBuilder> build)
        {
            var query = new Query<IMedia>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMedia>(query);
            return this;
        }

        public DeliveryPromiseParticipantOwnerMediaQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}