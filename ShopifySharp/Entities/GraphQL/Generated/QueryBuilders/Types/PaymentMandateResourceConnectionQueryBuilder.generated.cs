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
    public sealed class PaymentMandateResourceConnectionQueryBuilder : FieldsQueryBuilderBase<PaymentMandateResourceConnection, PaymentMandateResourceConnectionQueryBuilder>
    {
        protected override PaymentMandateResourceConnectionQueryBuilder Self => this;

        public PaymentMandateResourceConnectionQueryBuilder() : this("paymentMandateResourceConnection")
        {
        }

        public PaymentMandateResourceConnectionQueryBuilder(string name) : base(new Query<PaymentMandateResourceConnection>(name))
        {
        }

        public PaymentMandateResourceConnectionQueryBuilder(IQuery<PaymentMandateResourceConnection> query) : base(query)
        {
        }

        public PaymentMandateResourceConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentMandateResourceEdgeQueryBuilder> build)
        {
            var query = new Query<PaymentMandateResourceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentMandateResourceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentMandateResourceEdge>(query);
            return this;
        }

        public PaymentMandateResourceConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentMandateResourceQueryBuilder> build)
        {
            var query = new Query<PaymentMandateResource>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentMandateResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentMandateResource>(query);
            return this;
        }

        public PaymentMandateResourceConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}