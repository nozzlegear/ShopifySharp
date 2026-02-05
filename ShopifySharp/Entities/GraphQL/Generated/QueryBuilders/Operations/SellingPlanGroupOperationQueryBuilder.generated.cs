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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class SellingPlanGroupOperationQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroup, SellingPlanGroupOperationQueryBuilder>, IGraphOperationQueryBuilder<SellingPlanGroup>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SellingPlanGroupArgumentsBuilder Arguments { get; }
        protected override SellingPlanGroupOperationQueryBuilder Self => this;

        public SellingPlanGroupOperationQueryBuilder() : this("sellingPlanGroup")
        {
        }

        public SellingPlanGroupOperationQueryBuilder(string name) : base(new Query<SellingPlanGroup>(name))
        {
            Arguments = new SellingPlanGroupArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupOperationQueryBuilder(IQuery<SellingPlanGroup> query) : base(query)
        {
            Arguments = new SellingPlanGroupArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupOperationQueryBuilder AppId()
        {
            base.InnerQuery.AddField("appId");
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder AppliesToProduct()
        {
            base.InnerQuery.AddField("appliesToProduct");
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder AppliesToProductVariant()
        {
            base.InnerQuery.AddField("appliesToProductVariant");
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder AppliesToProductVariants()
        {
            base.InnerQuery.AddField("appliesToProductVariants");
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder MerchantCode()
        {
            base.InnerQuery.AddField("merchantCode");
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder Options()
        {
            base.InnerQuery.AddField("options");
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder Products(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("products");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder ProductsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder ProductVariantsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productVariantsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder SellingPlans(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanConnection>("sellingPlans");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanConnection>(query);
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder Summary()
        {
            base.InnerQuery.AddField("summary");
            return this;
        }

        public SellingPlanGroupOperationQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }
    }
}