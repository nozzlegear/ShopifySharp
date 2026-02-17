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
    public sealed class ProductTaxonomyNodeQueryBuilder : FieldsQueryBuilderBase<ProductTaxonomyNode, ProductTaxonomyNodeQueryBuilder>
    {
        protected override ProductTaxonomyNodeQueryBuilder Self => this;

        public ProductTaxonomyNodeQueryBuilder() : this("productTaxonomyNode")
        {
        }

        public ProductTaxonomyNodeQueryBuilder(string name) : base(new Query<ProductTaxonomyNode>(name))
        {
        }

        public ProductTaxonomyNodeQueryBuilder(IQuery<ProductTaxonomyNode> query) : base(query)
        {
        }

        public ProductTaxonomyNodeQueryBuilder FullName()
        {
            base.InnerQuery.AddField("fullName");
            return this;
        }

        public ProductTaxonomyNodeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductTaxonomyNodeQueryBuilder IsLeaf()
        {
            base.InnerQuery.AddField("isLeaf");
            return this;
        }

        public ProductTaxonomyNodeQueryBuilder IsRoot()
        {
            base.InnerQuery.AddField("isRoot");
            return this;
        }

        public ProductTaxonomyNodeQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}