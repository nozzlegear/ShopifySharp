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
    public sealed class QueryRootReturnableFulfillmentQueryBuilder : FieldsQueryBuilderBase<ReturnableFulfillment, QueryRootReturnableFulfillmentQueryBuilder>, IHasArguments<QueryRootReturnableFulfillmentArgumentsBuilder>
    {
        public QueryRootReturnableFulfillmentArgumentsBuilder Arguments { get; }
        protected override QueryRootReturnableFulfillmentQueryBuilder Self => this;

        public QueryRootReturnableFulfillmentQueryBuilder(string name) : base(new Query<ReturnableFulfillment>(name))
        {
            Arguments = new QueryRootReturnableFulfillmentArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootReturnableFulfillmentQueryBuilder(IQuery<ReturnableFulfillment> query) : base(query)
        {
            Arguments = new QueryRootReturnableFulfillmentArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootReturnableFulfillmentQueryBuilder SetArguments(Action<QueryRootReturnableFulfillmentArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootReturnableFulfillmentQueryBuilder Fulfillment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public QueryRootReturnableFulfillmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootReturnableFulfillmentQueryBuilder ReturnableFulfillmentLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillmentLineItemConnection>("returnableFulfillmentLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillmentLineItemConnection>(query);
            return this;
        }
    }
}