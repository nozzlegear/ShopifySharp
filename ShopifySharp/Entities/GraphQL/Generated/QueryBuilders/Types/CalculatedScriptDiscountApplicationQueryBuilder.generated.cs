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
    public sealed class CalculatedScriptDiscountApplicationQueryBuilder : FieldsQueryBuilderBase<CalculatedScriptDiscountApplication, CalculatedScriptDiscountApplicationQueryBuilder>
    {
        protected override CalculatedScriptDiscountApplicationQueryBuilder Self => this;

        public CalculatedScriptDiscountApplicationQueryBuilder() : this("calculatedScriptDiscountApplication")
        {
        }

        public CalculatedScriptDiscountApplicationQueryBuilder(string name) : base(new Query<CalculatedScriptDiscountApplication>(name))
        {
        }

        public CalculatedScriptDiscountApplicationQueryBuilder(IQuery<CalculatedScriptDiscountApplication> query) : base(query)
        {
        }

        public CalculatedScriptDiscountApplicationQueryBuilder AllocationMethod()
        {
            base.InnerQuery.AddField("allocationMethod");
            return this;
        }

        public CalculatedScriptDiscountApplicationQueryBuilder AppliedTo()
        {
            base.InnerQuery.AddField("appliedTo");
            return this;
        }

        public CalculatedScriptDiscountApplicationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public CalculatedScriptDiscountApplicationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CalculatedScriptDiscountApplicationQueryBuilder TargetSelection()
        {
            base.InnerQuery.AddField("targetSelection");
            return this;
        }

        public CalculatedScriptDiscountApplicationQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public CalculatedScriptDiscountApplicationQueryBuilder Value(Action<PricingValueUnionCasesBuilder> build)
        {
            var query = new Query<PricingValue>("value");
            var unionBuilder = new PricingValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}