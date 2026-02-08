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
    public sealed class DiscountCustomerBuysValueQueryBuilder : FieldsQueryBuilderBase<DiscountCustomerBuysValue, DiscountCustomerBuysValueQueryBuilder>
    {
        protected override DiscountCustomerBuysValueQueryBuilder Self => this;

        public DiscountCustomerBuysValueQueryBuilder() : this("discountCustomerBuysValue")
        {
        }

        public DiscountCustomerBuysValueQueryBuilder(string name) : base(new Query<DiscountCustomerBuysValue>(name))
        {
        }

        public DiscountCustomerBuysValueQueryBuilder(IQuery<DiscountCustomerBuysValue> query) : base(query)
        {
        }

        public DiscountCustomerBuysValueQueryBuilder DiscountCustomerBuysValue(Action<DiscountCustomerBuysValueUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCustomerBuysValue>("discountCustomerBuysValue");
            var unionBuilder = new DiscountCustomerBuysValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}