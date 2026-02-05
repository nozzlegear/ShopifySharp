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
    public sealed class OrderRiskAssessmentCreateArgumentsBuilder : ArgumentsBuilderBase<OrderRiskAssessmentCreatePayload, OrderRiskAssessmentCreateArgumentsBuilder>
    {
        protected override OrderRiskAssessmentCreateArgumentsBuilder Self => this;

        public OrderRiskAssessmentCreateArgumentsBuilder(IQuery<OrderRiskAssessmentCreatePayload> query) : base(query)
        {
        }

        public OrderRiskAssessmentCreateArgumentsBuilder OrderRiskAssessmentInput(OrderRiskAssessmentCreateInput? orderRiskAssessmentInput)
        {
            base.InnerQuery.AddArgument("orderRiskAssessmentInput", orderRiskAssessmentInput);
            return this;
        }
    }
}