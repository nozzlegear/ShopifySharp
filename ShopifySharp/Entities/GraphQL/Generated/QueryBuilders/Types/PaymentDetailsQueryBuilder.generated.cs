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
    public sealed class PaymentDetailsQueryBuilder : FieldsQueryBuilderBase<PaymentDetails, PaymentDetailsQueryBuilder>
    {
        protected override PaymentDetailsQueryBuilder Self => this;

        public PaymentDetailsQueryBuilder() : this("paymentDetails")
        {
        }

        public PaymentDetailsQueryBuilder(string name) : base(new Query<PaymentDetails>(name))
        {
        }

        public PaymentDetailsQueryBuilder(IQuery<PaymentDetails> query) : base(query)
        {
        }

        public PaymentDetailsQueryBuilder PaymentDetails(Action<PaymentDetailsUnionCasesBuilder> build)
        {
            var query = new Query<PaymentDetails>("paymentDetails");
            var unionBuilder = new PaymentDetailsUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}