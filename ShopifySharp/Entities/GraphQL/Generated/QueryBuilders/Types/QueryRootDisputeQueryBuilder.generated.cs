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
    public sealed class QueryRootDisputeQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDispute, QueryRootDisputeQueryBuilder>, IHasArguments<QueryRootDisputeArgumentsBuilder>
    {
        public QueryRootDisputeArgumentsBuilder Arguments { get; }
        protected override QueryRootDisputeQueryBuilder Self => this;

        public QueryRootDisputeQueryBuilder(string name) : base(new Query<ShopifyPaymentsDispute>(name))
        {
            Arguments = new QueryRootDisputeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDisputeQueryBuilder(IQuery<ShopifyPaymentsDispute> query) : base(query)
        {
            Arguments = new QueryRootDisputeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDisputeQueryBuilder SetArguments(Action<QueryRootDisputeArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDisputeQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootDisputeQueryBuilder DisputeEvidence(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeEvidence>("disputeEvidence");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeEvidenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeEvidence>(query);
            return this;
        }

        public QueryRootDisputeQueryBuilder EvidenceDueBy()
        {
            base.InnerQuery.AddField("evidenceDueBy");
            return this;
        }

        public QueryRootDisputeQueryBuilder EvidenceSentOn()
        {
            base.InnerQuery.AddField("evidenceSentOn");
            return this;
        }

        public QueryRootDisputeQueryBuilder FinalizedOn()
        {
            base.InnerQuery.AddField("finalizedOn");
            return this;
        }

        public QueryRootDisputeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootDisputeQueryBuilder InitiatedAt()
        {
            base.InnerQuery.AddField("initiatedAt");
            return this;
        }

        public QueryRootDisputeQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public QueryRootDisputeQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public QueryRootDisputeQueryBuilder ReasonDetails(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeReasonDetailsQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsDisputeReasonDetails>("reasonDetails");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsDisputeReasonDetailsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsDisputeReasonDetails>(query);
            return this;
        }

        public QueryRootDisputeQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public QueryRootDisputeQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}