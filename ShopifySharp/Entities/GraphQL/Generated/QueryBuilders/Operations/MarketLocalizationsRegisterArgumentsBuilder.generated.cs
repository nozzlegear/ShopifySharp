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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class MarketLocalizationsRegisterArgumentsBuilder : ArgumentsBuilderBase<MarketLocalizationsRegisterPayload, MarketLocalizationsRegisterArgumentsBuilder>
    {
        protected override MarketLocalizationsRegisterArgumentsBuilder Self => this;

        public MarketLocalizationsRegisterArgumentsBuilder(IQuery<MarketLocalizationsRegisterPayload> query) : base(query)
        {
        }

        public MarketLocalizationsRegisterArgumentsBuilder MarketLocalizations(ICollection<MarketLocalizationRegisterInput>? marketLocalizations)
        {
            base.InnerQuery.AddArgument("marketLocalizations", marketLocalizations);
            return this;
        }

        public MarketLocalizationsRegisterArgumentsBuilder ResourceId(string? resourceId)
        {
            base.InnerQuery.AddArgument("resourceId", resourceId);
            return this;
        }
    }
}