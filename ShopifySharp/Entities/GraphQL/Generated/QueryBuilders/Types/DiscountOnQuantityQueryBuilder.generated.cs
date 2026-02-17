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
    public sealed class DiscountOnQuantityQueryBuilder : FieldsQueryBuilderBase<DiscountOnQuantity, DiscountOnQuantityQueryBuilder>
    {
        protected override DiscountOnQuantityQueryBuilder Self => this;

        public DiscountOnQuantityQueryBuilder() : this("discountOnQuantity")
        {
        }

        public DiscountOnQuantityQueryBuilder(string name) : base(new Query<DiscountOnQuantity>(name))
        {
        }

        public DiscountOnQuantityQueryBuilder(IQuery<DiscountOnQuantity> query) : base(query)
        {
        }

        public DiscountOnQuantityQueryBuilder Quantity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountQuantityQueryBuilder> build)
        {
            var query = new Query<DiscountQuantity>("quantity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountQuantityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountQuantity>(query);
            return this;
        }

        public DiscountOnQuantityQueryBuilder Effect(Action<DiscountEffectUnionCasesBuilder> build)
        {
            var query = new Query<DiscountEffect>("effect");
            var unionBuilder = new DiscountEffectUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}