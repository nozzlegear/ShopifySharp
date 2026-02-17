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
    public sealed class DiscountCodeUnionCasesBuilder : UnionCasesBuilderBase<DiscountCode, DiscountCodeUnionCasesBuilder>
    {
        protected override DiscountCodeUnionCasesBuilder Self => this;

        public DiscountCodeUnionCasesBuilder(string fieldName = "codeDiscount") : this(new Query<DiscountCode>(fieldName))
        {
        }

        public DiscountCodeUnionCasesBuilder(IQuery<DiscountCode> query) : base(query)
        {
        }

        public DiscountCodeUnionCasesBuilder OnDiscountCodeApp(Action<DiscountCodeAppQueryBuilder> build)
        {
            var query = new Query<DiscountCodeApp>("... on DiscountCodeApp");
            var queryBuilder = new DiscountCodeAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountCodeUnionCasesBuilder OnDiscountCodeBasic(Action<DiscountCodeBasicQueryBuilder> build)
        {
            var query = new Query<DiscountCodeBasic>("... on DiscountCodeBasic");
            var queryBuilder = new DiscountCodeBasicQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountCodeUnionCasesBuilder OnDiscountCodeBxgy(Action<DiscountCodeBxgyQueryBuilder> build)
        {
            var query = new Query<DiscountCodeBxgy>("... on DiscountCodeBxgy");
            var queryBuilder = new DiscountCodeBxgyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountCodeUnionCasesBuilder OnDiscountCodeFreeShipping(Action<DiscountCodeFreeShippingQueryBuilder> build)
        {
            var query = new Query<DiscountCodeFreeShipping>("... on DiscountCodeFreeShipping");
            var queryBuilder = new DiscountCodeFreeShippingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}