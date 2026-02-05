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
    public sealed class ManualDiscountApplicationQueryBuilder : FieldsQueryBuilderBase<ManualDiscountApplication, ManualDiscountApplicationQueryBuilder>
    {
        protected override ManualDiscountApplicationQueryBuilder Self => this;

        public ManualDiscountApplicationQueryBuilder() : this("manualDiscountApplication")
        {
        }

        public ManualDiscountApplicationQueryBuilder(string name) : base(new Query<ManualDiscountApplication>(name))
        {
        }

        public ManualDiscountApplicationQueryBuilder(IQuery<ManualDiscountApplication> query) : base(query)
        {
        }

        public ManualDiscountApplicationQueryBuilder AllocationMethod()
        {
            base.InnerQuery.AddField("allocationMethod");
            return this;
        }

        public ManualDiscountApplicationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public ManualDiscountApplicationQueryBuilder Index()
        {
            base.InnerQuery.AddField("index");
            return this;
        }

        public ManualDiscountApplicationQueryBuilder TargetSelection()
        {
            base.InnerQuery.AddField("targetSelection");
            return this;
        }

        public ManualDiscountApplicationQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public ManualDiscountApplicationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public ManualDiscountApplicationQueryBuilder Value(Action<PricingValueUnionCasesBuilder> build)
        {
            var query = new Query<PricingValue>("value");
            var unionBuilder = new PricingValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}