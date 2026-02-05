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
    public sealed class TranslationsRemoveArgumentsBuilder : ArgumentsBuilderBase<TranslationsRemovePayload, TranslationsRemoveArgumentsBuilder>
    {
        protected override TranslationsRemoveArgumentsBuilder Self => this;

        public TranslationsRemoveArgumentsBuilder(IQuery<TranslationsRemovePayload> query) : base(query)
        {
        }

        public TranslationsRemoveArgumentsBuilder Locales(ICollection<string>? locales)
        {
            base.InnerQuery.AddArgument("locales", locales);
            return this;
        }

        public TranslationsRemoveArgumentsBuilder MarketIds(ICollection<string>? marketIds)
        {
            base.InnerQuery.AddArgument("marketIds", marketIds);
            return this;
        }

        public TranslationsRemoveArgumentsBuilder ResourceId(string? resourceId)
        {
            base.InnerQuery.AddArgument("resourceId", resourceId);
            return this;
        }

        public TranslationsRemoveArgumentsBuilder TranslationKeys(ICollection<string>? translationKeys)
        {
            base.InnerQuery.AddArgument("translationKeys", translationKeys);
            return this;
        }
    }
}