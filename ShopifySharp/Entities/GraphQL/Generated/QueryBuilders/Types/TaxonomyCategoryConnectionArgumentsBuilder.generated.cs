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
    public sealed class TaxonomyCategoryConnectionArgumentsBuilder : ArgumentsBuilderBase<TaxonomyCategoryConnection, TaxonomyCategoryConnectionArgumentsBuilder>
    {
        protected override TaxonomyCategoryConnectionArgumentsBuilder Self => this;

        public TaxonomyCategoryConnectionArgumentsBuilder(IQuery<TaxonomyCategoryConnection> query) : base(query)
        {
        }

        public TaxonomyCategoryConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public TaxonomyCategoryConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public TaxonomyCategoryConnectionArgumentsBuilder ChildrenOf(string? childrenOf)
        {
            base.InnerQuery.AddArgument("childrenOf", childrenOf);
            return this;
        }

        public TaxonomyCategoryConnectionArgumentsBuilder DescendantsOf(string? descendantsOf)
        {
            base.InnerQuery.AddArgument("descendantsOf", descendantsOf);
            return this;
        }

        public TaxonomyCategoryConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public TaxonomyCategoryConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public TaxonomyCategoryConnectionArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }

        public TaxonomyCategoryConnectionArgumentsBuilder SiblingsOf(string? siblingsOf)
        {
            base.InnerQuery.AddArgument("siblingsOf", siblingsOf);
            return this;
        }
    }
}