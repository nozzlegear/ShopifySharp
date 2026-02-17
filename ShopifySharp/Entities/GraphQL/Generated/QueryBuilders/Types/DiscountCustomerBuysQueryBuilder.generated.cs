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
    public sealed class DiscountCustomerBuysQueryBuilder : FieldsQueryBuilderBase<DiscountCustomerBuys, DiscountCustomerBuysQueryBuilder>
    {
        protected override DiscountCustomerBuysQueryBuilder Self => this;

        public DiscountCustomerBuysQueryBuilder() : this("discountCustomerBuys")
        {
        }

        public DiscountCustomerBuysQueryBuilder(string name) : base(new Query<DiscountCustomerBuys>(name))
        {
        }

        public DiscountCustomerBuysQueryBuilder(IQuery<DiscountCustomerBuys> query) : base(query)
        {
        }

        public DiscountCustomerBuysQueryBuilder IsOneTimePurchase()
        {
            base.InnerQuery.AddField("isOneTimePurchase");
            return this;
        }

        public DiscountCustomerBuysQueryBuilder IsSubscription()
        {
            base.InnerQuery.AddField("isSubscription");
            return this;
        }

        public DiscountCustomerBuysQueryBuilder Items(Action<DiscountItemsUnionCasesBuilder> build)
        {
            var query = new Query<DiscountItems>("items");
            var unionBuilder = new DiscountItemsUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public DiscountCustomerBuysQueryBuilder Value(Action<DiscountCustomerBuysValueUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCustomerBuysValue>("value");
            var unionBuilder = new DiscountCustomerBuysValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}