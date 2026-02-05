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
    public sealed class ShopifyProtectOrderEligibilityQueryBuilder : FieldsQueryBuilderBase<ShopifyProtectOrderEligibility, ShopifyProtectOrderEligibilityQueryBuilder>
    {
        protected override ShopifyProtectOrderEligibilityQueryBuilder Self => this;

        public ShopifyProtectOrderEligibilityQueryBuilder() : this("shopifyProtectOrderEligibility")
        {
        }

        public ShopifyProtectOrderEligibilityQueryBuilder(string name) : base(new Query<ShopifyProtectOrderEligibility>(name))
        {
        }

        public ShopifyProtectOrderEligibilityQueryBuilder(IQuery<ShopifyProtectOrderEligibility> query) : base(query)
        {
        }

        public ShopifyProtectOrderEligibilityQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}