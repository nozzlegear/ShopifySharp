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
    public sealed class ReverseDeliveryLineItemQueryBuilder : FieldsQueryBuilderBase<ReverseDeliveryLineItem, ReverseDeliveryLineItemQueryBuilder>
    {
        protected override ReverseDeliveryLineItemQueryBuilder Self => this;

        public ReverseDeliveryLineItemQueryBuilder() : this("reverseDeliveryLineItem")
        {
        }

        public ReverseDeliveryLineItemQueryBuilder(string name) : base(new Query<ReverseDeliveryLineItem>(name))
        {
        }

        public ReverseDeliveryLineItemQueryBuilder(IQuery<ReverseDeliveryLineItem> query) : base(query)
        {
        }

        public ReverseDeliveryLineItemQueryBuilder Dispositions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderDispositionQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderDisposition>("dispositions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderDispositionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderDisposition>(query);
            return this;
        }

        public ReverseDeliveryLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReverseDeliveryLineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public ReverseDeliveryLineItemQueryBuilder ReverseFulfillmentOrderLineItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderLineItem>("reverseFulfillmentOrderLineItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderLineItem>(query);
            return this;
        }
    }
}