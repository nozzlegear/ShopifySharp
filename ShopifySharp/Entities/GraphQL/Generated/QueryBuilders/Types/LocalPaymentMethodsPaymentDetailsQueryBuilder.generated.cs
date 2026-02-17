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
    public sealed class LocalPaymentMethodsPaymentDetailsQueryBuilder : FieldsQueryBuilderBase<LocalPaymentMethodsPaymentDetails, LocalPaymentMethodsPaymentDetailsQueryBuilder>
    {
        protected override LocalPaymentMethodsPaymentDetailsQueryBuilder Self => this;

        public LocalPaymentMethodsPaymentDetailsQueryBuilder() : this("localPaymentMethodsPaymentDetails")
        {
        }

        public LocalPaymentMethodsPaymentDetailsQueryBuilder(string name) : base(new Query<LocalPaymentMethodsPaymentDetails>(name))
        {
        }

        public LocalPaymentMethodsPaymentDetailsQueryBuilder(IQuery<LocalPaymentMethodsPaymentDetails> query) : base(query)
        {
        }

        public LocalPaymentMethodsPaymentDetailsQueryBuilder PaymentDescriptor()
        {
            base.InnerQuery.AddField("paymentDescriptor");
            return this;
        }

        public LocalPaymentMethodsPaymentDetailsQueryBuilder PaymentMethodName()
        {
            base.InnerQuery.AddField("paymentMethodName");
            return this;
        }
    }
}