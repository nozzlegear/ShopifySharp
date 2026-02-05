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
    public sealed class OrderRiskAssessmentCreateOperationQueryBuilder : FieldsQueryBuilderBase<OrderRiskAssessmentCreatePayload, OrderRiskAssessmentCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderRiskAssessmentCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderRiskAssessmentCreateArgumentsBuilder Arguments { get; }
        protected override OrderRiskAssessmentCreateOperationQueryBuilder Self => this;

        public OrderRiskAssessmentCreateOperationQueryBuilder() : this("orderRiskAssessmentCreate")
        {
        }

        public OrderRiskAssessmentCreateOperationQueryBuilder(string name) : base(new Query<OrderRiskAssessmentCreatePayload>(name))
        {
            Arguments = new OrderRiskAssessmentCreateArgumentsBuilder(base.InnerQuery);
        }

        public OrderRiskAssessmentCreateOperationQueryBuilder(IQuery<OrderRiskAssessmentCreatePayload> query) : base(query)
        {
            Arguments = new OrderRiskAssessmentCreateArgumentsBuilder(base.InnerQuery);
        }

        public OrderRiskAssessmentCreateOperationQueryBuilder OrderRiskAssessment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskAssessmentQueryBuilder> build)
        {
            var query = new Query<OrderRiskAssessment>("orderRiskAssessment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskAssessmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderRiskAssessment>(query);
            return this;
        }

        public OrderRiskAssessmentCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskAssessmentCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderRiskAssessmentCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderRiskAssessmentCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderRiskAssessmentCreateUserError>(query);
            return this;
        }
    }
}