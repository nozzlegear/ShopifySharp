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
    public sealed class TaxonomyMeasurementAttributeQueryBuilder : FieldsQueryBuilderBase<TaxonomyMeasurementAttribute, TaxonomyMeasurementAttributeQueryBuilder>
    {
        protected override TaxonomyMeasurementAttributeQueryBuilder Self => this;

        public TaxonomyMeasurementAttributeQueryBuilder() : this("taxonomyMeasurementAttribute")
        {
        }

        public TaxonomyMeasurementAttributeQueryBuilder(string name) : base(new Query<TaxonomyMeasurementAttribute>(name))
        {
        }

        public TaxonomyMeasurementAttributeQueryBuilder(IQuery<TaxonomyMeasurementAttribute> query) : base(query)
        {
        }

        public TaxonomyMeasurementAttributeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public TaxonomyMeasurementAttributeQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public TaxonomyMeasurementAttributeQueryBuilder Options(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder> build)
        {
            var query = new Query<ShopifySharp.GraphQL.Attribute>("options");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AttributeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifySharp.GraphQL.Attribute>(query);
            return this;
        }
    }
}