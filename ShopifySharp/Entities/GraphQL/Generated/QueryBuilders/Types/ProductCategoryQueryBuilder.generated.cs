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
    public sealed class ProductCategoryQueryBuilder : FieldsQueryBuilderBase<ProductCategory, ProductCategoryQueryBuilder>
    {
        protected override ProductCategoryQueryBuilder Self => this;

        public ProductCategoryQueryBuilder() : this("productCategory")
        {
        }

        public ProductCategoryQueryBuilder(string name) : base(new Query<ProductCategory>(name))
        {
        }

        public ProductCategoryQueryBuilder(IQuery<ProductCategory> query) : base(query)
        {
        }

        public ProductCategoryQueryBuilder ProductTaxonomyNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductTaxonomyNodeQueryBuilder> build)
        {
            var query = new Query<ProductTaxonomyNode>("productTaxonomyNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductTaxonomyNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductTaxonomyNode>(query);
            return this;
        }
    }
}