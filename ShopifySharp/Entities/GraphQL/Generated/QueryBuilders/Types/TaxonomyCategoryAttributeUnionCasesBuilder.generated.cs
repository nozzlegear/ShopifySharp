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
    public sealed class TaxonomyCategoryAttributeUnionCasesBuilder : UnionCasesBuilderBase<TaxonomyCategoryAttribute, TaxonomyCategoryAttributeUnionCasesBuilder>
    {
        protected override TaxonomyCategoryAttributeUnionCasesBuilder Self => this;

        public TaxonomyCategoryAttributeUnionCasesBuilder(string fieldName = "node") : this(new Query<TaxonomyCategoryAttribute>(fieldName))
        {
        }

        public TaxonomyCategoryAttributeUnionCasesBuilder(IQuery<TaxonomyCategoryAttribute> query) : base(query)
        {
        }

        public TaxonomyCategoryAttributeUnionCasesBuilder OnTaxonomyAttribute(Action<TaxonomyAttributeQueryBuilder> build)
        {
            var query = new Query<TaxonomyAttribute>("... on TaxonomyAttribute");
            var queryBuilder = new TaxonomyAttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public TaxonomyCategoryAttributeUnionCasesBuilder OnTaxonomyChoiceListAttribute(Action<TaxonomyChoiceListAttributeQueryBuilder> build)
        {
            var query = new Query<TaxonomyChoiceListAttribute>("... on TaxonomyChoiceListAttribute");
            var queryBuilder = new TaxonomyChoiceListAttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public TaxonomyCategoryAttributeUnionCasesBuilder OnTaxonomyMeasurementAttribute(Action<TaxonomyMeasurementAttributeQueryBuilder> build)
        {
            var query = new Query<TaxonomyMeasurementAttribute>("... on TaxonomyMeasurementAttribute");
            var queryBuilder = new TaxonomyMeasurementAttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}