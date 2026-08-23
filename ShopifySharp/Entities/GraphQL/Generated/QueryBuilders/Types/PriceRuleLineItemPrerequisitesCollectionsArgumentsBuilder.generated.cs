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
    public sealed class PriceRuleLineItemPrerequisitesCollectionsArgumentsBuilder : ArgumentsBuilderBase<CollectionConnection?, PriceRuleLineItemPrerequisitesCollectionsArgumentsBuilder>
    {
        protected override PriceRuleLineItemPrerequisitesCollectionsArgumentsBuilder Self => this;

        public PriceRuleLineItemPrerequisitesCollectionsArgumentsBuilder(IQuery<CollectionConnection?> query) : base(query)
        {
        }

        public PriceRuleLineItemPrerequisitesCollectionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public PriceRuleLineItemPrerequisitesCollectionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public PriceRuleLineItemPrerequisitesCollectionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public PriceRuleLineItemPrerequisitesCollectionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public PriceRuleLineItemPrerequisitesCollectionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}