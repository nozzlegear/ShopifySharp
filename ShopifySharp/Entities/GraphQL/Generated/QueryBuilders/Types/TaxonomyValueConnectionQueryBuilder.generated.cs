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
    public sealed class TaxonomyValueConnectionQueryBuilder : FieldsQueryBuilderBase<TaxonomyValueConnection, TaxonomyValueConnectionQueryBuilder>
    {
        protected override TaxonomyValueConnectionQueryBuilder Self => this;

        public TaxonomyValueConnectionQueryBuilder() : this("taxonomyValueConnection")
        {
        }

        public TaxonomyValueConnectionQueryBuilder(string name) : base(new Query<TaxonomyValueConnection>(name))
        {
        }

        public TaxonomyValueConnectionQueryBuilder(IQuery<TaxonomyValueConnection> query) : base(query)
        {
        }

        public TaxonomyValueConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyValueEdgeQueryBuilder> build)
        {
            var query = new Query<TaxonomyValueEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyValueEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyValueEdge>(query);
            return this;
        }

        public TaxonomyValueConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyValueQueryBuilder> build)
        {
            var query = new Query<TaxonomyValue>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyValue>(query);
            return this;
        }

        public TaxonomyValueConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}