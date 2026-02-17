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

        public OrderStagedChangeRemoveDiscountQueryBuilder DiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationQueryBuilder> build)
        {
            var query = new Query<IDiscountApplication>("discountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IDiscountApplication>(query);
            return this;
        }
    }
}