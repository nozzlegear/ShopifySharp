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
    public sealed class CalculatedDiscountApplicationQueryBuilder : FieldsQueryBuilderBase<ICalculatedDiscountApplication, CalculatedDiscountApplicationQueryBuilder>
    {
        protected override CalculatedDiscountApplicationQueryBuilder Self => this;

        public CalculatedDiscountApplicationQueryBuilder() : this("calculatedDiscountApplication")
        {
        }

        public CalculatedDiscountApplicationQueryBuilder(string name) : base(new Query<ICalculatedDiscountApplication>(name))
        {
        }

        public CalculatedDiscountApplicationQueryBuilder(IQuery<ICalculatedDiscountApplication> query) : base(query)
        {
        }

        public CalculatedDiscountApplicationQueryBuilder AllocationMethod()
        {
            base.InnerQuery.AddField("allocationMethod");
            return this;
        }

        public CalculatedDiscountApplicationQueryBuilder AppliedTo()
        {
            base.InnerQuery.AddField("appliedTo");
            return this;
        }

        public CalculatedDiscountApplicationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public CalculatedDiscountApplicationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CalculatedDiscountApplicationQueryBuilder TargetSelection()
        {
            base.InnerQuery.AddField("targetSelection");
            return this;
        }

        public CalculatedDiscountApplicationQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public CalculatedDiscountApplicationQueryBuilder Value(Action<PricingValueUnionCasesBuilder> build)
        {
            var query = new Query<PricingValue>("value");
            var unionBuilder = new PricingValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}