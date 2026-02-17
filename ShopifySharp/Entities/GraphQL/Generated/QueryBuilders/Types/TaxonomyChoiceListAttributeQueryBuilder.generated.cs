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
    public sealed class TaxonomyChoiceListAttributeQueryBuilder : FieldsQueryBuilderBase<TaxonomyChoiceListAttribute, TaxonomyChoiceListAttributeQueryBuilder>
    {
        protected override TaxonomyChoiceListAttributeQueryBuilder Self => this;

        public TaxonomyChoiceListAttributeQueryBuilder() : this("taxonomyChoiceListAttribute")
        {
        }

        public TaxonomyChoiceListAttributeQueryBuilder(string name) : base(new Query<TaxonomyChoiceListAttribute>(name))
        {
        }

        public TaxonomyChoiceListAttributeQueryBuilder(IQuery<TaxonomyChoiceListAttribute> query) : base(query)
        {
        }

        public TaxonomyChoiceListAttributeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public TaxonomyChoiceListAttributeQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public TaxonomyChoiceListAttributeQueryBuilder Values(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyValueConnectionQueryBuilder> build)
        {
            var query = new Query<TaxonomyValueConnection>("values");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyValueConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyValueConnection>(query);
            return this;
        }
    }
}