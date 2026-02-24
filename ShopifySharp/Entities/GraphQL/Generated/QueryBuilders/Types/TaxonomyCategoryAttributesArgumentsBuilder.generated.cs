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
    public sealed class TaxonomyCategoryAttributesArgumentsBuilder : ArgumentsBuilderBase<TaxonomyCategoryAttributeConnection?, TaxonomyCategoryAttributesArgumentsBuilder>
    {
        protected override TaxonomyCategoryAttributesArgumentsBuilder Self => this;

        public TaxonomyCategoryAttributesArgumentsBuilder(IQuery<TaxonomyCategoryAttributeConnection?> query) : base(query)
        {
        }

        public TaxonomyCategoryAttributesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public TaxonomyCategoryAttributesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public TaxonomyCategoryAttributesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public TaxonomyCategoryAttributesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }
    }
}