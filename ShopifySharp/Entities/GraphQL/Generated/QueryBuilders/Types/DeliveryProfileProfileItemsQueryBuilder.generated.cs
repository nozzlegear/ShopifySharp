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
    public sealed class DeliveryProfileProfileItemsQueryBuilder : FieldsQueryBuilderBase<DeliveryProfileItemConnection, DeliveryProfileProfileItemsQueryBuilder>, IHasArguments<DeliveryProfileProfileItemsArgumentsBuilder>
    {
        public DeliveryProfileProfileItemsArgumentsBuilder Arguments { get; }
        protected override DeliveryProfileProfileItemsQueryBuilder Self => this;

        public DeliveryProfileProfileItemsQueryBuilder(string name) : base(new Query<DeliveryProfileItemConnection>(name))
        {
            Arguments = new DeliveryProfileProfileItemsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileProfileItemsQueryBuilder(IQuery<DeliveryProfileItemConnection> query) : base(query)
        {
            Arguments = new DeliveryProfileProfileItemsArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryProfileProfileItemsQueryBuilder SetArguments(Action<DeliveryProfileProfileItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryProfileProfileItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileItemEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileItemEdge>(query);
            return this;
        }

        public DeliveryProfileProfileItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileItemQueryBuilder> build)
        {
            var query = new Query<DeliveryProfileItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfileItem>(query);
            return this;
        }

        public DeliveryProfileProfileItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}