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
    public sealed class TaxonomyValueEdgeQueryBuilder : FieldsQueryBuilderBase<TaxonomyValueEdge, TaxonomyValueEdgeQueryBuilder>
    {
        protected override TaxonomyValueEdgeQueryBuilder Self => this;

        public TaxonomyValueEdgeQueryBuilder() : this("taxonomyValueEdge")
        {
        }

        public TaxonomyValueEdgeQueryBuilder(string name) : base(new Query<TaxonomyValueEdge>(name))
        {
        }

        public TaxonomyValueEdgeQueryBuilder(IQuery<TaxonomyValueEdge> query) : base(query)
        {
        }

        public TaxonomyValueEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public TaxonomyValueEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyValueQueryBuilder> build)
        {
            var query = new Query<TaxonomyValue>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyValue>(query);
            return this;
        }
    }
}