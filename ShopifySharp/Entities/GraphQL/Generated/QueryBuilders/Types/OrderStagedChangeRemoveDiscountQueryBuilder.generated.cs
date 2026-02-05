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
    public sealed class OrderStagedChangeRemoveDiscountQueryBuilder : FieldsQueryBuilderBase<OrderStagedChangeRemoveDiscount, OrderStagedChangeRemoveDiscountQueryBuilder>
    {
        protected override OrderStagedChangeRemoveDiscountQueryBuilder Self => this;

        public OrderStagedChangeRemoveDiscountQueryBuilder() : this("orderStagedChangeRemoveDiscount")
        {
        }

        public OrderStagedChangeRemoveDiscountQueryBuilder(string name) : base(new Query<OrderStagedChangeRemoveDiscount>(name))
        {
        }

        public OrderStagedChangeRemoveDiscountQueryBuilder(IQuery<OrderStagedChangeRemoveDiscount> query) : base(query)
        {
        }

        public OrderStagedChangeRemoveDiscountQueryBuilder DiscountApplication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationQueryBuilder> build)
        {
            var query = new Query<IDiscountApplication>("discountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IDiscountApplication>(query);
            return this;
        }
    }
}