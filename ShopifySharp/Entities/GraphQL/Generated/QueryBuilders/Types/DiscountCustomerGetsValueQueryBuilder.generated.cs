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