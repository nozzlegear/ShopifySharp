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
    public sealed class PaymentMandateResourceEdgeQueryBuilder : FieldsQueryBuilderBase<PaymentMandateResourceEdge, PaymentMandateResourceEdgeQueryBuilder>
    {
        protected override PaymentMandateResourceEdgeQueryBuilder Self => this;

        public PaymentMandateResourceEdgeQueryBuilder() : this("paymentMandateResourceEdge")
        {
        }

        public PaymentMandateResourceEdgeQueryBuilder(string name) : base(new Query<PaymentMandateResourceEdge>(name))
        {
        }

        public PaymentMandateResourceEdgeQueryBuilder(IQuery<PaymentMandateResourceEdge> query) : base(query)
        {
        }

        public PaymentMandateResourceEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public PaymentMandateResourceEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentMandateResourceQueryBuilder> build)
        {
            var query = new Query<PaymentMandateResource>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentMandateResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentMandateResource>(query);
            return this;
        }
    }
}