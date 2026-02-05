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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class RefundOperationQueryBuilder : FieldsQueryBuilderBase<Refund, RefundOperationQueryBuilder>, IGraphOperationQueryBuilder<Refund>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public RefundArgumentsBuilder Arguments { get; }
        protected override RefundOperationQueryBuilder Self => this;

        public RefundOperationQueryBuilder() : this("refund")
        {
        }

        public RefundOperationQueryBuilder(string name) : base(new Query<Refund>(name))
        {
            Arguments = new RefundArgumentsBuilder(base.InnerQuery);
        }

        public RefundOperationQueryBuilder(IQuery<Refund> query) : base(query)
        {
            Arguments = new RefundArgumentsBuilder(base.InnerQuery);
        }

        public RefundOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public RefundOperationQueryBuilder Duties(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundDutyQueryBuilder> build)
        {
            var query = new Query<RefundDuty>("duties");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundDutyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundDuty>(query);
            return this;
        }

        public RefundOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public RefundOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public RefundOperationQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public RefundOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public RefundOperationQueryBuilder OrderAdjustments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAdjustmentConnectionQueryBuilder> build)
        {
            var query = new Query<OrderAdjustmentConnection>("orderAdjustments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderAdjustmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderAdjustmentConnection>(query);
            return this;
        }

        public RefundOperationQueryBuilder ProcessedAt()
        {
            base.InnerQuery.AddField("processedAt");
            return this;
        }

        public RefundOperationQueryBuilder RefundLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<RefundLineItemConnection>("refundLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundLineItemConnection>(query);
            return this;
        }

        public RefundOperationQueryBuilder RefundShippingLines(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundShippingLineConnectionQueryBuilder> build)
        {
            var query = new Query<RefundShippingLineConnection>("refundShippingLines");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundShippingLineConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundShippingLineConnection>(query);
            return this;
        }

        public RefundOperationQueryBuilder Return(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public RefundOperationQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public RefundOperationQueryBuilder TotalRefunded(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalRefunded");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public RefundOperationQueryBuilder TotalRefundedSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalRefundedSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public RefundOperationQueryBuilder Transactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<OrderTransactionConnection>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransactionConnection>(query);
            return this;
        }

        public RefundOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}