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
    public sealed class DiscountApplicationInterfaceCasesBuilder : InterfaceCasesBuilderBase<IDiscountApplication, DiscountApplicationInterfaceCasesBuilder>
    {
        protected override DiscountApplicationInterfaceCasesBuilder Self => this;

        public DiscountApplicationInterfaceCasesBuilder(string fieldName = "discountApplication") : this(new Query<IDiscountApplication>(fieldName))
        {
        }

        public DiscountApplicationInterfaceCasesBuilder(IQuery<IDiscountApplication> query) : base(query)
        {
        }

        public DiscountApplicationInterfaceCasesBuilder OnAutomaticDiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AutomaticDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<AutomaticDiscountApplication>("... on AutomaticDiscountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AutomaticDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountApplicationInterfaceCasesBuilder OnDiscountCodeApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeApplicationQueryBuilder> build)
        {
            var query = new Query<DiscountCodeApplication>("... on DiscountCodeApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountApplicationInterfaceCasesBuilder OnManualDiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ManualDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<ManualDiscountApplication>("... on ManualDiscountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ManualDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountApplicationInterfaceCasesBuilder OnScriptDiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ScriptDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<ScriptDiscountApplication>("... on ScriptDiscountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ScriptDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}