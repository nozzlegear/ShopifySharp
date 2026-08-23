#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
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

        public DiscountApplicationQueryBuilder OnAutomaticDiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AutomaticDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<AutomaticDiscountApplication>("... on AutomaticDiscountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AutomaticDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public DiscountApplicationQueryBuilder OnDiscountCodeApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeApplicationQueryBuilder> build)
        {
            var query = new Query<DiscountCodeApplication>("... on DiscountCodeApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public DiscountApplicationQueryBuilder OnManualDiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ManualDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<ManualDiscountApplication>("... on ManualDiscountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ManualDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public DiscountApplicationQueryBuilder OnScriptDiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ScriptDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<ScriptDiscountApplication>("... on ScriptDiscountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ScriptDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
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

        public DiscountApplicationQueryBuilder DiscountApplication(Action<DiscountApplicationInterfaceCasesBuilder> build)
        {
            var query = new Query<IDiscountApplication>("discountApplication");
            var unionBuilder = new DiscountApplicationInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}