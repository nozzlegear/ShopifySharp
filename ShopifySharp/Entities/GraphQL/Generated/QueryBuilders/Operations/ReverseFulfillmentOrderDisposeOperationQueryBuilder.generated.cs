#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
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

        public ReverseFulfillmentOrderDisposeOperationQueryBuilder ReverseFulfillmentOrderLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderLineItem>("reverseFulfillmentOrderLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderLineItem>(query);
            return this;
        }

        public ReverseFulfillmentOrderDisposeOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}