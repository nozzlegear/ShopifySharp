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
    public sealed class DiscountEffectUnionCasesBuilder : UnionCasesBuilderBase<DiscountEffect, DiscountEffectUnionCasesBuilder>
    {
        protected override DiscountEffectUnionCasesBuilder Self => this;

        public DiscountEffectUnionCasesBuilder(string fieldName = "effect") : this(new Query<DiscountEffect>(fieldName))
        {
        }

        public DiscountEffectUnionCasesBuilder(IQuery<DiscountEffect> query) : base(query)
        {
        }

        public DiscountEffectUnionCasesBuilder OnDiscountAmount(Action<DiscountAmountQueryBuilder> build)
        {
            var query = new Query<DiscountAmount>("... on DiscountAmount");
            var queryBuilder = new DiscountAmountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountEffectUnionCasesBuilder OnDiscountPercentage(Action<DiscountPercentageQueryBuilder> build)
        {
            var query = new Query<DiscountPercentage>("... on DiscountPercentage");
            var queryBuilder = new DiscountPercentageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}