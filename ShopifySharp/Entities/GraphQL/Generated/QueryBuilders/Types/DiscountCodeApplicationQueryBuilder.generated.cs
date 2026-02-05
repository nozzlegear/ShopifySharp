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
    public sealed class DiscountCodeApplicationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeApplication, DiscountCodeApplicationQueryBuilder>
    {
        protected override DiscountCodeApplicationQueryBuilder Self => this;

        public DiscountCodeApplicationQueryBuilder() : this("discountCodeApplication")
        {
        }

        public DiscountCodeApplicationQueryBuilder(string name) : base(new Query<DiscountCodeApplication>(name))
        {
        }

        public DiscountCodeApplicationQueryBuilder(IQuery<DiscountCodeApplication> query) : base(query)
        {
        }

        public DiscountCodeApplicationQueryBuilder AllocationMethod()
        {
            base.InnerQuery.AddField("allocationMethod");
            return this;
        }

        public DiscountCodeApplicationQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public DiscountCodeApplicationQueryBuilder Index()
        {
            base.InnerQuery.AddField("index");
            return this;
        }

        public DiscountCodeApplicationQueryBuilder TargetSelection()
        {
            base.InnerQuery.AddField("targetSelection");
            return this;
        }

        public DiscountCodeApplicationQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public DiscountCodeApplicationQueryBuilder Value(Action<PricingValueUnionCasesBuilder> build)
        {
            var query = new Query<PricingValue>("value");
            var unionBuilder = new PricingValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}