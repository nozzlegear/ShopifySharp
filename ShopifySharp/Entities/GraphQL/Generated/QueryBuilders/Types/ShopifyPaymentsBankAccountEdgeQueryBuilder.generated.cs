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
    public sealed class ShopifyPaymentsBankAccountEdgeQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsBankAccountEdge, ShopifyPaymentsBankAccountEdgeQueryBuilder>
    {
        protected override ShopifyPaymentsBankAccountEdgeQueryBuilder Self => this;

        public ShopifyPaymentsBankAccountEdgeQueryBuilder() : this("shopifyPaymentsBankAccountEdge")
        {
        }

        public ShopifyPaymentsBankAccountEdgeQueryBuilder(string name) : base(new Query<ShopifyPaymentsBankAccountEdge>(name))
        {
        }

        public ShopifyPaymentsBankAccountEdgeQueryBuilder(IQuery<ShopifyPaymentsBankAccountEdge> query) : base(query)
        {
        }

        public ShopifyPaymentsBankAccountEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ShopifyPaymentsBankAccountEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsBankAccountQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBankAccount>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsBankAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsBankAccount>(query);
            return this;
        }
    }
}