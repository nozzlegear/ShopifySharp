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
    public sealed class DeliveryPromiseParticipantOwnerMetafieldDefinitionsQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionConnection, DeliveryPromiseParticipantOwnerMetafieldDefinitionsQueryBuilder>, IHasArguments<DeliveryPromiseParticipantOwnerMetafieldDefinitionsArgumentsBuilder>
    {
        public DeliveryPromiseParticipantOwnerMetafieldDefinitionsArgumentsBuilder Arguments { get; }
        protected override DeliveryPromiseParticipantOwnerMetafieldDefinitionsQueryBuilder Self => this;

        public DeliveryPromiseParticipantOwnerMetafieldDefinitionsQueryBuilder(string name) : base(new Query<MetafieldDefinitionConnection>(name))
        {
            Arguments = new DeliveryPromiseParticipantOwnerMetafieldDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantOwnerMetafieldDefinitionsQueryBuilder(IQuery<MetafieldDefinitionConnection> query) : base(query)
        {
            Arguments = new DeliveryPromiseParticipantOwnerMetafieldDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryPromiseParticipantOwnerMetafieldDefinitionsQueryBuilder SetArguments(Action<DeliveryPromiseParticipantOwnerMetafieldDefinitionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryPromiseParticipantOwnerMetafieldDefinitionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionEdge>(query);
            return this;
        }

        public DeliveryPromiseParticipantOwnerMetafieldDefinitionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public DeliveryPromiseParticipantOwnerMetafieldDefinitionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}