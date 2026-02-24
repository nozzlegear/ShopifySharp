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
    public sealed class TaxonomyCategoriesArgumentsBuilder : ArgumentsBuilderBase<TaxonomyCategoryConnection?, TaxonomyCategoriesArgumentsBuilder>
    {
        protected override TaxonomyCategoriesArgumentsBuilder Self => this;

        public TaxonomyCategoriesArgumentsBuilder(IQuery<TaxonomyCategoryConnection?> query) : base(query)
        {
        }

        public TaxonomyCategoriesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public TaxonomyCategoriesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public TaxonomyCategoriesArgumentsBuilder ChildrenOf(string? childrenOf)
        {
            base.InnerQuery.AddArgument("childrenOf", childrenOf);
            return this;
        }

        public TaxonomyCategoriesArgumentsBuilder DescendantsOf(string? descendantsOf)
        {
            base.InnerQuery.AddArgument("descendantsOf", descendantsOf);
            return this;
        }

        public TaxonomyCategoriesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public TaxonomyCategoriesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public TaxonomyCategoriesArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }

        public TaxonomyCategoriesArgumentsBuilder SiblingsOf(string? siblingsOf)
        {
            base.InnerQuery.AddArgument("siblingsOf", siblingsOf);
            return this;
        }
    }
}