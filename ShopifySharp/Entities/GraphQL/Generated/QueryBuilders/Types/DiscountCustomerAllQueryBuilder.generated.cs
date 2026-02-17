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
    public sealed class DiscountCustomerAllQueryBuilder : FieldsQueryBuilderBase<DiscountCustomerAll, DiscountCustomerAllQueryBuilder>
    {
        protected override DiscountCustomerAllQueryBuilder Self => this;

        public DiscountCustomerAllQueryBuilder() : this("discountCustomerAll")
        {
        }

        public DiscountCustomerAllQueryBuilder(string name) : base(new Query<DiscountCustomerAll>(name))
        {
        }

        public DiscountCustomerAllQueryBuilder(IQuery<DiscountCustomerAll> query) : base(query)
        {
        }

        public DiscountCustomerAllQueryBuilder AllCustomers()
        {
            base.InnerQuery.AddField("allCustomers");
            return this;
        }
    }
}