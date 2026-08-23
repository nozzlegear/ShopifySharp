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
    public sealed class DiscountAutomaticUnionCasesBuilder : UnionCasesBuilderBase<DiscountAutomatic, DiscountAutomaticUnionCasesBuilder>
    {
        protected override DiscountAutomaticUnionCasesBuilder Self => this;

        public DiscountAutomaticUnionCasesBuilder(string fieldName = "nodes") : this(new Query<DiscountAutomatic>(fieldName))
        {
        }

        public DiscountAutomaticUnionCasesBuilder(IQuery<DiscountAutomatic> query) : base(query)
        {
        }

        public DiscountAutomaticUnionCasesBuilder OnDiscountAutomaticApp(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticApp>("... on DiscountAutomaticApp");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountAutomaticUnionCasesBuilder OnDiscountAutomaticBasic(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBasicQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticBasic>("... on DiscountAutomaticBasic");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBasicQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountAutomaticUnionCasesBuilder OnDiscountAutomaticBxgy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBxgyQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticBxgy>("... on DiscountAutomaticBxgy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBxgyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountAutomaticUnionCasesBuilder OnDiscountAutomaticFreeShipping(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticFreeShippingQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticFreeShipping>("... on DiscountAutomaticFreeShipping");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticFreeShippingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}