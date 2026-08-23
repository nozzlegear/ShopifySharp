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
    public sealed class CalculatedDiscountApplicationInterfaceCasesBuilder : InterfaceCasesBuilderBase<ICalculatedDiscountApplication, CalculatedDiscountApplicationInterfaceCasesBuilder>
    {
        protected override CalculatedDiscountApplicationInterfaceCasesBuilder Self => this;

        public CalculatedDiscountApplicationInterfaceCasesBuilder(string fieldName = "node") : this(new Query<ICalculatedDiscountApplication>(fieldName))
        {
        }

        public CalculatedDiscountApplicationInterfaceCasesBuilder(IQuery<ICalculatedDiscountApplication> query) : base(query)
        {
        }

        public CalculatedDiscountApplicationInterfaceCasesBuilder OnCalculatedAutomaticDiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedAutomaticDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<CalculatedAutomaticDiscountApplication>("... on CalculatedAutomaticDiscountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedAutomaticDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CalculatedDiscountApplicationInterfaceCasesBuilder OnCalculatedDiscountCodeApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDiscountCodeApplicationQueryBuilder> build)
        {
            var query = new Query<CalculatedDiscountCodeApplication>("... on CalculatedDiscountCodeApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedDiscountCodeApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CalculatedDiscountApplicationInterfaceCasesBuilder OnCalculatedManualDiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedManualDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<CalculatedManualDiscountApplication>("... on CalculatedManualDiscountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedManualDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CalculatedDiscountApplicationInterfaceCasesBuilder OnCalculatedScriptDiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedScriptDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<CalculatedScriptDiscountApplication>("... on CalculatedScriptDiscountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CalculatedScriptDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}