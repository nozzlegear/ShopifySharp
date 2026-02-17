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
    public sealed class CombinedListingChildEdgeQueryBuilder : FieldsQueryBuilderBase<CombinedListingChildEdge, CombinedListingChildEdgeQueryBuilder>
    {
        protected override CombinedListingChildEdgeQueryBuilder Self => this;

        public CombinedListingChildEdgeQueryBuilder() : this("combinedListingChildEdge")
        {
        }

        public CombinedListingChildEdgeQueryBuilder(string name) : base(new Query<CombinedListingChildEdge>(name))
        {
        }

        public CombinedListingChildEdgeQueryBuilder(IQuery<CombinedListingChildEdge> query) : base(query)
        {
        }

        public CombinedListingChildEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CombinedListingChildEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingChildQueryBuilder> build)
        {
            var query = new Query<CombinedListingChild>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingChildQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CombinedListingChild>(query);
            return this;
        }
    }
}