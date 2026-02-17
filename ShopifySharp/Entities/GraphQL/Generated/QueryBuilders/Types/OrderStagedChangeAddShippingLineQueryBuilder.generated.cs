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
    public sealed class OrderStagedChangeAddShippingLineQueryBuilder : FieldsQueryBuilderBase<OrderStagedChangeAddShippingLine, OrderStagedChangeAddShippingLineQueryBuilder>
    {
        protected override OrderStagedChangeAddShippingLineQueryBuilder Self => this;

        public OrderStagedChangeAddShippingLineQueryBuilder() : this("orderStagedChangeAddShippingLine")
        {
        }

        public OrderStagedChangeAddShippingLineQueryBuilder(string name) : base(new Query<OrderStagedChangeAddShippingLine>(name))
        {
        }

        public OrderStagedChangeAddShippingLineQueryBuilder(IQuery<OrderStagedChangeAddShippingLine> query) : base(query)
        {
        }

        public OrderStagedChangeAddShippingLineQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public OrderStagedChangeAddShippingLineQueryBuilder PresentmentTitle()
        {
            base.InnerQuery.AddField("presentmentTitle");
            return this;
        }

        public OrderStagedChangeAddShippingLineQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public OrderStagedChangeAddShippingLineQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}