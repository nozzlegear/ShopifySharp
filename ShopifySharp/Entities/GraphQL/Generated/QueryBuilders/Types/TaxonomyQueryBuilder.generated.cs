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
    public sealed class TaxonomyQueryBuilder : FieldsQueryBuilderBase<Taxonomy, TaxonomyQueryBuilder>
    {
        protected override TaxonomyQueryBuilder Self => this;

        public TaxonomyQueryBuilder() : this("taxonomy")
        {
        }

        public TaxonomyQueryBuilder(string name) : base(new Query<Taxonomy>(name))
        {
        }

        public TaxonomyQueryBuilder(IQuery<Taxonomy> query) : base(query)
        {
        }

        public TaxonomyQueryBuilder Categories(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryConnectionQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategoryConnection>("categories");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategoryConnection>(query);
            return this;
        }
    }
}