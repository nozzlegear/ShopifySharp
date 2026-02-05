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
    public sealed class DiscountApplicationQueryBuilder : FieldsQueryBuilderBase<IDiscountApplication, DiscountApplicationQueryBuilder>
    {
        protected override DiscountApplicationQueryBuilder Self => this;

        public DiscountApplicationQueryBuilder() : this("discountApplication")
        {
        }

        public DiscountApplicationQueryBuilder(string name) : base(new Query<IDiscountApplication>(name))
        {
        }

        public DiscountApplicationQueryBuilder(IQuery<IDiscountApplication> query) : base(query)
        {
        }

        public DiscountApplicationQueryBuilder AllocationMethod()
        {
            base.InnerQuery.AddField("allocationMethod");
            return this;
        }

        public DiscountApplicationQueryBuilder Index()
        {
            base.InnerQuery.AddField("index");
            return this;
        }

        public DiscountApplicationQueryBuilder TargetSelection()
        {
            base.InnerQuery.AddField("targetSelection");
            return this;
        }

        public DiscountApplicationQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public DiscountApplicationQueryBuilder Value(Action<PricingValueUnionCasesBuilder> build)
        {
            var query = new Query<PricingValue>("value");
            var unionBuilder = new PricingValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}