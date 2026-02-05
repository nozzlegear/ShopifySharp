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
    public sealed class ReverseFulfillmentOrderLineItemQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrderLineItem, ReverseFulfillmentOrderLineItemQueryBuilder>
    {
        protected override ReverseFulfillmentOrderLineItemQueryBuilder Self => this;

        public ReverseFulfillmentOrderLineItemQueryBuilder() : this("reverseFulfillmentOrderLineItem")
        {
        }

        public ReverseFulfillmentOrderLineItemQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrderLineItem>(name))
        {
        }

        public ReverseFulfillmentOrderLineItemQueryBuilder(IQuery<ReverseFulfillmentOrderLineItem> query) : base(query)
        {
        }

        public ReverseFulfillmentOrderLineItemQueryBuilder Dispositions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderDispositionQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderDisposition>("dispositions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderDispositionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderDisposition>(query);
            return this;
        }

        public ReverseFulfillmentOrderLineItemQueryBuilder FulfillmentLineItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentLineItemQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItem>("fulfillmentLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentLineItem>(query);
            return this;
        }

        public ReverseFulfillmentOrderLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReverseFulfillmentOrderLineItemQueryBuilder TotalQuantity()
        {
            base.InnerQuery.AddField("totalQuantity");
            return this;
        }
    }
}