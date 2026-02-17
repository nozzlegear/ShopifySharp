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
    public sealed class SavedSearchEdgeQueryBuilder : FieldsQueryBuilderBase<SavedSearchEdge, SavedSearchEdgeQueryBuilder>
    {
        protected override SavedSearchEdgeQueryBuilder Self => this;

        public SavedSearchEdgeQueryBuilder() : this("savedSearchEdge")
        {
        }

        public SavedSearchEdgeQueryBuilder(string name) : base(new Query<SavedSearchEdge>(name))
        {
        }

        public SavedSearchEdgeQueryBuilder(IQuery<SavedSearchEdge> query) : base(query)
        {
        }

        public SavedSearchEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SavedSearchEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchQueryBuilder> build)
        {
            var query = new Query<SavedSearch>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearch>(query);
            return this;
        }
    }
}