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
    public sealed class TaxonomyCategoryAttributeQueryBuilder : FieldsQueryBuilderBase<TaxonomyCategoryAttribute, TaxonomyCategoryAttributeQueryBuilder>
    {
        protected override TaxonomyCategoryAttributeQueryBuilder Self => this;

        public TaxonomyCategoryAttributeQueryBuilder() : this("taxonomyCategoryAttribute")
        {
        }

        public TaxonomyCategoryAttributeQueryBuilder(string name) : base(new Query<TaxonomyCategoryAttribute>(name))
        {
        }

        public TaxonomyCategoryAttributeQueryBuilder(IQuery<TaxonomyCategoryAttribute> query) : base(query)
        {
        }

        public TaxonomyCategoryAttributeQueryBuilder TaxonomyCategoryAttribute(Action<TaxonomyCategoryAttributeUnionCasesBuilder> build)
        {
            var query = new Query<TaxonomyCategoryAttribute>("taxonomyCategoryAttribute");
            var unionBuilder = new TaxonomyCategoryAttributeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}