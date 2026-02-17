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
    public sealed class DiscountEffectQueryBuilder : FieldsQueryBuilderBase<DiscountEffect, DiscountEffectQueryBuilder>
    {
        protected override DiscountEffectQueryBuilder Self => this;

        public DiscountEffectQueryBuilder() : this("discountEffect")
        {
        }

        public DiscountEffectQueryBuilder(string name) : base(new Query<DiscountEffect>(name))
        {
        }

        public DiscountEffectQueryBuilder(IQuery<DiscountEffect> query) : base(query)
        {
        }

        public DiscountEffectQueryBuilder DiscountEffect(Action<DiscountEffectUnionCasesBuilder> build)
        {
            var query = new Query<DiscountEffect>("discountEffect");
            var unionBuilder = new DiscountEffectUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}