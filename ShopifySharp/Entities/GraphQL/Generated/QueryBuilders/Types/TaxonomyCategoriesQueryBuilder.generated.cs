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
    public sealed class TaxonomyCategoriesQueryBuilder : FieldsQueryBuilderBase<TaxonomyCategoryConnection, TaxonomyCategoriesQueryBuilder>, IHasArguments<TaxonomyCategoriesArgumentsBuilder>
    {
        public TaxonomyCategoriesArgumentsBuilder Arguments { get; }
        protected override TaxonomyCategoriesQueryBuilder Self => this;

        public TaxonomyCategoriesQueryBuilder(string name) : base(new Query<TaxonomyCategoryConnection>(name))
        {
            Arguments = new TaxonomyCategoriesArgumentsBuilder(base.InnerQuery);
        }

        public TaxonomyCategoriesQueryBuilder(IQuery<TaxonomyCategoryConnection> query) : base(query)
        {
            Arguments = new TaxonomyCategoriesArgumentsBuilder(base.InnerQuery);
        }

        public TaxonomyCategoriesQueryBuilder SetArguments(Action<TaxonomyCategoriesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public TaxonomyCategoriesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryEdgeQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategoryEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategoryEdge>(query);
            return this;
        }

        public TaxonomyCategoriesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategory>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategory>(query);
            return this;
        }

        public TaxonomyCategoriesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}