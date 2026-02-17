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
    public sealed class QuantityRuleQueryBuilder : FieldsQueryBuilderBase<QuantityRule, QuantityRuleQueryBuilder>
    {
        protected override QuantityRuleQueryBuilder Self => this;

        public QuantityRuleQueryBuilder() : this("quantityRule")
        {
        }

        public QuantityRuleQueryBuilder(string name) : base(new Query<QuantityRule>(name))
        {
        }

        public QuantityRuleQueryBuilder(IQuery<QuantityRule> query) : base(query)
        {
        }

        public QuantityRuleQueryBuilder Increment()
        {
            base.InnerQuery.AddField("increment");
            return this;
        }

        public QuantityRuleQueryBuilder IsDefault()
        {
            base.InnerQuery.AddField("isDefault");
            return this;
        }

        public QuantityRuleQueryBuilder Maximum()
        {
            base.InnerQuery.AddField("maximum");
            return this;
        }

        public QuantityRuleQueryBuilder Minimum()
        {
            base.InnerQuery.AddField("minimum");
            return this;
        }

        public QuantityRuleQueryBuilder OriginType()
        {
            base.InnerQuery.AddField("originType");
            return this;
        }

        public QuantityRuleQueryBuilder ProductVariant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }
    }
}