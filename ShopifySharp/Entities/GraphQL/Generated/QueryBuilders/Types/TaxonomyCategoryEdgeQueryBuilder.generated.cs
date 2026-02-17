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

        public TaxonomyCategoryEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategory>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategory>(query);
            return this;
        }
    }
}