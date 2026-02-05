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
    public sealed class TaxonomyCategoryEdgeQueryBuilder : FieldsQueryBuilderBase<TaxonomyCategoryEdge, TaxonomyCategoryEdgeQueryBuilder>
    {
        protected override TaxonomyCategoryEdgeQueryBuilder Self => this;

        public TaxonomyCategoryEdgeQueryBuilder() : this("taxonomyCategoryEdge")
        {
        }

        public TaxonomyCategoryEdgeQueryBuilder(string name) : base(new Query<TaxonomyCategoryEdge>(name))
        {
        }

        public TaxonomyCategoryEdgeQueryBuilder(IQuery<TaxonomyCategoryEdge> query) : base(query)
        {
        }

        public TaxonomyCategoryEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public TaxonomyCategoryEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategory>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategory>(query);
            return this;
        }
    }
}