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
    public sealed class OrderCreateMandatePaymentJobResultQueryBuilder : FieldsQueryBuilderBase<OrderCreateMandatePaymentJobResult, OrderCreateMandatePaymentJobResultQueryBuilder>
    {
        protected override OrderCreateMandatePaymentJobResultQueryBuilder Self => this;

        public OrderCreateMandatePaymentJobResultQueryBuilder() : this("orderCreateMandatePaymentJobResult")
        {
        }

        public OrderCreateMandatePaymentJobResultQueryBuilder(string name) : base(new Query<OrderCreateMandatePaymentJobResult>(name))
        {
        }

        public OrderCreateMandatePaymentJobResultQueryBuilder(IQuery<OrderCreateMandatePaymentJobResult> query) : base(query)
        {
        }

        public OrderCreateMandatePaymentJobResultQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public OrderCreateMandatePaymentJobResultQueryBuilder Errors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("errors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }

        public OrderCreateMandatePaymentJobResultQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public OrderCreateMandatePaymentJobResultQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderCreateMandatePaymentJobResultQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}