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
    public sealed class QueryRootReverseFulfillmentOrderQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrder, QueryRootReverseFulfillmentOrderQueryBuilder>, IHasArguments<QueryRootReverseFulfillmentOrderArgumentsBuilder>
    {
        public QueryRootReverseFulfillmentOrderArgumentsBuilder Arguments { get; }
        protected override QueryRootReverseFulfillmentOrderQueryBuilder Self => this;

        public QueryRootReverseFulfillmentOrderQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrder>(name))
        {
            Arguments = new QueryRootReverseFulfillmentOrderArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootReverseFulfillmentOrderQueryBuilder(IQuery<ReverseFulfillmentOrder> query) : base(query)
        {
            Arguments = new QueryRootReverseFulfillmentOrderArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootReverseFulfillmentOrderQueryBuilder SetArguments(Action<QueryRootReverseFulfillmentOrderArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootReverseFulfillmentOrderQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootReverseFulfillmentOrderQueryBuilder LineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderLineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderLineItemConnection>(query);
            return this;
        }

        public QueryRootReverseFulfillmentOrderQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public QueryRootReverseFulfillmentOrderQueryBuilder ReverseDeliveries(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryConnectionQueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryConnection>("reverseDeliveries");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDeliveryConnection>(query);
            return this;
        }

        public QueryRootReverseFulfillmentOrderQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public QueryRootReverseFulfillmentOrderQueryBuilder ThirdPartyConfirmation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderThirdPartyConfirmation>("thirdPartyConfirmation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderThirdPartyConfirmation>(query);
            return this;
        }
    }
}