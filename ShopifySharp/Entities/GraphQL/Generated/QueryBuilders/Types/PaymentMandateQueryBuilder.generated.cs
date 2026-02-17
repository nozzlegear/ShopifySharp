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
    public sealed class PaymentMandateQueryBuilder : FieldsQueryBuilderBase<PaymentMandate, PaymentMandateQueryBuilder>
    {
        protected override PaymentMandateQueryBuilder Self => this;

        public PaymentMandateQueryBuilder() : this("paymentMandate")
        {
        }

        public PaymentMandateQueryBuilder(string name) : base(new Query<PaymentMandate>(name))
        {
        }

        public PaymentMandateQueryBuilder(IQuery<PaymentMandate> query) : base(query)
        {
        }

        public PaymentMandateQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PaymentMandateQueryBuilder PaymentInstrument(Action<PaymentInstrumentUnionCasesBuilder> build)
        {
            var query = new Query<PaymentInstrument>("paymentInstrument");
            var unionBuilder = new PaymentInstrumentUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}