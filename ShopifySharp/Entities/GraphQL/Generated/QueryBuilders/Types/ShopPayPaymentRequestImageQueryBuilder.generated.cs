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
    public sealed class ShopPayPaymentRequestImageQueryBuilder : FieldsQueryBuilderBase<ShopPayPaymentRequestImage, ShopPayPaymentRequestImageQueryBuilder>
    {
        protected override ShopPayPaymentRequestImageQueryBuilder Self => this;

        public ShopPayPaymentRequestImageQueryBuilder() : this("shopPayPaymentRequestImage")
        {
        }

        public ShopPayPaymentRequestImageQueryBuilder(string name) : base(new Query<ShopPayPaymentRequestImage>(name))
        {
        }

        public ShopPayPaymentRequestImageQueryBuilder(IQuery<ShopPayPaymentRequestImage> query) : base(query)
        {
        }

        public ShopPayPaymentRequestImageQueryBuilder Alt()
        {
            base.InnerQuery.AddField("alt");
            return this;
        }

        public ShopPayPaymentRequestImageQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}