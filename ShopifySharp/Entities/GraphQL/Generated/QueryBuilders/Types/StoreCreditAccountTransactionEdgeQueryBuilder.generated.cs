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
    public sealed class StoreCreditAccountTransactionEdgeQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountTransactionEdge, StoreCreditAccountTransactionEdgeQueryBuilder>
    {
        protected override StoreCreditAccountTransactionEdgeQueryBuilder Self => this;

        public StoreCreditAccountTransactionEdgeQueryBuilder() : this("storeCreditAccountTransactionEdge")
        {
        }

        public StoreCreditAccountTransactionEdgeQueryBuilder(string name) : base(new Query<StoreCreditAccountTransactionEdge>(name))
        {
        }

        public StoreCreditAccountTransactionEdgeQueryBuilder(IQuery<StoreCreditAccountTransactionEdge> query) : base(query)
        {
        }

        public StoreCreditAccountTransactionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public StoreCreditAccountTransactionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountTransactionQueryBuilder> build)
        {
            var query = new Query<IStoreCreditAccountTransaction>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IStoreCreditAccountTransaction>(query);
            return this;
        }
    }
}