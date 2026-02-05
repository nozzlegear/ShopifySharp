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
    public sealed class DiscountCustomerGetsQueryBuilder : FieldsQueryBuilderBase<DiscountCustomerGets, DiscountCustomerGetsQueryBuilder>
    {
        protected override DiscountCustomerGetsQueryBuilder Self => this;

        public DiscountCustomerGetsQueryBuilder() : this("discountCustomerGets")
        {
        }

        public DiscountCustomerGetsQueryBuilder(string name) : base(new Query<DiscountCustomerGets>(name))
        {
        }

        public DiscountCustomerGetsQueryBuilder(IQuery<DiscountCustomerGets> query) : base(query)
        {
        }

        public DiscountCustomerGetsQueryBuilder AppliesOnOneTimePurchase()
        {
            base.InnerQuery.AddField("appliesOnOneTimePurchase");
            return this;
        }

        public DiscountCustomerGetsQueryBuilder AppliesOnSubscription()
        {
            base.InnerQuery.AddField("appliesOnSubscription");
            return this;
        }

        public DiscountCustomerGetsQueryBuilder Items(Action<DiscountItemsUnionCasesBuilder> build)
        {
            var query = new Query<DiscountItems>("items");
            var unionBuilder = new DiscountItemsUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public DiscountCustomerGetsQueryBuilder Value(Action<DiscountCustomerGetsValueUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCustomerGetsValue>("value");
            var unionBuilder = new DiscountCustomerGetsValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}