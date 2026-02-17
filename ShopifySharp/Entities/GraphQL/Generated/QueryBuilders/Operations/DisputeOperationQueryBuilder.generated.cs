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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DisputeOperationQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDispute, DisputeOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopifyPaymentsDispute>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DisputeArgumentsBuilder Arguments { get; }
        protected override DisputeOperationQueryBuilder Self => this;

        public DisputeOperationQueryBuilder() : this("dispute")
        {
        }

        public DisputeOperationQueryBuilder(string name) : base(new Query<ShopifyPaymentsDispute>(name))
        {
            Arguments = new DisputeArgumentsBuilder(base.InnerQuery);
        }

        public DisputeOperationQueryBuilder(IQuery<ShopifyPaymentsDispute> query) : base(query)
        {
            Arguments = new DisputeArgumentsBuilder(base.InnerQuery);
        }

        public DisputeOperationQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DisputeOperationQueryBuilder DisputeEvidence(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeEvidence>("disputeEvidence");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeEvidence>(query);
            return this;
        }

        public DisputeOperationQueryBuilder EvidenceDueBy()
        {
            base.InnerQuery.AddField("evidenceDueBy");
            return this;
        }

        public DisputeOperationQueryBuilder EvidenceSentOn()
        {
            base.InnerQuery.AddField("evidenceSentOn");
            return this;
        }

        public DisputeOperationQueryBuilder FinalizedOn()
        {
            base.InnerQuery.AddField("finalizedOn");
            return this;
        }

        public DisputeOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DisputeOperationQueryBuilder InitiatedAt()
        {
            base.InnerQuery.AddField("initiatedAt");
            return this;
        }

        public DisputeOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public DisputeOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public DisputeOperationQueryBuilder ReasonDetails(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeReasonDetailsQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeReasonDetails>("reasonDetails");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeReasonDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeReasonDetails>(query);
            return this;
        }

        public DisputeOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public DisputeOperationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}