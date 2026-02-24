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
    public sealed class MetafieldReferencerRisksQueryBuilder : FieldsQueryBuilderBase<OrderRisk, MetafieldReferencerRisksQueryBuilder>, IHasArguments<MetafieldReferencerRisksArgumentsBuilder>
    {
        public MetafieldReferencerRisksArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerRisksQueryBuilder Self => this;

        public MetafieldReferencerRisksQueryBuilder(string name) : base(new Query<OrderRisk>(name))
        {
            Arguments = new MetafieldReferencerRisksArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerRisksQueryBuilder(IQuery<OrderRisk> query) : base(query)
        {
            Arguments = new MetafieldReferencerRisksArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerRisksQueryBuilder SetArguments(Action<MetafieldReferencerRisksArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
        public MetafieldReferencerRisksQueryBuilder Display()
        {
            base.InnerQuery.AddField("display");
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.riskLevel which allows for more granular risk levels, including PENDING and NONE.")]
        public MetafieldReferencerRisksQueryBuilder Level()
        {
            base.InnerQuery.AddField("level");
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
        public MetafieldReferencerRisksQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}