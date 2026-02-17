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

        public TaxonomyValueConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyValueEdgeQueryBuilder> build)
        {
            var query = new Query<TaxonomyValueEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyValueEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyValueEdge>(query);
            return this;
        }

        public TaxonomyValueConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyValueQueryBuilder> build)
        {
            var query = new Query<TaxonomyValue>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyValue>(query);
            return this;
        }

        public TaxonomyValueConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}