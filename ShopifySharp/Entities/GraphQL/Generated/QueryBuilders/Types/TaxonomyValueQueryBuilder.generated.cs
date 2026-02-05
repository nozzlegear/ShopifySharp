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
    public sealed class TaxonomyValueQueryBuilder : FieldsQueryBuilderBase<TaxonomyValue, TaxonomyValueQueryBuilder>
    {
        protected override TaxonomyValueQueryBuilder Self => this;

        public TaxonomyValueQueryBuilder() : this("taxonomyValue")
        {
        }

        public TaxonomyValueQueryBuilder(string name) : base(new Query<TaxonomyValue>(name))
        {
        }

        public TaxonomyValueQueryBuilder(IQuery<TaxonomyValue> query) : base(query)
        {
        }

        public TaxonomyValueQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public TaxonomyValueQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}