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
    public sealed class AutomaticDiscountApplicationQueryBuilder : FieldsQueryBuilderBase<AutomaticDiscountApplication, AutomaticDiscountApplicationQueryBuilder>
    {
        protected override AutomaticDiscountApplicationQueryBuilder Self => this;

        public AutomaticDiscountApplicationQueryBuilder() : this("automaticDiscountApplication")
        {
        }

        public AutomaticDiscountApplicationQueryBuilder(string name) : base(new Query<AutomaticDiscountApplication>(name))
        {
        }

        public AutomaticDiscountApplicationQueryBuilder(IQuery<AutomaticDiscountApplication> query) : base(query)
        {
        }

        public AutomaticDiscountApplicationQueryBuilder AllocationMethod()
        {
            base.InnerQuery.AddField("allocationMethod");
            return this;
        }

        public AutomaticDiscountApplicationQueryBuilder Index()
        {
            base.InnerQuery.AddField("index");
            return this;
        }

        public AutomaticDiscountApplicationQueryBuilder TargetSelection()
        {
            base.InnerQuery.AddField("targetSelection");
            return this;
        }

        public AutomaticDiscountApplicationQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public AutomaticDiscountApplicationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public AutomaticDiscountApplicationQueryBuilder Value(Action<PricingValueUnionCasesBuilder> build)
        {
            var query = new Query<PricingValue>("value");
            var unionBuilder = new PricingValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}