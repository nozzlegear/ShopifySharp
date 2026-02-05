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
    public sealed class OrderInvoiceSendUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderInvoiceSendUserError, OrderInvoiceSendUserErrorQueryBuilder>
    {
        protected override OrderInvoiceSendUserErrorQueryBuilder Self => this;

        public OrderInvoiceSendUserErrorQueryBuilder() : this("orderInvoiceSendUserError")
        {
        }

        public OrderInvoiceSendUserErrorQueryBuilder(string name) : base(new Query<OrderInvoiceSendUserError>(name))
        {
        }

        public OrderInvoiceSendUserErrorQueryBuilder(IQuery<OrderInvoiceSendUserError> query) : base(query)
        {
        }

        public OrderInvoiceSendUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderInvoiceSendUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderInvoiceSendUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}