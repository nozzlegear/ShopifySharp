#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class PageCreateArgumentsBuilder : ArgumentsBuilderBase<PageCreatePayload, PageCreateArgumentsBuilder>
    {
        protected override PageCreateArgumentsBuilder Self => this;

        public PageCreateArgumentsBuilder(IQuery<PageCreatePayload> query) : base(query)
        {
        }

        public PageCreateArgumentsBuilder Page(PageCreateInput? page)
        {
            base.InnerQuery.AddArgument("page", page);
            return this;
        }
    }
}