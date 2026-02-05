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
    public sealed class CalculatedManualDiscountApplicationQueryBuilder : FieldsQueryBuilderBase<CalculatedManualDiscountApplication, CalculatedManualDiscountApplicationQueryBuilder>
    {
        protected override CalculatedManualDiscountApplicationQueryBuilder Self => this;

        public CalculatedManualDiscountApplicationQueryBuilder() : this("calculatedManualDiscountApplication")
        {
        }

        public CalculatedManualDiscountApplicationQueryBuilder(string name) : base(new Query<CalculatedManualDiscountApplication>(name))
        {
        }

        public CalculatedManualDiscountApplicationQueryBuilder(IQuery<CalculatedManualDiscountApplication> query) : base(query)
        {
        }

        public CalculatedManualDiscountApplicationQueryBuilder AllocationMethod()
        {
            base.InnerQuery.AddField("allocationMethod");
            return this;
        }

        public CalculatedManualDiscountApplicationQueryBuilder AppliedTo()
        {
            base.InnerQuery.AddField("appliedTo");
            return this;
        }

        public CalculatedManualDiscountApplicationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public CalculatedManualDiscountApplicationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CalculatedManualDiscountApplicationQueryBuilder TargetSelection()
        {
            base.InnerQuery.AddField("targetSelection");
            return this;
        }

        public CalculatedManualDiscountApplicationQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public CalculatedManualDiscountApplicationQueryBuilder Value(Action<PricingValueUnionCasesBuilder> build)
        {
            var query = new Query<PricingValue>("value");
            var unionBuilder = new PricingValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}