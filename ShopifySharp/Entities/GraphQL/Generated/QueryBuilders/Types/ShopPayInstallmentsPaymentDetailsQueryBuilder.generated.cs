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
    public sealed class ShopPayInstallmentsPaymentDetailsQueryBuilder : FieldsQueryBuilderBase<ShopPayInstallmentsPaymentDetails, ShopPayInstallmentsPaymentDetailsQueryBuilder>
    {
        protected override ShopPayInstallmentsPaymentDetailsQueryBuilder Self => this;

        public ShopPayInstallmentsPaymentDetailsQueryBuilder() : this("shopPayInstallmentsPaymentDetails")
        {
        }

        public ShopPayInstallmentsPaymentDetailsQueryBuilder(string name) : base(new Query<ShopPayInstallmentsPaymentDetails>(name))
        {
        }

        public ShopPayInstallmentsPaymentDetailsQueryBuilder(IQuery<ShopPayInstallmentsPaymentDetails> query) : base(query)
        {
        }

        public ShopPayInstallmentsPaymentDetailsQueryBuilder PaymentMethodName()
        {
            base.InnerQuery.AddField("paymentMethodName");
            return this;
        }
    }
}