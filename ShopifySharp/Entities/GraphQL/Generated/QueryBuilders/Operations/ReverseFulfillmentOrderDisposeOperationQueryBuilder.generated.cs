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
    public sealed class ReverseFulfillmentOrderDisposeOperationQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrderDisposePayload, ReverseFulfillmentOrderDisposeOperationQueryBuilder>, IGraphOperationQueryBuilder<ReverseFulfillmentOrderDisposePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ReverseFulfillmentOrderDisposeArgumentsBuilder Arguments { get; }
        protected override ReverseFulfillmentOrderDisposeOperationQueryBuilder Self => this;

        public ReverseFulfillmentOrderDisposeOperationQueryBuilder() : this("reverseFulfillmentOrderDispose")
        {
        }

        public ReverseFulfillmentOrderDisposeOperationQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrderDisposePayload>(name))
        {
            Arguments = new ReverseFulfillmentOrderDisposeArgumentsBuilder(base.InnerQuery);
        }

        public ReverseFulfillmentOrderDisposeOperationQueryBuilder(IQuery<ReverseFulfillmentOrderDisposePayload> query) : base(query)
        {
            Arguments = new ReverseFulfillmentOrderDisposeArgumentsBuilder(base.InnerQuery);
        }

        public ReverseFulfillmentOrderDisposeOperationQueryBuilder ReverseFulfillmentOrderLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderLineItem>("reverseFulfillmentOrderLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderLineItem>(query);
            return this;
        }

        public ReverseFulfillmentOrderDisposeOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}