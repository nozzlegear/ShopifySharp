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
    public sealed class RiskFactQueryBuilder : FieldsQueryBuilderBase<RiskFact, RiskFactQueryBuilder>
    {
        protected override RiskFactQueryBuilder Self => this;

        public RiskFactQueryBuilder() : this("riskFact")
        {
        }

        public RiskFactQueryBuilder(string name) : base(new Query<RiskFact>(name))
        {
        }

        public RiskFactQueryBuilder(IQuery<RiskFact> query) : base(query)
        {
        }

        public RiskFactQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public RiskFactQueryBuilder Sentiment()
        {
            base.InnerQuery.AddField("sentiment");
            return this;
        }
    }
}