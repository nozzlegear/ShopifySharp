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
    public sealed class DiscountCustomerGetsValueQueryBuilder : FieldsQueryBuilderBase<DiscountCustomerGetsValue, DiscountCustomerGetsValueQueryBuilder>
    {
        protected override DiscountCustomerGetsValueQueryBuilder Self => this;

        public DiscountCustomerGetsValueQueryBuilder() : this("discountCustomerGetsValue")
        {
        }

        public DiscountCustomerGetsValueQueryBuilder(string name) : base(new Query<DiscountCustomerGetsValue>(name))
        {
        }

        public DiscountCustomerGetsValueQueryBuilder(IQuery<DiscountCustomerGetsValue> query) : base(query)
        {
        }

        public DiscountCustomerGetsValueQueryBuilder DiscountCustomerGetsValue(Action<DiscountCustomerGetsValueUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCustomerGetsValue>("discountCustomerGetsValue");
            var unionBuilder = new DiscountCustomerGetsValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}