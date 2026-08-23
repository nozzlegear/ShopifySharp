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
    public sealed class StoreCreditAccountTransactionInterfaceCasesBuilder : InterfaceCasesBuilderBase<IStoreCreditAccountTransaction, StoreCreditAccountTransactionInterfaceCasesBuilder>
    {
        protected override StoreCreditAccountTransactionInterfaceCasesBuilder Self => this;

        public StoreCreditAccountTransactionInterfaceCasesBuilder(string fieldName = "node") : this(new Query<IStoreCreditAccountTransaction>(fieldName))
        {
        }

        public StoreCreditAccountTransactionInterfaceCasesBuilder(IQuery<IStoreCreditAccountTransaction> query) : base(query)
        {
        }

        public StoreCreditAccountTransactionInterfaceCasesBuilder OnStoreCreditAccountCreditTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountCreditTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountCreditTransaction>("... on StoreCreditAccountCreditTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountCreditTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public StoreCreditAccountTransactionInterfaceCasesBuilder OnStoreCreditAccountDebitRevertTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountDebitRevertTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountDebitRevertTransaction>("... on StoreCreditAccountDebitRevertTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountDebitRevertTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public StoreCreditAccountTransactionInterfaceCasesBuilder OnStoreCreditAccountDebitTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountDebitTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountDebitTransaction>("... on StoreCreditAccountDebitTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountDebitTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public StoreCreditAccountTransactionInterfaceCasesBuilder OnStoreCreditAccountExpirationTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountExpirationTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountExpirationTransaction>("... on StoreCreditAccountExpirationTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountExpirationTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}