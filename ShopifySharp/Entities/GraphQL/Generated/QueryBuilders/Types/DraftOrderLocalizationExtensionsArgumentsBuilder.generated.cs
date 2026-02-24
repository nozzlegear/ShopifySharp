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
    public sealed class DraftOrderLocalizationExtensionsArgumentsBuilder : ArgumentsBuilderBase<LocalizationExtensionConnection?, DraftOrderLocalizationExtensionsArgumentsBuilder>
    {
        protected override DraftOrderLocalizationExtensionsArgumentsBuilder Self => this;

        public DraftOrderLocalizationExtensionsArgumentsBuilder(IQuery<LocalizationExtensionConnection?> query) : base(query)
        {
        }

        public DraftOrderLocalizationExtensionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DraftOrderLocalizationExtensionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DraftOrderLocalizationExtensionsArgumentsBuilder CountryCodes(ICollection<CountryCode>? countryCodes)
        {
            base.InnerQuery.AddArgument("countryCodes", countryCodes);
            return this;
        }

        public DraftOrderLocalizationExtensionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DraftOrderLocalizationExtensionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DraftOrderLocalizationExtensionsArgumentsBuilder Purposes(ICollection<LocalizationExtensionPurpose>? purposes)
        {
            base.InnerQuery.AddArgument("purposes", purposes);
            return this;
        }

        public DraftOrderLocalizationExtensionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}