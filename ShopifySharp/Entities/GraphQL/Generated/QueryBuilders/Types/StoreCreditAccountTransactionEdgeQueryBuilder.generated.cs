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

        public StoreCreditAccountTransactionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountTransactionQueryBuilder> build)
        {
            var query = new Query<IStoreCreditAccountTransaction>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IStoreCreditAccountTransaction>(query);
            return this;
        }
    }
}