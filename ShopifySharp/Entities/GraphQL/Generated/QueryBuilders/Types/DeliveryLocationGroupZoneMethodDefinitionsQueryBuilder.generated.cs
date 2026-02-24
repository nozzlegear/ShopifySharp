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
    public sealed class DeliveryLocationGroupZoneMethodDefinitionsQueryBuilder : FieldsQueryBuilderBase<DeliveryMethodDefinitionConnection, DeliveryLocationGroupZoneMethodDefinitionsQueryBuilder>, IHasArguments<DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder>
    {
        public DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder Arguments { get; }
        protected override DeliveryLocationGroupZoneMethodDefinitionsQueryBuilder Self => this;

        public DeliveryLocationGroupZoneMethodDefinitionsQueryBuilder(string name) : base(new Query<DeliveryMethodDefinitionConnection>(name))
        {
            Arguments = new DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryLocationGroupZoneMethodDefinitionsQueryBuilder(IQuery<DeliveryMethodDefinitionConnection> query) : base(query)
        {
            Arguments = new DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryLocationGroupZoneMethodDefinitionsQueryBuilder SetArguments(Action<DeliveryLocationGroupZoneMethodDefinitionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryLocationGroupZoneMethodDefinitionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryMethodDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryMethodDefinitionEdge>(query);
            return this;
        }

        public DeliveryLocationGroupZoneMethodDefinitionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryMethodDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryMethodDefinition>(query);
            return this;
        }

        public DeliveryLocationGroupZoneMethodDefinitionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}