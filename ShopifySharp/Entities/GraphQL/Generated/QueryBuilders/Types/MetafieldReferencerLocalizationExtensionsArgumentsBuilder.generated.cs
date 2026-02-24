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
    public sealed class MetafieldReferencerLocalizationExtensionsArgumentsBuilder : ArgumentsBuilderBase<LocalizationExtensionConnection?, MetafieldReferencerLocalizationExtensionsArgumentsBuilder>
    {
        protected override MetafieldReferencerLocalizationExtensionsArgumentsBuilder Self => this;

        public MetafieldReferencerLocalizationExtensionsArgumentsBuilder(IQuery<LocalizationExtensionConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerLocalizationExtensionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferencerLocalizationExtensionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldReferencerLocalizationExtensionsArgumentsBuilder CountryCodes(ICollection<CountryCode>? countryCodes)
        {
            base.InnerQuery.AddArgument("countryCodes", countryCodes);
            return this;
        }

        public MetafieldReferencerLocalizationExtensionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferencerLocalizationExtensionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldReferencerLocalizationExtensionsArgumentsBuilder Purposes(ICollection<LocalizationExtensionPurpose>? purposes)
        {
            base.InnerQuery.AddArgument("purposes", purposes);
            return this;
        }

        public MetafieldReferencerLocalizationExtensionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}