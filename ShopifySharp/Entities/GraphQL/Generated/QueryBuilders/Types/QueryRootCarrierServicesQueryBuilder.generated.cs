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
    public sealed class QueryRootCarrierServicesQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierServiceConnection, QueryRootCarrierServicesQueryBuilder>, IHasArguments<QueryRootCarrierServicesArgumentsBuilder>
    {
        public QueryRootCarrierServicesArgumentsBuilder Arguments { get; }
        protected override QueryRootCarrierServicesQueryBuilder Self => this;

        public QueryRootCarrierServicesQueryBuilder(string name) : base(new Query<DeliveryCarrierServiceConnection>(name))
        {
            Arguments = new QueryRootCarrierServicesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCarrierServicesQueryBuilder(IQuery<DeliveryCarrierServiceConnection> query) : base(query)
        {
            Arguments = new QueryRootCarrierServicesArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCarrierServicesQueryBuilder SetArguments(Action<QueryRootCarrierServicesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCarrierServicesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierServiceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierServiceEdge>(query);
            return this;
        }

        public QueryRootCarrierServicesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }

        public QueryRootCarrierServicesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}