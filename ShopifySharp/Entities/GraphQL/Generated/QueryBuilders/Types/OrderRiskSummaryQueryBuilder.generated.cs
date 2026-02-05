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
    public sealed class OrderRiskSummaryQueryBuilder : FieldsQueryBuilderBase<OrderRiskSummary, OrderRiskSummaryQueryBuilder>
    {
        protected override OrderRiskSummaryQueryBuilder Self => this;

        public OrderRiskSummaryQueryBuilder() : this("orderRiskSummary")
        {
        }

        public OrderRiskSummaryQueryBuilder(string name) : base(new Query<OrderRiskSummary>(name))
        {
        }

        public OrderRiskSummaryQueryBuilder(IQuery<OrderRiskSummary> query) : base(query)
        {
        }

        public OrderRiskSummaryQueryBuilder Assessments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskAssessmentQueryBuilder> build)
        {
            var query = new Query<OrderRiskAssessment>("assessments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskAssessmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderRiskAssessment>(query);
            return this;
        }

        public OrderRiskSummaryQueryBuilder Recommendation()
        {
            base.InnerQuery.AddField("recommendation");
            return this;
        }
    }
}