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