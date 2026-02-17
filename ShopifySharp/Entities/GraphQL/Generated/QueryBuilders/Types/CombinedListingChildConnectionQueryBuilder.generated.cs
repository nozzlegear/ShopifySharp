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
    public sealed class CombinedListingChildConnectionQueryBuilder : FieldsQueryBuilderBase<CombinedListingChildConnection, CombinedListingChildConnectionQueryBuilder>
    {
        protected override CombinedListingChildConnectionQueryBuilder Self => this;

        public CombinedListingChildConnectionQueryBuilder() : this("combinedListingChildConnection")
        {
        }

        public CombinedListingChildConnectionQueryBuilder(string name) : base(new Query<CombinedListingChildConnection>(name))
        {
        }

        public CombinedListingChildConnectionQueryBuilder(IQuery<CombinedListingChildConnection> query) : base(query)
        {
        }

        public CombinedListingChildConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingChildEdgeQueryBuilder> build)
        {
            var query = new Query<CombinedListingChildEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingChildEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CombinedListingChildEdge>(query);
            return this;
        }

        public CombinedListingChildConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingChildQueryBuilder> build)
        {
            var query = new Query<CombinedListingChild>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingChildQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CombinedListingChild>(query);
            return this;
        }

        public CombinedListingChildConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}