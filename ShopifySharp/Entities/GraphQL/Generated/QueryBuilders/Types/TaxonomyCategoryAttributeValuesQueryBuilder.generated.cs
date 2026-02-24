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
    public sealed class TaxonomyCategoryAttributeValuesQueryBuilder : FieldsQueryBuilderBase<TaxonomyValueConnection, TaxonomyCategoryAttributeValuesQueryBuilder>, IHasArguments<TaxonomyCategoryAttributeValuesArgumentsBuilder>
    {
        public TaxonomyCategoryAttributeValuesArgumentsBuilder Arguments { get; }
        protected override TaxonomyCategoryAttributeValuesQueryBuilder Self => this;

        public TaxonomyCategoryAttributeValuesQueryBuilder(string name) : base(new Query<TaxonomyValueConnection>(name))
        {
            Arguments = new TaxonomyCategoryAttributeValuesArgumentsBuilder(base.InnerQuery);
        }

        public TaxonomyCategoryAttributeValuesQueryBuilder(IQuery<TaxonomyValueConnection> query) : base(query)
        {
            Arguments = new TaxonomyCategoryAttributeValuesArgumentsBuilder(base.InnerQuery);
        }

        public TaxonomyCategoryAttributeValuesQueryBuilder SetArguments(Action<TaxonomyCategoryAttributeValuesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public TaxonomyCategoryAttributeValuesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyValueEdgeQueryBuilder> build)
        {
            var query = new Query<TaxonomyValueEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyValueEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyValueEdge>(query);
            return this;
        }

        public TaxonomyCategoryAttributeValuesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyValueQueryBuilder> build)
        {
            var query = new Query<TaxonomyValue>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyValue>(query);
            return this;
        }

        public TaxonomyCategoryAttributeValuesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}