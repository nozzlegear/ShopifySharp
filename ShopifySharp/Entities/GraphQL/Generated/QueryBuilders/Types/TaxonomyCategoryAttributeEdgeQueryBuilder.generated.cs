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
    public sealed class TaxonomyCategoryAttributeEdgeQueryBuilder : FieldsQueryBuilderBase<TaxonomyCategoryAttributeEdge, TaxonomyCategoryAttributeEdgeQueryBuilder>
    {
        protected override TaxonomyCategoryAttributeEdgeQueryBuilder Self => this;

        public TaxonomyCategoryAttributeEdgeQueryBuilder() : this("taxonomyCategoryAttributeEdge")
        {
        }

        public TaxonomyCategoryAttributeEdgeQueryBuilder(string name) : base(new Query<TaxonomyCategoryAttributeEdge>(name))
        {
        }

        public TaxonomyCategoryAttributeEdgeQueryBuilder(IQuery<TaxonomyCategoryAttributeEdge> query) : base(query)
        {
        }

        public TaxonomyCategoryAttributeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public TaxonomyCategoryAttributeEdgeQueryBuilder Node(Action<TaxonomyCategoryAttributeUnionCasesBuilder> build)
        {
            var query = new Query<TaxonomyCategoryAttribute>("node");
            var unionBuilder = new TaxonomyCategoryAttributeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}