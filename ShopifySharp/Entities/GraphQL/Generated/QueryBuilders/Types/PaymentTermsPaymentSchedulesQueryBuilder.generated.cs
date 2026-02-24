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
    public sealed class PaymentTermsPaymentSchedulesQueryBuilder : FieldsQueryBuilderBase<PaymentScheduleConnection, PaymentTermsPaymentSchedulesQueryBuilder>, IHasArguments<PaymentTermsPaymentSchedulesArgumentsBuilder>
    {
        public PaymentTermsPaymentSchedulesArgumentsBuilder Arguments { get; }
        protected override PaymentTermsPaymentSchedulesQueryBuilder Self => this;

        public PaymentTermsPaymentSchedulesQueryBuilder(string name) : base(new Query<PaymentScheduleConnection>(name))
        {
            Arguments = new PaymentTermsPaymentSchedulesArgumentsBuilder(base.InnerQuery);
        }

        public PaymentTermsPaymentSchedulesQueryBuilder(IQuery<PaymentScheduleConnection> query) : base(query)
        {
            Arguments = new PaymentTermsPaymentSchedulesArgumentsBuilder(base.InnerQuery);
        }

        public PaymentTermsPaymentSchedulesQueryBuilder SetArguments(Action<PaymentTermsPaymentSchedulesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PaymentTermsPaymentSchedulesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentScheduleEdgeQueryBuilder> build)
        {
            var query = new Query<PaymentScheduleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentScheduleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentScheduleEdge>(query);
            return this;
        }

        public PaymentTermsPaymentSchedulesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentScheduleQueryBuilder> build)
        {
            var query = new Query<PaymentSchedule>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentScheduleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentSchedule>(query);
            return this;
        }

        public PaymentTermsPaymentSchedulesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}