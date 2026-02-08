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
    public sealed class TaxonomyCategoryConnectionQueryBuilder : FieldsQueryBuilderBase<TaxonomyCategoryConnection, TaxonomyCategoryConnectionQueryBuilder>
    {
        protected override TaxonomyCategoryConnectionQueryBuilder Self => this;

        public TaxonomyCategoryConnectionQueryBuilder() : this("taxonomyCategoryConnection")
        {
        }

        public TaxonomyCategoryConnectionQueryBuilder(string name) : base(new Query<TaxonomyCategoryConnection>(name))
        {
        }

        public TaxonomyCategoryConnectionQueryBuilder(IQuery<TaxonomyCategoryConnection> query) : base(query)
        {
        }

        public TaxonomyCategoryConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryEdgeQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategoryEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategoryEdge>(query);
            return this;
        }

        public TaxonomyCategoryConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategory>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategory>(query);
            return this;
        }

        public TaxonomyCategoryConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}