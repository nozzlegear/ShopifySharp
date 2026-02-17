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
    public sealed class OrderRiskAssessmentCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderRiskAssessmentCreateUserError, OrderRiskAssessmentCreateUserErrorQueryBuilder>
    {
        protected override OrderRiskAssessmentCreateUserErrorQueryBuilder Self => this;

        public OrderRiskAssessmentCreateUserErrorQueryBuilder() : this("orderRiskAssessmentCreateUserError")
        {
        }

        public OrderRiskAssessmentCreateUserErrorQueryBuilder(string name) : base(new Query<OrderRiskAssessmentCreateUserError>(name))
        {
        }

        public OrderRiskAssessmentCreateUserErrorQueryBuilder(IQuery<OrderRiskAssessmentCreateUserError> query) : base(query)
        {
        }

        public OrderRiskAssessmentCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderRiskAssessmentCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderRiskAssessmentCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}