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
    public sealed class ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder : FieldsQueryBuilderBase<ShopPayPaymentRequestReceiptProcessingStatus, ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder>
    {
        protected override ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder Self => this;

        public ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder() : this("shopPayPaymentRequestReceiptProcessingStatus")
        {
        }

        public ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder(string name) : base(new Query<ShopPayPaymentRequestReceiptProcessingStatus>(name))
        {
        }

        public ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder(IQuery<ShopPayPaymentRequestReceiptProcessingStatus> query) : base(query)
        {
        }

        public ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        public ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }

        public ShopPayPaymentRequestReceiptProcessingStatusQueryBuilder State()
        {
            base.InnerQuery.AddField("state");
            return this;
        }
    }
}