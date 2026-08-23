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
    public sealed class DiscountCustomerGetsValueUnionCasesBuilder : UnionCasesBuilderBase<DiscountCustomerGetsValue, DiscountCustomerGetsValueUnionCasesBuilder>
    {
        protected override DiscountCustomerGetsValueUnionCasesBuilder Self => this;

        public DiscountCustomerGetsValueUnionCasesBuilder(string fieldName = "discountCustomerGetsValue") : this(new Query<DiscountCustomerGetsValue>(fieldName))
        {
        }

        public DiscountCustomerGetsValueUnionCasesBuilder(IQuery<DiscountCustomerGetsValue> query) : base(query)
        {
        }

        public DiscountCustomerGetsValueUnionCasesBuilder OnDiscountAmount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAmountQueryBuilder> build)
        {
            var query = new Query<DiscountAmount>("... on DiscountAmount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAmountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountCustomerGetsValueUnionCasesBuilder OnDiscountOnQuantity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountOnQuantityQueryBuilder> build)
        {
            var query = new Query<DiscountOnQuantity>("... on DiscountOnQuantity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountOnQuantityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountCustomerGetsValueUnionCasesBuilder OnDiscountPercentage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountPercentageQueryBuilder> build)
        {
            var query = new Query<DiscountPercentage>("... on DiscountPercentage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountPercentageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}