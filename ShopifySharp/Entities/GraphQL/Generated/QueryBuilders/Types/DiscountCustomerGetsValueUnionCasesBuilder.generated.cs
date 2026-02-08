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
    public sealed class DiscountCustomerGetsValueUnionCasesBuilder : UnionCasesBuilderBase<DiscountCustomerGetsValue, DiscountCustomerGetsValueUnionCasesBuilder>
    {
        protected override DiscountCustomerGetsValueUnionCasesBuilder Self => this;

        public DiscountCustomerGetsValueUnionCasesBuilder(string fieldName = "discountCustomerGetsValue") : this(new Query<DiscountCustomerGetsValue>(fieldName))
        {
        }

        public DiscountCustomerGetsValueUnionCasesBuilder(IQuery<DiscountCustomerGetsValue> query) : base(query)
        {
        }

        public DiscountCustomerGetsValueUnionCasesBuilder OnDiscountAmount(Action<DiscountAmountQueryBuilder> build)
        {
            var query = new Query<DiscountAmount>("... on DiscountAmount");
            var queryBuilder = new DiscountAmountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountCustomerGetsValueUnionCasesBuilder OnDiscountOnQuantity(Action<DiscountOnQuantityQueryBuilder> build)
        {
            var query = new Query<DiscountOnQuantity>("... on DiscountOnQuantity");
            var queryBuilder = new DiscountOnQuantityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountCustomerGetsValueUnionCasesBuilder OnDiscountPercentage(Action<DiscountPercentageQueryBuilder> build)
        {
            var query = new Query<DiscountPercentage>("... on DiscountPercentage");
            var queryBuilder = new DiscountPercentageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}