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
    public sealed class QueryRootSellingPlanGroupQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroup, QueryRootSellingPlanGroupQueryBuilder>, IHasArguments<QueryRootSellingPlanGroupArgumentsBuilder>
    {
        public QueryRootSellingPlanGroupArgumentsBuilder Arguments { get; }
        protected override QueryRootSellingPlanGroupQueryBuilder Self => this;

        public QueryRootSellingPlanGroupQueryBuilder(string name) : base(new Query<SellingPlanGroup>(name))
        {
            Arguments = new QueryRootSellingPlanGroupArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSellingPlanGroupQueryBuilder(IQuery<SellingPlanGroup> query) : base(query)
        {
            Arguments = new QueryRootSellingPlanGroupArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSellingPlanGroupQueryBuilder SetArguments(Action<QueryRootSellingPlanGroupArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder AppId()
        {
            base.InnerQuery.AddField("appId");
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder AppliesToProduct()
        {
            base.InnerQuery.AddField("appliesToProduct");
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder AppliesToProductVariant()
        {
            base.InnerQuery.AddField("appliesToProductVariant");
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder AppliesToProductVariants()
        {
            base.InnerQuery.AddField("appliesToProductVariants");
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder MerchantCode()
        {
            base.InnerQuery.AddField("merchantCode");
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder Options()
        {
            base.InnerQuery.AddField("options");
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder Products(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("products");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder ProductsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder ProductVariantsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productVariantsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder SellingPlans(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanConnection>("sellingPlans");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanConnection>(query);
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder Summary()
        {
            base.InnerQuery.AddField("summary");
            return this;
        }

        public QueryRootSellingPlanGroupQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }
    }
}