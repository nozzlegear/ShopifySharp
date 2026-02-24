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
    public sealed class MetafieldReferenceRisksQueryBuilder : FieldsQueryBuilderBase<OrderRisk, MetafieldReferenceRisksQueryBuilder>, IHasArguments<MetafieldReferenceRisksArgumentsBuilder>
    {
        public MetafieldReferenceRisksArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceRisksQueryBuilder Self => this;

        public MetafieldReferenceRisksQueryBuilder(string name) : base(new Query<OrderRisk>(name))
        {
            Arguments = new MetafieldReferenceRisksArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceRisksQueryBuilder(IQuery<OrderRisk> query) : base(query)
        {
            Arguments = new MetafieldReferenceRisksArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceRisksQueryBuilder SetArguments(Action<MetafieldReferenceRisksArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
        public MetafieldReferenceRisksQueryBuilder Display()
        {
            base.InnerQuery.AddField("display");
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.riskLevel which allows for more granular risk levels, including PENDING and NONE.")]
        public MetafieldReferenceRisksQueryBuilder Level()
        {
            base.InnerQuery.AddField("level");
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
        public MetafieldReferenceRisksQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}