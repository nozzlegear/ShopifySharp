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
    public sealed class QueryRootDeliveryCustomizationsQueryBuilder : FieldsQueryBuilderBase<DeliveryCustomizationConnection, QueryRootDeliveryCustomizationsQueryBuilder>, IHasArguments<QueryRootDeliveryCustomizationsArgumentsBuilder>
    {
        public QueryRootDeliveryCustomizationsArgumentsBuilder Arguments { get; }
        protected override QueryRootDeliveryCustomizationsQueryBuilder Self => this;

        public QueryRootDeliveryCustomizationsQueryBuilder(string name) : base(new Query<DeliveryCustomizationConnection>(name))
        {
            Arguments = new QueryRootDeliveryCustomizationsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDeliveryCustomizationsQueryBuilder(IQuery<DeliveryCustomizationConnection> query) : base(query)
        {
            Arguments = new QueryRootDeliveryCustomizationsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDeliveryCustomizationsQueryBuilder SetArguments(Action<QueryRootDeliveryCustomizationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDeliveryCustomizationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomizationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomizationEdge>(query);
            return this;
        }

        public QueryRootDeliveryCustomizationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder> build)
        {
            var query = new Query<DeliveryCustomization>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCustomization>(query);
            return this;
        }

        public QueryRootDeliveryCustomizationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}