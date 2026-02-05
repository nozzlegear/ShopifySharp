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
    public sealed class OrderPaymentCollectionDetailsQueryBuilder : FieldsQueryBuilderBase<OrderPaymentCollectionDetails, OrderPaymentCollectionDetailsQueryBuilder>
    {
        protected override OrderPaymentCollectionDetailsQueryBuilder Self => this;

        public OrderPaymentCollectionDetailsQueryBuilder() : this("orderPaymentCollectionDetails")
        {
        }

        public OrderPaymentCollectionDetailsQueryBuilder(string name) : base(new Query<OrderPaymentCollectionDetails>(name))
        {
        }

        public OrderPaymentCollectionDetailsQueryBuilder(IQuery<OrderPaymentCollectionDetails> query) : base(query)
        {
        }

        public OrderPaymentCollectionDetailsQueryBuilder AdditionalPaymentCollectionUrl()
        {
            base.InnerQuery.AddField("additionalPaymentCollectionUrl");
            return this;
        }

        public OrderPaymentCollectionDetailsQueryBuilder VaultedPaymentMethods(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentMandateQueryBuilder> build)
        {
            var query = new Query<PaymentMandate>("vaultedPaymentMethods");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentMandateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentMandate>(query);
            return this;
        }
    }
}