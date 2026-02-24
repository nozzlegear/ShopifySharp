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
    public sealed class FulfillmentOrderFulfillmentsQueryBuilder : FieldsQueryBuilderBase<FulfillmentConnection, FulfillmentOrderFulfillmentsQueryBuilder>, IHasArguments<FulfillmentOrderFulfillmentsArgumentsBuilder>
    {
        public FulfillmentOrderFulfillmentsArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderFulfillmentsQueryBuilder Self => this;

        public FulfillmentOrderFulfillmentsQueryBuilder(string name) : base(new Query<FulfillmentConnection>(name))
        {
            Arguments = new FulfillmentOrderFulfillmentsArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderFulfillmentsQueryBuilder(IQuery<FulfillmentConnection> query) : base(query)
        {
            Arguments = new FulfillmentOrderFulfillmentsArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderFulfillmentsQueryBuilder SetArguments(Action<FulfillmentOrderFulfillmentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public FulfillmentOrderFulfillmentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentEdge>(query);
            return this;
        }

        public FulfillmentOrderFulfillmentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public FulfillmentOrderFulfillmentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}