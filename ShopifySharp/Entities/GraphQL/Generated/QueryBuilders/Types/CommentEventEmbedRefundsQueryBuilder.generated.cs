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
    public sealed class CommentEventEmbedRefundsQueryBuilder : FieldsQueryBuilderBase<Refund, CommentEventEmbedRefundsQueryBuilder>, IHasArguments<CommentEventEmbedRefundsArgumentsBuilder>
    {
        public CommentEventEmbedRefundsArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedRefundsQueryBuilder Self => this;

        public CommentEventEmbedRefundsQueryBuilder(string name) : base(new Query<Refund>(name))
        {
            Arguments = new CommentEventEmbedRefundsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedRefundsQueryBuilder(IQuery<Refund> query) : base(query)
        {
            Arguments = new CommentEventEmbedRefundsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedRefundsQueryBuilder SetArguments(Action<CommentEventEmbedRefundsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder Duties(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundDutyQueryBuilder> build)
        {
            var query = new Query<RefundDuty>("duties");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundDutyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundDuty>(query);
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder OrderAdjustments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAdjustmentConnectionQueryBuilder> build)
        {
            var query = new Query<OrderAdjustmentConnection>("orderAdjustments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAdjustmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAdjustmentConnection>(query);
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder ProcessedAt()
        {
            base.InnerQuery.AddField("processedAt");
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder RefundLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<RefundLineItemConnection>("refundLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundLineItemConnection>(query);
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder RefundShippingLines(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineConnectionQueryBuilder> build)
        {
            var query = new Query<RefundShippingLineConnection>("refundShippingLines");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundShippingLineConnection>(query);
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder Return(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder TotalRefunded(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalRefunded");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder TotalRefundedSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalRefundedSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder Transactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<OrderTransactionConnection>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransactionConnection>(query);
            return this;
        }

        public CommentEventEmbedRefundsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}