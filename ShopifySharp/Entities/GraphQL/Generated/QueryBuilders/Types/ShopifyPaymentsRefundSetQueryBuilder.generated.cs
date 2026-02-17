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
    public sealed class ShopifyPaymentsRefundSetQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsRefundSet, ShopifyPaymentsRefundSetQueryBuilder>
    {
        protected override ShopifyPaymentsRefundSetQueryBuilder Self => this;

        public ShopifyPaymentsRefundSetQueryBuilder() : this("shopifyPaymentsRefundSet")
        {
        }

        public ShopifyPaymentsRefundSetQueryBuilder(string name) : base(new Query<ShopifyPaymentsRefundSet>(name))
        {
        }

        public ShopifyPaymentsRefundSetQueryBuilder(IQuery<ShopifyPaymentsRefundSet> query) : base(query)
        {
        }

        public ShopifyPaymentsRefundSetQueryBuilder AcquirerReferenceNumber()
        {
            base.InnerQuery.AddField("acquirerReferenceNumber");
            return this;
        }
    }
}