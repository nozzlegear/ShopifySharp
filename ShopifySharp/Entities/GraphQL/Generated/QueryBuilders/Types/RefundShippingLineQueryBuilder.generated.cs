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
    public sealed class RefundShippingLineQueryBuilder : FieldsQueryBuilderBase<RefundShippingLine, RefundShippingLineQueryBuilder>
    {
        protected override RefundShippingLineQueryBuilder Self => this;

        public RefundShippingLineQueryBuilder() : this("refundShippingLine")
        {
        }

        public RefundShippingLineQueryBuilder(string name) : base(new Query<RefundShippingLine>(name))
        {
        }

        public RefundShippingLineQueryBuilder(IQuery<RefundShippingLine> query) : base(query)
        {
        }

        public RefundShippingLineQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public RefundShippingLineQueryBuilder ShippingLine(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder> build)
        {
            var query = new Query<ShippingLine>("shippingLine");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLine>(query);
            return this;
        }

        public RefundShippingLineQueryBuilder SubtotalAmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public RefundShippingLineQueryBuilder TaxAmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("taxAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}