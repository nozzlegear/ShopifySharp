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
    public sealed class PaymentTermsQueryBuilder : FieldsQueryBuilderBase<PaymentTerms, PaymentTermsQueryBuilder>
    {
        protected override PaymentTermsQueryBuilder Self => this;

        public PaymentTermsQueryBuilder() : this("paymentTerms")
        {
        }

        public PaymentTermsQueryBuilder(string name) : base(new Query<PaymentTerms>(name))
        {
        }

        public PaymentTermsQueryBuilder(IQuery<PaymentTerms> query) : base(query)
        {
        }

        public PaymentTermsQueryBuilder DraftOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("draftOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public PaymentTermsQueryBuilder Due()
        {
            base.InnerQuery.AddField("due");
            return this;
        }

        public PaymentTermsQueryBuilder DueInDays()
        {
            base.InnerQuery.AddField("dueInDays");
            return this;
        }

        public PaymentTermsQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PaymentTermsQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public PaymentTermsQueryBuilder Overdue()
        {
            base.InnerQuery.AddField("overdue");
            return this;
        }

        public PaymentTermsQueryBuilder PaymentSchedules(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentScheduleConnectionQueryBuilder> build)
        {
            var query = new Query<PaymentScheduleConnection>("paymentSchedules");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentScheduleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentScheduleConnection>(query);
            return this;
        }

        public PaymentTermsQueryBuilder PaymentTermsName()
        {
            base.InnerQuery.AddField("paymentTermsName");
            return this;
        }

        public PaymentTermsQueryBuilder PaymentTermsType()
        {
            base.InnerQuery.AddField("paymentTermsType");
            return this;
        }

        public PaymentTermsQueryBuilder TranslatedName()
        {
            base.InnerQuery.AddField("translatedName");
            return this;
        }
    }
}