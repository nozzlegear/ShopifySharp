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
    public sealed class DeliveryValueBasedRateGroupConnectionQueryBuilder : FieldsQueryBuilderBase<DeliveryValueBasedRateGroupConnection, DeliveryValueBasedRateGroupConnectionQueryBuilder>, IHasArguments<DeliveryValueBasedRateGroupConnectionArgumentsBuilder>
    {
        public DeliveryValueBasedRateGroupConnectionArgumentsBuilder Arguments { get; }
        protected override DeliveryValueBasedRateGroupConnectionQueryBuilder Self => this;

        public DeliveryValueBasedRateGroupConnectionQueryBuilder() : this("deliveryValueBasedRateGroupConnection")
        {
        }

        public DeliveryValueBasedRateGroupConnectionQueryBuilder(string name) : base(new Query<DeliveryValueBasedRateGroupConnection>(name))
        {
            Arguments = new DeliveryValueBasedRateGroupConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryValueBasedRateGroupConnectionQueryBuilder(IQuery<DeliveryValueBasedRateGroupConnection> query) : base(query)
        {
            Arguments = new DeliveryValueBasedRateGroupConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryValueBasedRateGroupConnectionQueryBuilder SetArguments(Action<DeliveryValueBasedRateGroupConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryValueBasedRateGroupConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateGroupEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryValueBasedRateGroupEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateGroupEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryValueBasedRateGroupEdge>(query);
            return this;
        }

        public DeliveryValueBasedRateGroupConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateGroupQueryBuilder> build)
        {
            var query = new Query<DeliveryValueBasedRateGroup>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryValueBasedRateGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryValueBasedRateGroup>(query);
            return this;
        }

        public DeliveryValueBasedRateGroupConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}