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
    public sealed class OrderRiskQueryBuilder : FieldsQueryBuilderBase<OrderRisk, OrderRiskQueryBuilder>
    {
        protected override OrderRiskQueryBuilder Self => this;

        public OrderRiskQueryBuilder() : this("orderRisk")
        {
        }

        public OrderRiskQueryBuilder(string name) : base(new Query<OrderRisk>(name))
        {
        }

        public OrderRiskQueryBuilder(IQuery<OrderRisk> query) : base(query)
        {
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
        public OrderRiskQueryBuilder Display()
        {
            base.InnerQuery.AddField("display");
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.riskLevel which allows for more granular risk levels, including PENDING and NONE.")]
        public OrderRiskQueryBuilder Level()
        {
            base.InnerQuery.AddField("level");
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
        public OrderRiskQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}