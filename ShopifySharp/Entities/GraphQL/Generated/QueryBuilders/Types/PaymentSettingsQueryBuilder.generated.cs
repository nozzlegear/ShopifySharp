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
    public sealed class PaymentSettingsQueryBuilder : FieldsQueryBuilderBase<PaymentSettings, PaymentSettingsQueryBuilder>
    {
        protected override PaymentSettingsQueryBuilder Self => this;

        public PaymentSettingsQueryBuilder() : this("paymentSettings")
        {
        }

        public PaymentSettingsQueryBuilder(string name) : base(new Query<PaymentSettings>(name))
        {
        }

        public PaymentSettingsQueryBuilder(IQuery<PaymentSettings> query) : base(query)
        {
        }

        public PaymentSettingsQueryBuilder SupportedDigitalWallets()
        {
            base.InnerQuery.AddField("supportedDigitalWallets");
            return this;
        }
    }
}