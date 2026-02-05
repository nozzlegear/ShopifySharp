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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ReverseFulfillmentOrderDisposePayloadQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrderDisposePayload, ReverseFulfillmentOrderDisposePayloadQueryBuilder>
    {
        protected override ReverseFulfillmentOrderDisposePayloadQueryBuilder Self => this;

        public ReverseFulfillmentOrderDisposePayloadQueryBuilder() : this("reverseFulfillmentOrderDisposePayload")
        {
        }

        public ReverseFulfillmentOrderDisposePayloadQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrderDisposePayload>(name))
        {
        }

        public ReverseFulfillmentOrderDisposePayloadQueryBuilder(IQuery<ReverseFulfillmentOrderDisposePayload> query) : base(query)
        {
        }

        public ReverseFulfillmentOrderDisposePayloadQueryBuilder ReverseFulfillmentOrderLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderLineItem>("reverseFulfillmentOrderLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderLineItem>(query);
            return this;
        }

        public ReverseFulfillmentOrderDisposePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}