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
    public sealed class CombinedListingCombinedListingChildrenQueryBuilder : FieldsQueryBuilderBase<CombinedListingChildConnection, CombinedListingCombinedListingChildrenQueryBuilder>, IHasArguments<CombinedListingCombinedListingChildrenArgumentsBuilder>
    {
        public CombinedListingCombinedListingChildrenArgumentsBuilder Arguments { get; }
        protected override CombinedListingCombinedListingChildrenQueryBuilder Self => this;

        public CombinedListingCombinedListingChildrenQueryBuilder(string name) : base(new Query<CombinedListingChildConnection>(name))
        {
            Arguments = new CombinedListingCombinedListingChildrenArgumentsBuilder(base.InnerQuery);
        }

        public CombinedListingCombinedListingChildrenQueryBuilder(IQuery<CombinedListingChildConnection> query) : base(query)
        {
            Arguments = new CombinedListingCombinedListingChildrenArgumentsBuilder(base.InnerQuery);
        }

        public CombinedListingCombinedListingChildrenQueryBuilder SetArguments(Action<CombinedListingCombinedListingChildrenArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CombinedListingCombinedListingChildrenQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingChildEdgeQueryBuilder> build)
        {
            var query = new Query<CombinedListingChildEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingChildEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CombinedListingChildEdge>(query);
            return this;
        }

        public CombinedListingCombinedListingChildrenQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingChildQueryBuilder> build)
        {
            var query = new Query<CombinedListingChild>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingChildQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CombinedListingChild>(query);
            return this;
        }

        public CombinedListingCombinedListingChildrenQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}