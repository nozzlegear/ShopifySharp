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
    public sealed class MetafieldReferencerLocationsForMoveQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLocationForMoveConnection, MetafieldReferencerLocationsForMoveQueryBuilder>, IHasArguments<MetafieldReferencerLocationsForMoveArgumentsBuilder>
    {
        public MetafieldReferencerLocationsForMoveArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerLocationsForMoveQueryBuilder Self => this;

        public MetafieldReferencerLocationsForMoveQueryBuilder(string name) : base(new Query<FulfillmentOrderLocationForMoveConnection>(name))
        {
            Arguments = new MetafieldReferencerLocationsForMoveArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerLocationsForMoveQueryBuilder(IQuery<FulfillmentOrderLocationForMoveConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerLocationsForMoveArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerLocationsForMoveQueryBuilder SetArguments(Action<MetafieldReferencerLocationsForMoveArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerLocationsForMoveQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLocationForMoveEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLocationForMoveEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLocationForMoveEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLocationForMoveEdge>(query);
            return this;
        }

        public MetafieldReferencerLocationsForMoveQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLocationForMoveQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLocationForMove>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLocationForMoveQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLocationForMove>(query);
            return this;
        }

        public MetafieldReferencerLocationsForMoveQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}