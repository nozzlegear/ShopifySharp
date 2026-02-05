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
    public sealed class DiscountContextUnionCasesBuilder : UnionCasesBuilderBase<DiscountContext, DiscountContextUnionCasesBuilder>
    {
        protected override DiscountContextUnionCasesBuilder Self => this;

        public DiscountContextUnionCasesBuilder(string fieldName = "discountContext") : this(new Query<DiscountContext>(fieldName))
        {
        }

        public DiscountContextUnionCasesBuilder(IQuery<DiscountContext> query) : base(query)
        {
        }

        public DiscountContextUnionCasesBuilder OnDiscountBuyerSelectionAll(Action<DiscountBuyerSelectionAllQueryBuilder> build)
        {
            var query = new Query<DiscountBuyerSelectionAll>("... on DiscountBuyerSelectionAll");
            var queryBuilder = new DiscountBuyerSelectionAllQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountContextUnionCasesBuilder OnDiscountCustomerSegments(Action<DiscountCustomerSegmentsQueryBuilder> build)
        {
            var query = new Query<DiscountCustomerSegments>("... on DiscountCustomerSegments");
            var queryBuilder = new DiscountCustomerSegmentsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountContextUnionCasesBuilder OnDiscountCustomers(Action<DiscountCustomersQueryBuilder> build)
        {
            var query = new Query<DiscountCustomers>("... on DiscountCustomers");
            var queryBuilder = new DiscountCustomersQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}