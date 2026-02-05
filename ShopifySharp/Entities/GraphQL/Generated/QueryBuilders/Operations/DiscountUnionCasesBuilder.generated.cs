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
    public sealed class DiscountUnionCasesBuilder : UnionCasesBuilderBase<Discount, DiscountUnionCasesBuilder>
    {
        protected override DiscountUnionCasesBuilder Self => this;

        public DiscountUnionCasesBuilder(string fieldName = "discount") : this(new Query<Discount>(fieldName))
        {
        }

        public DiscountUnionCasesBuilder(IQuery<Discount> query) : base(query)
        {
        }

        public DiscountUnionCasesBuilder OnDiscountAutomaticApp(Action<DiscountAutomaticAppQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticApp>("... on DiscountAutomaticApp");
            var queryBuilder = new DiscountAutomaticAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountAutomaticBasic(Action<DiscountAutomaticBasicQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticBasic>("... on DiscountAutomaticBasic");
            var queryBuilder = new DiscountAutomaticBasicQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountAutomaticBxgy(Action<DiscountAutomaticBxgyQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticBxgy>("... on DiscountAutomaticBxgy");
            var queryBuilder = new DiscountAutomaticBxgyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountAutomaticFreeShipping(Action<DiscountAutomaticFreeShippingQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticFreeShipping>("... on DiscountAutomaticFreeShipping");
            var queryBuilder = new DiscountAutomaticFreeShippingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountCodeApp(Action<DiscountCodeAppQueryBuilder> build)
        {
            var query = new Query<DiscountCodeApp>("... on DiscountCodeApp");
            var queryBuilder = new DiscountCodeAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountCodeBasic(Action<DiscountCodeBasicQueryBuilder> build)
        {
            var query = new Query<DiscountCodeBasic>("... on DiscountCodeBasic");
            var queryBuilder = new DiscountCodeBasicQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountCodeBxgy(Action<DiscountCodeBxgyQueryBuilder> build)
        {
            var query = new Query<DiscountCodeBxgy>("... on DiscountCodeBxgy");
            var queryBuilder = new DiscountCodeBxgyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountUnionCasesBuilder OnDiscountCodeFreeShipping(Action<DiscountCodeFreeShippingQueryBuilder> build)
        {
            var query = new Query<DiscountCodeFreeShipping>("... on DiscountCodeFreeShipping");
            var queryBuilder = new DiscountCodeFreeShippingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}