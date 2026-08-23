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

        public CalculatedDiscountApplicationQueryBuilder OnCalculatedAutomaticDiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedAutomaticDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<CalculatedAutomaticDiscountApplication>("... on CalculatedAutomaticDiscountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedAutomaticDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CalculatedDiscountApplicationQueryBuilder OnCalculatedDiscountCodeApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDiscountCodeApplicationQueryBuilder> build)
        {
            var query = new Query<CalculatedDiscountCodeApplication>("... on CalculatedDiscountCodeApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDiscountCodeApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CalculatedDiscountApplicationQueryBuilder OnCalculatedManualDiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedManualDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<CalculatedManualDiscountApplication>("... on CalculatedManualDiscountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedManualDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CalculatedDiscountApplicationQueryBuilder OnCalculatedScriptDiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedScriptDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<CalculatedScriptDiscountApplication>("... on CalculatedScriptDiscountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedScriptDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
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

        public CalculatedDiscountApplicationQueryBuilder CalculatedDiscountApplication(Action<CalculatedDiscountApplicationInterfaceCasesBuilder> build)
        {
            var query = new Query<ICalculatedDiscountApplication>("calculatedDiscountApplication");
            var unionBuilder = new CalculatedDiscountApplicationInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}