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