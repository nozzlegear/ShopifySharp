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
    public sealed class CalculatedAutomaticDiscountApplicationQueryBuilder : FieldsQueryBuilderBase<CalculatedAutomaticDiscountApplication, CalculatedAutomaticDiscountApplicationQueryBuilder>
    {
        protected override CalculatedAutomaticDiscountApplicationQueryBuilder Self => this;

        public CalculatedAutomaticDiscountApplicationQueryBuilder() : this("calculatedAutomaticDiscountApplication")
        {
        }

        public CalculatedAutomaticDiscountApplicationQueryBuilder(string name) : base(new Query<CalculatedAutomaticDiscountApplication>(name))
        {
        }

        public CalculatedAutomaticDiscountApplicationQueryBuilder(IQuery<CalculatedAutomaticDiscountApplication> query) : base(query)
        {
        }

        public CalculatedAutomaticDiscountApplicationQueryBuilder AllocationMethod()
        {
            base.InnerQuery.AddField("allocationMethod");
            return this;
        }

        public CalculatedAutomaticDiscountApplicationQueryBuilder AppliedTo()
        {
            base.InnerQuery.AddField("appliedTo");
            return this;
        }

        public CalculatedAutomaticDiscountApplicationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public CalculatedAutomaticDiscountApplicationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CalculatedAutomaticDiscountApplicationQueryBuilder TargetSelection()
        {
            base.InnerQuery.AddField("targetSelection");
            return this;
        }

        public CalculatedAutomaticDiscountApplicationQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public CalculatedAutomaticDiscountApplicationQueryBuilder Value(Action<PricingValueUnionCasesBuilder> build)
        {
            var query = new Query<PricingValue>("value");
            var unionBuilder = new PricingValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}