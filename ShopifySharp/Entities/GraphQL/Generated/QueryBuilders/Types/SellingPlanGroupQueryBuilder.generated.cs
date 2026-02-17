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
    public sealed class SellingPlanGroupQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroup, SellingPlanGroupQueryBuilder>
    {
        protected override SellingPlanGroupQueryBuilder Self => this;

        public SellingPlanGroupQueryBuilder() : this("sellingPlanGroup")
        {
        }

        public SellingPlanGroupQueryBuilder(string name) : base(new Query<SellingPlanGroup>(name))
        {
        }

        public SellingPlanGroupQueryBuilder(IQuery<SellingPlanGroup> query) : base(query)
        {
        }

        public SellingPlanGroupQueryBuilder AppId()
        {
            base.InnerQuery.AddField("appId");
            return this;
        }

        public SellingPlanGroupQueryBuilder AppliesToProduct()
        {
            base.InnerQuery.AddField("appliesToProduct");
            return this;
        }

        public SellingPlanGroupQueryBuilder AppliesToProductVariant()
        {
            base.InnerQuery.AddField("appliesToProductVariant");
            return this;
        }

        public SellingPlanGroupQueryBuilder AppliesToProductVariants()
        {
            base.InnerQuery.AddField("appliesToProductVariants");
            return this;
        }

        public SellingPlanGroupQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public SellingPlanGroupQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public SellingPlanGroupQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SellingPlanGroupQueryBuilder MerchantCode()
        {
            base.InnerQuery.AddField("merchantCode");
            return this;
        }

        public SellingPlanGroupQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public SellingPlanGroupQueryBuilder Options()
        {
            base.InnerQuery.AddField("options");
            return this;
        }

        public SellingPlanGroupQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }

        public SellingPlanGroupQueryBuilder Products(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("products");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public SellingPlanGroupQueryBuilder ProductsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public SellingPlanGroupQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }

        public SellingPlanGroupQueryBuilder ProductVariantsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productVariantsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public SellingPlanGroupQueryBuilder SellingPlans(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanConnection>("sellingPlans");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanConnection>(query);
            return this;
        }

        public SellingPlanGroupQueryBuilder Summary()
        {
            base.InnerQuery.AddField("summary");
            return this;
        }

        public SellingPlanGroupQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }
    }
}