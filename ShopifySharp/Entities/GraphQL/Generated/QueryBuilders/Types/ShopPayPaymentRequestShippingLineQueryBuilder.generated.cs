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
    public sealed class ShopPayPaymentRequestShippingLineQueryBuilder : FieldsQueryBuilderBase<ShopPayPaymentRequestShippingLine, ShopPayPaymentRequestShippingLineQueryBuilder>
    {
        protected override ShopPayPaymentRequestShippingLineQueryBuilder Self => this;

        public ShopPayPaymentRequestShippingLineQueryBuilder() : this("shopPayPaymentRequestShippingLine")
        {
        }

        public ShopPayPaymentRequestShippingLineQueryBuilder(string name) : base(new Query<ShopPayPaymentRequestShippingLine>(name))
        {
        }

        public ShopPayPaymentRequestShippingLineQueryBuilder(IQuery<ShopPayPaymentRequestShippingLine> query) : base(query)
        {
        }

        public ShopPayPaymentRequestShippingLineQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopPayPaymentRequestShippingLineQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ShopPayPaymentRequestShippingLineQueryBuilder Label()
        {
            base.InnerQuery.AddField("label");
            return this;
        }
    }
}