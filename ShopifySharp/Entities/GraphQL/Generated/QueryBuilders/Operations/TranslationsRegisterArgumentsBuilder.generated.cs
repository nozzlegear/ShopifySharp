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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
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