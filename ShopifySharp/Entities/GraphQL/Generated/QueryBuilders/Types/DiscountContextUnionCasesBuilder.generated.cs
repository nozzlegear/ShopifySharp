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
    public sealed class DiscountContextUnionCasesBuilder : UnionCasesBuilderBase<DiscountContext, DiscountContextUnionCasesBuilder>
    {
        protected override DiscountContextUnionCasesBuilder Self => this;

        public DiscountContextUnionCasesBuilder(string fieldName = "discountContext") : this(new Query<DiscountContext>(fieldName))
        {
        }

        public DiscountContextUnionCasesBuilder(IQuery<DiscountContext> query) : base(query)
        {
        }

        public DiscountContextUnionCasesBuilder OnDiscountBuyerSelectionAll(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountBuyerSelectionAllQueryBuilder> build)
        {
            var query = new Query<DiscountBuyerSelectionAll>("... on DiscountBuyerSelectionAll");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountBuyerSelectionAllQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountContextUnionCasesBuilder OnDiscountCustomerSegments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerSegmentsQueryBuilder> build)
        {
            var query = new Query<DiscountCustomerSegments>("... on DiscountCustomerSegments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerSegmentsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountContextUnionCasesBuilder OnDiscountCustomers(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomersQueryBuilder> build)
        {
            var query = new Query<DiscountCustomers>("... on DiscountCustomers");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomersQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountContextUnionCasesBuilder OnDiscountMarkets(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountMarketsQueryBuilder> build)
        {
            var query = new Query<DiscountMarkets>("... on DiscountMarkets");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountMarketsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}