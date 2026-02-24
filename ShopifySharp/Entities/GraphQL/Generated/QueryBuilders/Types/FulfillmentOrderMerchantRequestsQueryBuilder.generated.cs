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
    public sealed class FulfillmentOrderMerchantRequestsQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderMerchantRequestConnection, FulfillmentOrderMerchantRequestsQueryBuilder>, IHasArguments<FulfillmentOrderMerchantRequestsArgumentsBuilder>
    {
        public FulfillmentOrderMerchantRequestsArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderMerchantRequestsQueryBuilder Self => this;

        public FulfillmentOrderMerchantRequestsQueryBuilder(string name) : base(new Query<FulfillmentOrderMerchantRequestConnection>(name))
        {
            Arguments = new FulfillmentOrderMerchantRequestsArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderMerchantRequestsQueryBuilder(IQuery<FulfillmentOrderMerchantRequestConnection> query) : base(query)
        {
            Arguments = new FulfillmentOrderMerchantRequestsArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderMerchantRequestsQueryBuilder SetArguments(Action<FulfillmentOrderMerchantRequestsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public FulfillmentOrderMerchantRequestsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestEdgeQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderMerchantRequestEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderMerchantRequestEdge>(query);
            return this;
        }

        public FulfillmentOrderMerchantRequestsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderMerchantRequest>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderMerchantRequest>(query);
            return this;
        }

        public FulfillmentOrderMerchantRequestsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}