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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class ReturnableFulfillmentOperationQueryBuilder : FieldsQueryBuilderBase<ReturnableFulfillment, ReturnableFulfillmentOperationQueryBuilder>, IGraphOperationQueryBuilder<ReturnableFulfillment>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ReturnableFulfillmentArgumentsBuilder Arguments { get; }
        protected override ReturnableFulfillmentOperationQueryBuilder Self => this;

        public ReturnableFulfillmentOperationQueryBuilder() : this("returnableFulfillment")
        {
        }

        public ReturnableFulfillmentOperationQueryBuilder(string name) : base(new Query<ReturnableFulfillment>(name))
        {
            Arguments = new ReturnableFulfillmentArgumentsBuilder(base.InnerQuery);
        }

        public ReturnableFulfillmentOperationQueryBuilder(IQuery<ReturnableFulfillment> query) : base(query)
        {
            Arguments = new ReturnableFulfillmentArgumentsBuilder(base.InnerQuery);
        }

        public ReturnableFulfillmentOperationQueryBuilder Fulfillment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public ReturnableFulfillmentOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReturnableFulfillmentOperationQueryBuilder ReturnableFulfillmentLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<ReturnableFulfillmentLineItemConnection>("returnableFulfillmentLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnableFulfillmentLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnableFulfillmentLineItemConnection>(query);
            return this;
        }
    }
}