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
    public sealed class MetafieldReferenceUnionCasesBuilder : UnionCasesBuilderBase<MetafieldReference, MetafieldReferenceUnionCasesBuilder>
    {
        protected override MetafieldReferenceUnionCasesBuilder Self => this;

        public MetafieldReferenceUnionCasesBuilder(string fieldName = "reference") : this(new Query<MetafieldReference>(fieldName))
        {
        }

        public MetafieldReferenceUnionCasesBuilder(IQuery<MetafieldReference> query) : base(query)
        {
        }

        public MetafieldReferenceUnionCasesBuilder OnArticle(Action<ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("... on Article");
            var queryBuilder = new ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MetafieldReferenceUnionCasesBuilder OnCollection(Action<CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("... on Collection");
            var queryBuilder = new CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MetafieldReferenceUnionCasesBuilder OnCompany(Action<CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("... on Company");
            var queryBuilder = new CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MetafieldReferenceUnionCasesBuilder OnCustomer(Action<CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("... on Customer");
            var queryBuilder = new CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MetafieldReferenceUnionCasesBuilder OnGenericFile(Action<GenericFileQueryBuilder> build)
        {
            var query = new Query<GenericFile>("... on GenericFile");
            var queryBuilder = new GenericFileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MetafieldReferenceUnionCasesBuilder OnMediaImage(Action<MediaImageQueryBuilder> build)
        {
            var query = new Query<MediaImage>("... on MediaImage");
            var queryBuilder = new MediaImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MetafieldReferenceUnionCasesBuilder OnMetaobject(Action<MetaobjectQueryBuilder> build)
        {
            var query = new Query<Metaobject>("... on Metaobject");
            var queryBuilder = new MetaobjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MetafieldReferenceUnionCasesBuilder OnModel3d(Action<Model3dQueryBuilder> build)
        {
            var query = new Query<Model3d>("... on Model3d");
            var queryBuilder = new Model3dQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MetafieldReferenceUnionCasesBuilder OnOrder(Action<OrderQueryBuilder> build)
        {
            var query = new Query<Order>("... on Order");
            var queryBuilder = new OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MetafieldReferenceUnionCasesBuilder OnPage(Action<PageQueryBuilder> build)
        {
            var query = new Query<Page>("... on Page");
            var queryBuilder = new PageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MetafieldReferenceUnionCasesBuilder OnProduct(Action<ProductQueryBuilder> build)
        {
            var query = new Query<Product>("... on Product");
            var queryBuilder = new ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MetafieldReferenceUnionCasesBuilder OnProductVariant(Action<ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("... on ProductVariant");
            var queryBuilder = new ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MetafieldReferenceUnionCasesBuilder OnTaxonomyValue(Action<TaxonomyValueQueryBuilder> build)
        {
            var query = new Query<TaxonomyValue>("... on TaxonomyValue");
            var queryBuilder = new TaxonomyValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MetafieldReferenceUnionCasesBuilder OnVideo(Action<VideoQueryBuilder> build)
        {
            var query = new Query<Video>("... on Video");
            var queryBuilder = new VideoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}