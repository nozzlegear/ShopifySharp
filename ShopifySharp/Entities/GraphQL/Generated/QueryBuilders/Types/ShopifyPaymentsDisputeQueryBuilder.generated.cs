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
    public sealed class ShopifyPaymentsDisputeQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDispute, ShopifyPaymentsDisputeQueryBuilder>
    {
        protected override ShopifyPaymentsDisputeQueryBuilder Self => this;

        public ShopifyPaymentsDisputeQueryBuilder() : this("shopifyPaymentsDispute")
        {
        }

        public ShopifyPaymentsDisputeQueryBuilder(string name) : base(new Query<ShopifyPaymentsDispute>(name))
        {
        }

        public ShopifyPaymentsDisputeQueryBuilder(IQuery<ShopifyPaymentsDispute> query) : base(query)
        {
        }

        public ShopifyPaymentsDisputeQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsDisputeQueryBuilder DisputeEvidence(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeEvidence>("disputeEvidence");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeEvidence>(query);
            return this;
        }

        public ShopifyPaymentsDisputeQueryBuilder EvidenceDueBy()
        {
            base.InnerQuery.AddField("evidenceDueBy");
            return this;
        }

        public ShopifyPaymentsDisputeQueryBuilder EvidenceSentOn()
        {
            base.InnerQuery.AddField("evidenceSentOn");
            return this;
        }

        public ShopifyPaymentsDisputeQueryBuilder FinalizedOn()
        {
            base.InnerQuery.AddField("finalizedOn");
            return this;
        }

        public ShopifyPaymentsDisputeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopifyPaymentsDisputeQueryBuilder InitiatedAt()
        {
            base.InnerQuery.AddField("initiatedAt");
            return this;
        }

        public ShopifyPaymentsDisputeQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public ShopifyPaymentsDisputeQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public ShopifyPaymentsDisputeQueryBuilder ReasonDetails(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeReasonDetailsQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeReasonDetails>("reasonDetails");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeReasonDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeReasonDetails>(query);
            return this;
        }

        public ShopifyPaymentsDisputeQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ShopifyPaymentsDisputeQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}