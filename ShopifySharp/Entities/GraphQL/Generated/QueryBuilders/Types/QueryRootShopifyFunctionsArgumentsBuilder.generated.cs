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
    public sealed class QueryRootShopifyFunctionsArgumentsBuilder : ArgumentsBuilderBase<ShopifyFunctionConnection?, QueryRootShopifyFunctionsArgumentsBuilder>
    {
        protected override QueryRootShopifyFunctionsArgumentsBuilder Self => this;

        public QueryRootShopifyFunctionsArgumentsBuilder(IQuery<ShopifyFunctionConnection?> query) : base(query)
        {
        }

        public QueryRootShopifyFunctionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootShopifyFunctionsArgumentsBuilder ApiType(string? apiType)
        {
            base.InnerQuery.AddArgument("apiType", apiType);
            return this;
        }

        public QueryRootShopifyFunctionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootShopifyFunctionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootShopifyFunctionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootShopifyFunctionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootShopifyFunctionsArgumentsBuilder UseCreationUi(bool? useCreationUi)
        {
            base.InnerQuery.AddArgument("useCreationUi", useCreationUi);
            return this;
        }
    }
}