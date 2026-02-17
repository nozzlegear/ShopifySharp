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

        public PaymentMandateResourceConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentMandateResourceEdgeQueryBuilder> build)
        {
            var query = new Query<PaymentMandateResourceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentMandateResourceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentMandateResourceEdge>(query);
            return this;
        }

        public PaymentMandateResourceConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentMandateResourceQueryBuilder> build)
        {
            var query = new Query<PaymentMandateResource>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentMandateResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentMandateResource>(query);
            return this;
        }

        public PaymentMandateResourceConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}