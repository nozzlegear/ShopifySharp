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

        public ProductCategoryQueryBuilder ProductTaxonomyNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductTaxonomyNodeQueryBuilder> build)
        {
            var query = new Query<ProductTaxonomyNode>("productTaxonomyNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductTaxonomyNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductTaxonomyNode>(query);
            return this;
        }
    }
}