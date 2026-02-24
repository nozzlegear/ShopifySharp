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
    public sealed class QuantityRuleConnectionArgumentsBuilder : ArgumentsBuilderBase<QuantityRuleConnection, QuantityRuleConnectionArgumentsBuilder>
    {
        protected override QuantityRuleConnectionArgumentsBuilder Self => this;

        public QuantityRuleConnectionArgumentsBuilder(IQuery<QuantityRuleConnection> query) : base(query)
        {
        }

        public QuantityRuleConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QuantityRuleConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QuantityRuleConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QuantityRuleConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QuantityRuleConnectionArgumentsBuilder OriginType(QuantityRuleOriginType? originType)
        {
            base.InnerQuery.AddArgument("originType", originType);
            return this;
        }

        public QuantityRuleConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}