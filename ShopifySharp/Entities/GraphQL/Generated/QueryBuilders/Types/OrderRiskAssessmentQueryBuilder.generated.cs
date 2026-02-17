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
    public sealed class OrderRiskAssessmentQueryBuilder : FieldsQueryBuilderBase<OrderRiskAssessment, OrderRiskAssessmentQueryBuilder>
    {
        protected override OrderRiskAssessmentQueryBuilder Self => this;

        public OrderRiskAssessmentQueryBuilder() : this("orderRiskAssessment")
        {
        }

        public OrderRiskAssessmentQueryBuilder(string name) : base(new Query<OrderRiskAssessment>(name))
        {
        }

        public OrderRiskAssessmentQueryBuilder(IQuery<OrderRiskAssessment> query) : base(query)
        {
        }

        public OrderRiskAssessmentQueryBuilder Facts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RiskFactQueryBuilder> build)
        {
            var query = new Query<RiskFact>("facts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RiskFactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RiskFact>(query);
            return this;
        }

        public OrderRiskAssessmentQueryBuilder Provider(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("provider");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public OrderRiskAssessmentQueryBuilder RiskLevel()
        {
            base.InnerQuery.AddField("riskLevel");
            return this;
        }
    }
}