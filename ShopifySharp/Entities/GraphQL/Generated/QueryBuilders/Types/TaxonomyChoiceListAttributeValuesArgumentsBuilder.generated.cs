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
    public sealed class TaxonomyChoiceListAttributeValuesArgumentsBuilder : ArgumentsBuilderBase<TaxonomyValueConnection?, TaxonomyChoiceListAttributeValuesArgumentsBuilder>
    {
        protected override TaxonomyChoiceListAttributeValuesArgumentsBuilder Self => this;

        public TaxonomyChoiceListAttributeValuesArgumentsBuilder(IQuery<TaxonomyValueConnection?> query) : base(query)
        {
        }

        public TaxonomyChoiceListAttributeValuesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public TaxonomyChoiceListAttributeValuesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public TaxonomyChoiceListAttributeValuesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public TaxonomyChoiceListAttributeValuesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }
    }
}