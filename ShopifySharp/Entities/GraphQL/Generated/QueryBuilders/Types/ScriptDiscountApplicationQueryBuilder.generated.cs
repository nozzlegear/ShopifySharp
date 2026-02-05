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
    public sealed class ScriptDiscountApplicationQueryBuilder : FieldsQueryBuilderBase<ScriptDiscountApplication, ScriptDiscountApplicationQueryBuilder>
    {
        protected override ScriptDiscountApplicationQueryBuilder Self => this;

        public ScriptDiscountApplicationQueryBuilder() : this("scriptDiscountApplication")
        {
        }

        public ScriptDiscountApplicationQueryBuilder(string name) : base(new Query<ScriptDiscountApplication>(name))
        {
        }

        public ScriptDiscountApplicationQueryBuilder(IQuery<ScriptDiscountApplication> query) : base(query)
        {
        }

        public ScriptDiscountApplicationQueryBuilder AllocationMethod()
        {
            base.InnerQuery.AddField("allocationMethod");
            return this;
        }

        [Obsolete("Use `title` instead.")]
        public ScriptDiscountApplicationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public ScriptDiscountApplicationQueryBuilder Index()
        {
            base.InnerQuery.AddField("index");
            return this;
        }

        public ScriptDiscountApplicationQueryBuilder TargetSelection()
        {
            base.InnerQuery.AddField("targetSelection");
            return this;
        }

        public ScriptDiscountApplicationQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public ScriptDiscountApplicationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public ScriptDiscountApplicationQueryBuilder Value(Action<PricingValueUnionCasesBuilder> build)
        {
            var query = new Query<PricingValue>("value");
            var unionBuilder = new PricingValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}