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
    public sealed class ShopifyFunctionsArgumentsBuilder : ArgumentsBuilderBase<ShopifyFunctionConnection, ShopifyFunctionsArgumentsBuilder>
    {
        protected override ShopifyFunctionsArgumentsBuilder Self => this;

        public ShopifyFunctionsArgumentsBuilder(IQuery<ShopifyFunctionConnection> query) : base(query)
        {
        }

        public ShopifyFunctionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopifyFunctionsArgumentsBuilder ApiType(string? apiType)
        {
            base.InnerQuery.AddArgument("apiType", apiType);
            return this;
        }

        public ShopifyFunctionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopifyFunctionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopifyFunctionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopifyFunctionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public ShopifyFunctionsArgumentsBuilder UseCreationUi(bool? useCreationUi)
        {
            base.InnerQuery.AddArgument("useCreationUi", useCreationUi);
            return this;
        }
    }
}