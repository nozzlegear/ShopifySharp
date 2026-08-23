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
    public sealed class FulfillmentOrderReportProgressOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderReportProgressPayload, FulfillmentOrderReportProgressOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderReportProgressPayload>, IHasArguments<FulfillmentOrderReportProgressArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderReportProgressArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderReportProgressOperationQueryBuilder Self => this;

        public FulfillmentOrderReportProgressOperationQueryBuilder() : this("fulfillmentOrderReportProgress")
        {
        }

        public FulfillmentOrderReportProgressOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderReportProgressPayload>(name))
        {
            Arguments = new FulfillmentOrderReportProgressArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderReportProgressOperationQueryBuilder(IQuery<FulfillmentOrderReportProgressPayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderReportProgressArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderReportProgressOperationQueryBuilder SetArguments(Action<FulfillmentOrderReportProgressArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public FulfillmentOrderReportProgressOperationQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }

        public FulfillmentOrderReportProgressOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderReportProgressUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderReportProgressUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderReportProgressUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderReportProgressUserError>(query);
            return this;
        }
    }
}