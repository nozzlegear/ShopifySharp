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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DiscountUnionCasesBuilder : UnionCasesBuilderBase<Discount, DiscountUnionCasesBuilder>
    {
        protected override DiscountUnionCasesBuilder Self => this;

        public DiscountUnionCasesBuilder(string fieldName = "discount") : this(new Query<Discount>(fieldName))
        {
        }

        public DiscountUnionCasesBuilder(IQuery<Discount> query) : base(query)
        {
        }

        public DiscountUnionCasesBuilder OnDiscountAutomaticApp(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticApp>("... on DiscountAutomaticApp");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountAutomaticBasic(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBasicQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticBasic>("... on DiscountAutomaticBasic");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBasicQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountAutomaticBxgy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBxgyQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticBxgy>("... on DiscountAutomaticBxgy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBxgyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountAutomaticFreeShipping(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticFreeShippingQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticFreeShipping>("... on DiscountAutomaticFreeShipping");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticFreeShippingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountCodeApp(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeAppQueryBuilder> build)
        {
            var query = new Query<DiscountCodeApp>("... on DiscountCodeApp");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountCodeBasic(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeBasicQueryBuilder> build)
        {
            var query = new Query<DiscountCodeBasic>("... on DiscountCodeBasic");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeBasicQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountCodeBxgy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeBxgyQueryBuilder> build)
        {
            var query = new Query<DiscountCodeBxgy>("... on DiscountCodeBxgy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeBxgyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountCodeFreeShipping(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeFreeShippingQueryBuilder> build)
        {
            var query = new Query<DiscountCodeFreeShipping>("... on DiscountCodeFreeShipping");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeFreeShippingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}