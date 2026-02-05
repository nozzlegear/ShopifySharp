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
    public sealed class CheckoutProfileEdgeQueryBuilder : FieldsQueryBuilderBase<CheckoutProfileEdge, CheckoutProfileEdgeQueryBuilder>
    {
        protected override CheckoutProfileEdgeQueryBuilder Self => this;

        public CheckoutProfileEdgeQueryBuilder() : this("checkoutProfileEdge")
        {
        }

        public CheckoutProfileEdgeQueryBuilder(string name) : base(new Query<CheckoutProfileEdge>(name))
        {
        }

        public CheckoutProfileEdgeQueryBuilder(IQuery<CheckoutProfileEdge> query) : base(query)
        {
        }

        public CheckoutProfileEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CheckoutProfileEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutProfileQueryBuilder> build)
        {
            var query = new Query<CheckoutProfile>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutProfile>(query);
            return this;
        }
    }
}