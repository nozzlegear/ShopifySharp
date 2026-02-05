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
    public sealed class ShopResourceLimitsQueryBuilder : FieldsQueryBuilderBase<ShopResourceLimits, ShopResourceLimitsQueryBuilder>
    {
        protected override ShopResourceLimitsQueryBuilder Self => this;

        public ShopResourceLimitsQueryBuilder() : this("shopResourceLimits")
        {
        }

        public ShopResourceLimitsQueryBuilder(string name) : base(new Query<ShopResourceLimits>(name))
        {
        }

        public ShopResourceLimitsQueryBuilder(IQuery<ShopResourceLimits> query) : base(query)
        {
        }

        public ShopResourceLimitsQueryBuilder LocationLimit()
        {
            base.InnerQuery.AddField("locationLimit");
            return this;
        }

        public ShopResourceLimitsQueryBuilder MaxProductOptions()
        {
            base.InnerQuery.AddField("maxProductOptions");
            return this;
        }

        public ShopResourceLimitsQueryBuilder MaxProductVariants()
        {
            base.InnerQuery.AddField("maxProductVariants");
            return this;
        }

        public ShopResourceLimitsQueryBuilder RedirectLimitReached()
        {
            base.InnerQuery.AddField("redirectLimitReached");
            return this;
        }
    }
}