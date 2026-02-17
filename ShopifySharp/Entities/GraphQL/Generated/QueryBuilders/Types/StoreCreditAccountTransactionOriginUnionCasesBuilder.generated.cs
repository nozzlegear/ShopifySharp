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
    public sealed class StoreCreditAccountTransactionOriginUnionCasesBuilder : UnionCasesBuilderBase<StoreCreditAccountTransactionOrigin, StoreCreditAccountTransactionOriginUnionCasesBuilder>
    {
        protected override StoreCreditAccountTransactionOriginUnionCasesBuilder Self => this;

        public StoreCreditAccountTransactionOriginUnionCasesBuilder(string fieldName = "storeCreditAccountTransactionOrigin") : this(new Query<StoreCreditAccountTransactionOrigin>(fieldName))
        {
        }

        public StoreCreditAccountTransactionOriginUnionCasesBuilder(IQuery<StoreCreditAccountTransactionOrigin> query) : base(query)
        {
        }

        public StoreCreditAccountTransactionOriginUnionCasesBuilder OnOrderTransaction(Action<OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("... on OrderTransaction");
            var queryBuilder = new OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}