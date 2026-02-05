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
    public sealed class PaymentInstrumentQueryBuilder : FieldsQueryBuilderBase<PaymentInstrument, PaymentInstrumentQueryBuilder>
    {
        protected override PaymentInstrumentQueryBuilder Self => this;

        public PaymentInstrumentQueryBuilder() : this("paymentInstrument")
        {
        }

        public PaymentInstrumentQueryBuilder(string name) : base(new Query<PaymentInstrument>(name))
        {
        }

        public PaymentInstrumentQueryBuilder(IQuery<PaymentInstrument> query) : base(query)
        {
        }

        public PaymentInstrumentQueryBuilder PaymentInstrument(Action<PaymentInstrumentUnionCasesBuilder> build)
        {
            var query = new Query<PaymentInstrument>("paymentInstrument");
            var unionBuilder = new PaymentInstrumentUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}