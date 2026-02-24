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
    public sealed class TaxonomyCategoryAttributeConnectionArgumentsBuilder : ArgumentsBuilderBase<TaxonomyCategoryAttributeConnection, TaxonomyCategoryAttributeConnectionArgumentsBuilder>
    {
        protected override TaxonomyCategoryAttributeConnectionArgumentsBuilder Self => this;

        public TaxonomyCategoryAttributeConnectionArgumentsBuilder(IQuery<TaxonomyCategoryAttributeConnection> query) : base(query)
        {
        }

        public TaxonomyCategoryAttributeConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public TaxonomyCategoryAttributeConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public TaxonomyCategoryAttributeConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public TaxonomyCategoryAttributeConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }
    }
}