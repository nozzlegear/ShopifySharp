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
    public sealed class MetafieldReferencerLocalizedFieldsArgumentsBuilder : ArgumentsBuilderBase<LocalizedFieldConnection?, MetafieldReferencerLocalizedFieldsArgumentsBuilder>
    {
        protected override MetafieldReferencerLocalizedFieldsArgumentsBuilder Self => this;

        public MetafieldReferencerLocalizedFieldsArgumentsBuilder(IQuery<LocalizedFieldConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerLocalizedFieldsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferencerLocalizedFieldsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldReferencerLocalizedFieldsArgumentsBuilder CountryCodes(ICollection<CountryCode>? countryCodes)
        {
            base.InnerQuery.AddArgument("countryCodes", countryCodes);
            return this;
        }

        public MetafieldReferencerLocalizedFieldsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferencerLocalizedFieldsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldReferencerLocalizedFieldsArgumentsBuilder Purposes(ICollection<LocalizedFieldPurpose>? purposes)
        {
            base.InnerQuery.AddArgument("purposes", purposes);
            return this;
        }

        public MetafieldReferencerLocalizedFieldsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}