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
    public sealed class TaxonomyCategoryAttributeConnectionQueryBuilder : FieldsQueryBuilderBase<TaxonomyCategoryAttributeConnection, TaxonomyCategoryAttributeConnectionQueryBuilder>
    {
        protected override TaxonomyCategoryAttributeConnectionQueryBuilder Self => this;

        public TaxonomyCategoryAttributeConnectionQueryBuilder() : this("taxonomyCategoryAttributeConnection")
        {
        }

        public TaxonomyCategoryAttributeConnectionQueryBuilder(string name) : base(new Query<TaxonomyCategoryAttributeConnection>(name))
        {
        }

        public TaxonomyCategoryAttributeConnectionQueryBuilder(IQuery<TaxonomyCategoryAttributeConnection> query) : base(query)
        {
        }

        public TaxonomyCategoryAttributeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryAttributeEdgeQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategoryAttributeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryAttributeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategoryAttributeEdge>(query);
            return this;
        }

        public TaxonomyCategoryAttributeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public TaxonomyCategoryAttributeConnectionQueryBuilder Nodes(Action<TaxonomyCategoryAttributeUnionCasesBuilder> build)
        {
            var query = new Query<TaxonomyCategoryAttribute>("nodes");
            var unionBuilder = new TaxonomyCategoryAttributeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}