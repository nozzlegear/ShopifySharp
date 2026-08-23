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
    public sealed class TaxonomyCategoryAttributeUnionCasesBuilder : UnionCasesBuilderBase<TaxonomyCategoryAttribute, TaxonomyCategoryAttributeUnionCasesBuilder>
    {
        protected override TaxonomyCategoryAttributeUnionCasesBuilder Self => this;

        public TaxonomyCategoryAttributeUnionCasesBuilder(string fieldName = "node") : this(new Query<TaxonomyCategoryAttribute>(fieldName))
        {
        }

        public TaxonomyCategoryAttributeUnionCasesBuilder(IQuery<TaxonomyCategoryAttribute> query) : base(query)
        {
        }

        public TaxonomyCategoryAttributeUnionCasesBuilder OnTaxonomyAttribute(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyAttributeQueryBuilder> build)
        {
            var query = new Query<TaxonomyAttribute>("... on TaxonomyAttribute");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyAttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public TaxonomyCategoryAttributeUnionCasesBuilder OnTaxonomyChoiceListAttribute(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyChoiceListAttributeQueryBuilder> build)
        {
            var query = new Query<TaxonomyChoiceListAttribute>("... on TaxonomyChoiceListAttribute");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyChoiceListAttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public TaxonomyCategoryAttributeUnionCasesBuilder OnTaxonomyMeasurementAttribute(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyMeasurementAttributeQueryBuilder> build)
        {
            var query = new Query<TaxonomyMeasurementAttribute>("... on TaxonomyMeasurementAttribute");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyMeasurementAttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}