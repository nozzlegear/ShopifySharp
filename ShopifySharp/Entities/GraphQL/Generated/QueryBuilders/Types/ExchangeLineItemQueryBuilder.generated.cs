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
    public sealed class ExchangeLineItemQueryBuilder : FieldsQueryBuilderBase<ExchangeLineItem, ExchangeLineItemQueryBuilder>
    {
        protected override ExchangeLineItemQueryBuilder Self => this;

        public ExchangeLineItemQueryBuilder() : this("exchangeLineItem")
        {
        }

        public ExchangeLineItemQueryBuilder(string name) : base(new Query<ExchangeLineItem>(name))
        {
        }

        public ExchangeLineItemQueryBuilder(IQuery<ExchangeLineItem> query) : base(query)
        {
        }

        public ExchangeLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ExchangeLineItemQueryBuilder LineItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("lineItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItem>(query);
            return this;
        }

        public ExchangeLineItemQueryBuilder LineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItem>(query);
            return this;
        }

        public ExchangeLineItemQueryBuilder ProcessableQuantity()
        {
            base.InnerQuery.AddField("processableQuantity");
            return this;
        }

        public ExchangeLineItemQueryBuilder ProcessedQuantity()
        {
            base.InnerQuery.AddField("processedQuantity");
            return this;
        }

        public ExchangeLineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public ExchangeLineItemQueryBuilder UnprocessedQuantity()
        {
            base.InnerQuery.AddField("unprocessedQuantity");
            return this;
        }

        public ExchangeLineItemQueryBuilder VariantId()
        {
            base.InnerQuery.AddField("variantId");
            return this;
        }
    }
}