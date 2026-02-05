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
    public sealed class TaxonomyAttributeQueryBuilder : FieldsQueryBuilderBase<TaxonomyAttribute, TaxonomyAttributeQueryBuilder>
    {
        protected override TaxonomyAttributeQueryBuilder Self => this;

        public TaxonomyAttributeQueryBuilder() : this("taxonomyAttribute")
        {
        }

        public TaxonomyAttributeQueryBuilder(string name) : base(new Query<TaxonomyAttribute>(name))
        {
        }

        public TaxonomyAttributeQueryBuilder(IQuery<TaxonomyAttribute> query) : base(query)
        {
        }

        public TaxonomyAttributeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}