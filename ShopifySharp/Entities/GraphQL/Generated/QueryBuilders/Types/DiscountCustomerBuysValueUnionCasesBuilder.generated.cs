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
    public sealed class DiscountCustomerBuysValueUnionCasesBuilder : UnionCasesBuilderBase<DiscountCustomerBuysValue, DiscountCustomerBuysValueUnionCasesBuilder>
    {
        protected override DiscountCustomerBuysValueUnionCasesBuilder Self => this;

        public DiscountCustomerBuysValueUnionCasesBuilder(string fieldName = "discountCustomerBuysValue") : this(new Query<DiscountCustomerBuysValue>(fieldName))
        {
        }

        public DiscountCustomerBuysValueUnionCasesBuilder(IQuery<DiscountCustomerBuysValue> query) : base(query)
        {
        }

        public DiscountCustomerBuysValueUnionCasesBuilder OnDiscountPurchaseAmount(Action<DiscountPurchaseAmountQueryBuilder> build)
        {
            var query = new Query<DiscountPurchaseAmount>("... on DiscountPurchaseAmount");
            var queryBuilder = new DiscountPurchaseAmountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountCustomerBuysValueUnionCasesBuilder OnDiscountQuantity(Action<DiscountQuantityQueryBuilder> build)
        {
            var query = new Query<DiscountQuantity>("... on DiscountQuantity");
            var queryBuilder = new DiscountQuantityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}