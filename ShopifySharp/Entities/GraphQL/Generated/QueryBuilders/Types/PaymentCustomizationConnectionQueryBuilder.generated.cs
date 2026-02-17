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
    public sealed class PaymentCustomizationConnectionQueryBuilder : FieldsQueryBuilderBase<PaymentCustomizationConnection, PaymentCustomizationConnectionQueryBuilder>
    {
        protected override PaymentCustomizationConnectionQueryBuilder Self => this;

        public PaymentCustomizationConnectionQueryBuilder() : this("paymentCustomizationConnection")
        {
        }

        public PaymentCustomizationConnectionQueryBuilder(string name) : base(new Query<PaymentCustomizationConnection>(name))
        {
        }

        public PaymentCustomizationConnectionQueryBuilder(IQuery<PaymentCustomizationConnection> query) : base(query)
        {
        }

        public PaymentCustomizationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationEdgeQueryBuilder> build)
        {
            var query = new Query<PaymentCustomizationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomizationEdge>(query);
            return this;
        }

        public PaymentCustomizationConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder> build)
        {
            var query = new Query<PaymentCustomization>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomization>(query);
            return this;
        }

        public PaymentCustomizationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}