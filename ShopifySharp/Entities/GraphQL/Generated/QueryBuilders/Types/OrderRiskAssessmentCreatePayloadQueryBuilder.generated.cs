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
    public sealed class OrderRiskAssessmentCreatePayloadQueryBuilder : FieldsQueryBuilderBase<OrderRiskAssessmentCreatePayload, OrderRiskAssessmentCreatePayloadQueryBuilder>
    {
        protected override OrderRiskAssessmentCreatePayloadQueryBuilder Self => this;

        public OrderRiskAssessmentCreatePayloadQueryBuilder() : this("orderRiskAssessmentCreatePayload")
        {
        }

        public OrderRiskAssessmentCreatePayloadQueryBuilder(string name) : base(new Query<OrderRiskAssessmentCreatePayload>(name))
        {
        }

        public OrderRiskAssessmentCreatePayloadQueryBuilder(IQuery<OrderRiskAssessmentCreatePayload> query) : base(query)
        {
        }

        public OrderRiskAssessmentCreatePayloadQueryBuilder OrderRiskAssessment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskAssessmentQueryBuilder> build)
        {
            var query = new Query<OrderRiskAssessment>("orderRiskAssessment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskAssessmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderRiskAssessment>(query);
            return this;
        }

        public OrderRiskAssessmentCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskAssessmentCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderRiskAssessmentCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskAssessmentCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderRiskAssessmentCreateUserError>(query);
            return this;
        }
    }
}