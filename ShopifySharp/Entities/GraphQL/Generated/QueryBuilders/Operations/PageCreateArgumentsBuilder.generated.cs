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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
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