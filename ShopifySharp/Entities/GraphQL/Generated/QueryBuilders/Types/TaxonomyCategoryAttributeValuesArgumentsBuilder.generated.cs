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
    public sealed class TaxonomyCategoryAttributeValuesArgumentsBuilder : ArgumentsBuilderBase<TaxonomyValueConnection?, TaxonomyCategoryAttributeValuesArgumentsBuilder>
    {
        protected override TaxonomyCategoryAttributeValuesArgumentsBuilder Self => this;

        public TaxonomyCategoryAttributeValuesArgumentsBuilder(IQuery<TaxonomyValueConnection?> query) : base(query)
        {
        }

        public TaxonomyCategoryAttributeValuesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public TaxonomyCategoryAttributeValuesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public TaxonomyCategoryAttributeValuesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public TaxonomyCategoryAttributeValuesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }
    }
}