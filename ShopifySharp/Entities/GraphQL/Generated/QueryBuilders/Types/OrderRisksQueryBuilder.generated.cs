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
    public sealed class OrderRisksQueryBuilder : FieldsQueryBuilderBase<OrderRisk, OrderRisksQueryBuilder>, IHasArguments<OrderRisksArgumentsBuilder>
    {
        public OrderRisksArgumentsBuilder Arguments { get; }
        protected override OrderRisksQueryBuilder Self => this;

        public OrderRisksQueryBuilder(string name) : base(new Query<OrderRisk>(name))
        {
            Arguments = new OrderRisksArgumentsBuilder(base.InnerQuery);
        }

        public OrderRisksQueryBuilder(IQuery<OrderRisk> query) : base(query)
        {
            Arguments = new OrderRisksArgumentsBuilder(base.InnerQuery);
        }

        public OrderRisksQueryBuilder SetArguments(Action<OrderRisksArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
        public OrderRisksQueryBuilder Display()
        {
            base.InnerQuery.AddField("display");
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.riskLevel which allows for more granular risk levels, including PENDING and NONE.")]
        public OrderRisksQueryBuilder Level()
        {
            base.InnerQuery.AddField("level");
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
        public OrderRisksQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}