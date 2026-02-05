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
    public sealed class TenderTransactionEdgeQueryBuilder : FieldsQueryBuilderBase<TenderTransactionEdge, TenderTransactionEdgeQueryBuilder>
    {
        protected override TenderTransactionEdgeQueryBuilder Self => this;

        public TenderTransactionEdgeQueryBuilder() : this("tenderTransactionEdge")
        {
        }

        public TenderTransactionEdgeQueryBuilder(string name) : base(new Query<TenderTransactionEdge>(name))
        {
        }

        public TenderTransactionEdgeQueryBuilder(IQuery<TenderTransactionEdge> query) : base(query)
        {
        }

        public TenderTransactionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public TenderTransactionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TenderTransactionQueryBuilder> build)
        {
            var query = new Query<TenderTransaction>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TenderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TenderTransaction>(query);
            return this;
        }
    }
}