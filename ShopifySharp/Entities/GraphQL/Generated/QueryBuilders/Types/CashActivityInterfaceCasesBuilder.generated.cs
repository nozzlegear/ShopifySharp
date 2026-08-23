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
    public sealed class CashActivityInterfaceCasesBuilder : InterfaceCasesBuilderBase<ICashActivity, CashActivityInterfaceCasesBuilder>
    {
        protected override CashActivityInterfaceCasesBuilder Self => this;

        public CashActivityInterfaceCasesBuilder(string fieldName = "node") : this(new Query<ICashActivity>(fieldName))
        {
        }

        public CashActivityInterfaceCasesBuilder(IQuery<ICashActivity> query) : base(query)
        {
        }

        public CashActivityInterfaceCasesBuilder OnCashAdjustmentActivity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashAdjustmentActivityQueryBuilder> build)
        {
            var query = new Query<CashAdjustmentActivity>("... on CashAdjustmentActivity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashAdjustmentActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CashActivityInterfaceCasesBuilder OnCashCountActivity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashCountActivityQueryBuilder> build)
        {
            var query = new Query<CashCountActivity>("... on CashCountActivity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashCountActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CashActivityInterfaceCasesBuilder OnCashTransactionActivity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashTransactionActivityQueryBuilder> build)
        {
            var query = new Query<CashTransactionActivity>("... on CashTransactionActivity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashTransactionActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}