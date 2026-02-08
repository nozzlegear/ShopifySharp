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
    public sealed class DiscountCustomersQueryBuilder : FieldsQueryBuilderBase<DiscountCustomers, DiscountCustomersQueryBuilder>
    {
        protected override DiscountCustomersQueryBuilder Self => this;

        public DiscountCustomersQueryBuilder() : this("discountCustomers")
        {
        }

        public DiscountCustomersQueryBuilder(string name) : base(new Query<DiscountCustomers>(name))
        {
        }

        public DiscountCustomersQueryBuilder(IQuery<DiscountCustomers> query) : base(query)
        {
        }

        public DiscountCustomersQueryBuilder Customers(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customers");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }
    }
}