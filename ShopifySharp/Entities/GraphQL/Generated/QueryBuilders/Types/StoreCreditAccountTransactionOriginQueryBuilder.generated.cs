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
    public sealed class StoreCreditAccountTransactionOriginQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountTransactionOrigin, StoreCreditAccountTransactionOriginQueryBuilder>
    {
        protected override StoreCreditAccountTransactionOriginQueryBuilder Self => this;

        public StoreCreditAccountTransactionOriginQueryBuilder() : this("storeCreditAccountTransactionOrigin")
        {
        }

        public StoreCreditAccountTransactionOriginQueryBuilder(string name) : base(new Query<StoreCreditAccountTransactionOrigin>(name))
        {
        }

        public StoreCreditAccountTransactionOriginQueryBuilder(IQuery<StoreCreditAccountTransactionOrigin> query) : base(query)
        {
        }

        public StoreCreditAccountTransactionOriginQueryBuilder StoreCreditAccountTransactionOrigin(Action<StoreCreditAccountTransactionOriginUnionCasesBuilder> build)
        {
            var query = new Query<StoreCreditAccountTransactionOrigin>("storeCreditAccountTransactionOrigin");
            var unionBuilder = new StoreCreditAccountTransactionOriginUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}