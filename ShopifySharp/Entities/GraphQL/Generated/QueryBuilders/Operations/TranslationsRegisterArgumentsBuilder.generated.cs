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
    public sealed class TranslationsRegisterArgumentsBuilder : ArgumentsBuilderBase<TranslationsRegisterPayload, TranslationsRegisterArgumentsBuilder>
    {
        protected override TranslationsRegisterArgumentsBuilder Self => this;

        public TranslationsRegisterArgumentsBuilder(IQuery<TranslationsRegisterPayload> query) : base(query)
        {
        }

        public TranslationsRegisterArgumentsBuilder ResourceId(string? resourceId)
        {
            base.InnerQuery.AddArgument("resourceId", resourceId);
            return this;
        }

        public TranslationsRegisterArgumentsBuilder Translations(ICollection<TranslationInput>? translations)
        {
            base.InnerQuery.AddArgument("translations", translations);
            return this;
        }
    }
}