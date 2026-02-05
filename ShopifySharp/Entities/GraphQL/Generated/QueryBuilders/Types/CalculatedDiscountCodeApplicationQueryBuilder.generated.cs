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
    public sealed class CalculatedDiscountCodeApplicationQueryBuilder : FieldsQueryBuilderBase<CalculatedDiscountCodeApplication, CalculatedDiscountCodeApplicationQueryBuilder>
    {
        protected override CalculatedDiscountCodeApplicationQueryBuilder Self => this;

        public CalculatedDiscountCodeApplicationQueryBuilder() : this("calculatedDiscountCodeApplication")
        {
        }

        public CalculatedDiscountCodeApplicationQueryBuilder(string name) : base(new Query<CalculatedDiscountCodeApplication>(name))
        {
        }

        public CalculatedDiscountCodeApplicationQueryBuilder(IQuery<CalculatedDiscountCodeApplication> query) : base(query)
        {
        }

        public CalculatedDiscountCodeApplicationQueryBuilder AllocationMethod()
        {
            base.InnerQuery.AddField("allocationMethod");
            return this;
        }

        public CalculatedDiscountCodeApplicationQueryBuilder AppliedTo()
        {
            base.InnerQuery.AddField("appliedTo");
            return this;
        }

        public CalculatedDiscountCodeApplicationQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CalculatedDiscountCodeApplicationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public CalculatedDiscountCodeApplicationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CalculatedDiscountCodeApplicationQueryBuilder TargetSelection()
        {
            base.InnerQuery.AddField("targetSelection");
            return this;
        }

        public CalculatedDiscountCodeApplicationQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public CalculatedDiscountCodeApplicationQueryBuilder Value(Action<PricingValueUnionCasesBuilder> build)
        {
            var query = new Query<PricingValue>("value");
            var unionBuilder = new PricingValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}