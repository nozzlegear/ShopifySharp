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
    public sealed class DeliveryFlatRateGroupConnectionQueryBuilder : FieldsQueryBuilderBase<DeliveryFlatRateGroupConnection, DeliveryFlatRateGroupConnectionQueryBuilder>, IHasArguments<DeliveryFlatRateGroupConnectionArgumentsBuilder>
    {
        public DeliveryFlatRateGroupConnectionArgumentsBuilder Arguments { get; }
        protected override DeliveryFlatRateGroupConnectionQueryBuilder Self => this;

        public DeliveryFlatRateGroupConnectionQueryBuilder() : this("deliveryFlatRateGroupConnection")
        {
        }

        public DeliveryFlatRateGroupConnectionQueryBuilder(string name) : base(new Query<DeliveryFlatRateGroupConnection>(name))
        {
            Arguments = new DeliveryFlatRateGroupConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryFlatRateGroupConnectionQueryBuilder(IQuery<DeliveryFlatRateGroupConnection> query) : base(query)
        {
            Arguments = new DeliveryFlatRateGroupConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryFlatRateGroupConnectionQueryBuilder SetArguments(Action<DeliveryFlatRateGroupConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryFlatRateGroupConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateGroupEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryFlatRateGroupEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateGroupEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryFlatRateGroupEdge>(query);
            return this;
        }

        public DeliveryFlatRateGroupConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryFlatRateGroup>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryFlatRateGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryFlatRateGroup>(query);
            return this;
        }

        public DeliveryFlatRateGroupConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}