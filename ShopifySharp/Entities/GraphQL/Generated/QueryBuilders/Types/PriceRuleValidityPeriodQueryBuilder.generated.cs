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
    public sealed class PriceRuleValidityPeriodQueryBuilder : FieldsQueryBuilderBase<PriceRuleValidityPeriod, PriceRuleValidityPeriodQueryBuilder>
    {
        protected override PriceRuleValidityPeriodQueryBuilder Self => this;

        public PriceRuleValidityPeriodQueryBuilder() : this("priceRuleValidityPeriod")
        {
        }

        public PriceRuleValidityPeriodQueryBuilder(string name) : base(new Query<PriceRuleValidityPeriod>(name))
        {
        }

        public PriceRuleValidityPeriodQueryBuilder(IQuery<PriceRuleValidityPeriod> query) : base(query)
        {
        }

        public PriceRuleValidityPeriodQueryBuilder End()
        {
            base.InnerQuery.AddField("end");
            return this;
        }

        public PriceRuleValidityPeriodQueryBuilder Start()
        {
            base.InnerQuery.AddField("start");
            return this;
        }
    }
}