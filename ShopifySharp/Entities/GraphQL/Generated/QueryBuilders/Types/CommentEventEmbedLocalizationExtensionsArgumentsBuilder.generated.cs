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
    public sealed class CommentEventEmbedLocalizationExtensionsArgumentsBuilder : ArgumentsBuilderBase<LocalizationExtensionConnection?, CommentEventEmbedLocalizationExtensionsArgumentsBuilder>
    {
        protected override CommentEventEmbedLocalizationExtensionsArgumentsBuilder Self => this;

        public CommentEventEmbedLocalizationExtensionsArgumentsBuilder(IQuery<LocalizationExtensionConnection?> query) : base(query)
        {
        }

        public CommentEventEmbedLocalizationExtensionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CommentEventEmbedLocalizationExtensionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CommentEventEmbedLocalizationExtensionsArgumentsBuilder CountryCodes(ICollection<CountryCode>? countryCodes)
        {
            base.InnerQuery.AddArgument("countryCodes", countryCodes);
            return this;
        }

        public CommentEventEmbedLocalizationExtensionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CommentEventEmbedLocalizationExtensionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CommentEventEmbedLocalizationExtensionsArgumentsBuilder Purposes(ICollection<LocalizationExtensionPurpose>? purposes)
        {
            base.InnerQuery.AddArgument("purposes", purposes);
            return this;
        }

        public CommentEventEmbedLocalizationExtensionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}