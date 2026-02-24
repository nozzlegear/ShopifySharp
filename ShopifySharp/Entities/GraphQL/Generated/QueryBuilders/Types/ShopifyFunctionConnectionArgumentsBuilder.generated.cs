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
    public sealed class ShopifyFunctionConnectionArgumentsBuilder : ArgumentsBuilderBase<ShopifyFunctionConnection, ShopifyFunctionConnectionArgumentsBuilder>
    {
        protected override ShopifyFunctionConnectionArgumentsBuilder Self => this;

        public ShopifyFunctionConnectionArgumentsBuilder(IQuery<ShopifyFunctionConnection> query) : base(query)
        {
        }

        public ShopifyFunctionConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopifyFunctionConnectionArgumentsBuilder ApiType(string? apiType)
        {
            base.InnerQuery.AddArgument("apiType", apiType);
            return this;
        }

        public ShopifyFunctionConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopifyFunctionConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopifyFunctionConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopifyFunctionConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public ShopifyFunctionConnectionArgumentsBuilder UseCreationUi(bool? useCreationUi)
        {
            base.InnerQuery.AddArgument("useCreationUi", useCreationUi);
            return this;
        }
    }
}