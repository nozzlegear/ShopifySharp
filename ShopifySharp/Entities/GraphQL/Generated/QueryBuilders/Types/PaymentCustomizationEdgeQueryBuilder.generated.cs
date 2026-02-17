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
    public sealed class PaymentCustomizationEdgeQueryBuilder : FieldsQueryBuilderBase<PaymentCustomizationEdge, PaymentCustomizationEdgeQueryBuilder>
    {
        protected override PaymentCustomizationEdgeQueryBuilder Self => this;

        public PaymentCustomizationEdgeQueryBuilder() : this("paymentCustomizationEdge")
        {
        }

        public PaymentCustomizationEdgeQueryBuilder(string name) : base(new Query<PaymentCustomizationEdge>(name))
        {
        }

        public PaymentCustomizationEdgeQueryBuilder(IQuery<PaymentCustomizationEdge> query) : base(query)
        {
        }

        public PaymentCustomizationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public PaymentCustomizationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder> build)
        {
            var query = new Query<PaymentCustomization>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomization>(query);
            return this;
        }
    }
}