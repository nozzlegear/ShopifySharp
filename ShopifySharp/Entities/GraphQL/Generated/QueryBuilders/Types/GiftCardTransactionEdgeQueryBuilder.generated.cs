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
    public sealed class GiftCardTransactionEdgeQueryBuilder : FieldsQueryBuilderBase<GiftCardTransactionEdge, GiftCardTransactionEdgeQueryBuilder>
    {
        protected override GiftCardTransactionEdgeQueryBuilder Self => this;

        public GiftCardTransactionEdgeQueryBuilder() : this("giftCardTransactionEdge")
        {
        }

        public GiftCardTransactionEdgeQueryBuilder(string name) : base(new Query<GiftCardTransactionEdge>(name))
        {
        }

        public GiftCardTransactionEdgeQueryBuilder(IQuery<GiftCardTransactionEdge> query) : base(query)
        {
        }

        public GiftCardTransactionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public GiftCardTransactionEdgeQueryBuilder Node(Action<GiftCardTransactionInterfaceCasesBuilder> build)
        {
            var query = new Query<IGiftCardTransaction>("node");
            var unionBuilder = new GiftCardTransactionInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}