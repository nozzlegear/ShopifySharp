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
    public sealed class OrderStagedChangeQueryBuilder : FieldsQueryBuilderBase<OrderStagedChange, OrderStagedChangeQueryBuilder>
    {
        protected override OrderStagedChangeQueryBuilder Self => this;

        public OrderStagedChangeQueryBuilder() : this("orderStagedChange")
        {
        }

        public OrderStagedChangeQueryBuilder(string name) : base(new Query<OrderStagedChange>(name))
        {
        }

        public OrderStagedChangeQueryBuilder(IQuery<OrderStagedChange> query) : base(query)
        {
        }

        public OrderStagedChangeQueryBuilder OrderStagedChange(Action<OrderStagedChangeUnionCasesBuilder> build)
        {
            var query = new Query<OrderStagedChange>("orderStagedChange");
            var unionBuilder = new OrderStagedChangeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}