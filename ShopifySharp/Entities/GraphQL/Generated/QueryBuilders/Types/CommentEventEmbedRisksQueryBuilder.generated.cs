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
    public sealed class CommentEventEmbedRisksQueryBuilder : FieldsQueryBuilderBase<OrderRisk, CommentEventEmbedRisksQueryBuilder>, IHasArguments<CommentEventEmbedRisksArgumentsBuilder>
    {
        public CommentEventEmbedRisksArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedRisksQueryBuilder Self => this;

        public CommentEventEmbedRisksQueryBuilder(string name) : base(new Query<OrderRisk>(name))
        {
            Arguments = new CommentEventEmbedRisksArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedRisksQueryBuilder(IQuery<OrderRisk> query) : base(query)
        {
            Arguments = new CommentEventEmbedRisksArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedRisksQueryBuilder SetArguments(Action<CommentEventEmbedRisksArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
        public CommentEventEmbedRisksQueryBuilder Display()
        {
            base.InnerQuery.AddField("display");
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.riskLevel which allows for more granular risk levels, including PENDING and NONE.")]
        public CommentEventEmbedRisksQueryBuilder Level()
        {
            base.InnerQuery.AddField("level");
            return this;
        }

        [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
        public CommentEventEmbedRisksQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}