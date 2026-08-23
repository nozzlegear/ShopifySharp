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
    public sealed class CommentEventEmbedLocalizedFieldsArgumentsBuilder : ArgumentsBuilderBase<LocalizedFieldConnection?, CommentEventEmbedLocalizedFieldsArgumentsBuilder>
    {
        protected override CommentEventEmbedLocalizedFieldsArgumentsBuilder Self => this;

        public CommentEventEmbedLocalizedFieldsArgumentsBuilder(IQuery<LocalizedFieldConnection?> query) : base(query)
        {
        }

        public CommentEventEmbedLocalizedFieldsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CommentEventEmbedLocalizedFieldsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CommentEventEmbedLocalizedFieldsArgumentsBuilder CountryCodes(ICollection<CountryCode>? countryCodes)
        {
            base.InnerQuery.AddArgument("countryCodes", countryCodes);
            return this;
        }

        public CommentEventEmbedLocalizedFieldsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CommentEventEmbedLocalizedFieldsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CommentEventEmbedLocalizedFieldsArgumentsBuilder Purposes(ICollection<LocalizedFieldPurpose>? purposes)
        {
            base.InnerQuery.AddArgument("purposes", purposes);
            return this;
        }

        public CommentEventEmbedLocalizedFieldsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}