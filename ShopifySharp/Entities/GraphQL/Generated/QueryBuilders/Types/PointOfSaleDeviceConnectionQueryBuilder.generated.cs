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
    public sealed class PointOfSaleDeviceConnectionQueryBuilder : FieldsQueryBuilderBase<PointOfSaleDeviceConnection, PointOfSaleDeviceConnectionQueryBuilder>, IHasArguments<PointOfSaleDeviceConnectionArgumentsBuilder>
    {
        public PointOfSaleDeviceConnectionArgumentsBuilder Arguments { get; }
        protected override PointOfSaleDeviceConnectionQueryBuilder Self => this;

        public PointOfSaleDeviceConnectionQueryBuilder() : this("pointOfSaleDeviceConnection")
        {
        }

        public PointOfSaleDeviceConnectionQueryBuilder(string name) : base(new Query<PointOfSaleDeviceConnection>(name))
        {
            Arguments = new PointOfSaleDeviceConnectionArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDeviceConnectionQueryBuilder(IQuery<PointOfSaleDeviceConnection> query) : base(query)
        {
            Arguments = new PointOfSaleDeviceConnectionArgumentsBuilder(base.InnerQuery);
        }

        public PointOfSaleDeviceConnectionQueryBuilder SetArguments(Action<PointOfSaleDeviceConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PointOfSaleDeviceConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceEdgeQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDeviceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDeviceEdge>(query);
            return this;
        }

        public PointOfSaleDeviceConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder> build)
        {
            var query = new Query<PointOfSaleDevice>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PointOfSaleDeviceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PointOfSaleDevice>(query);
            return this;
        }

        public PointOfSaleDeviceConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}