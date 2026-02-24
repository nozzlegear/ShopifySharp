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
    public sealed class DraftOrderMetafieldsArgumentsBuilder : ArgumentsBuilderBase<MetafieldConnection?, DraftOrderMetafieldsArgumentsBuilder>
    {
        protected override DraftOrderMetafieldsArgumentsBuilder Self => this;

        public DraftOrderMetafieldsArgumentsBuilder(IQuery<MetafieldConnection?> query) : base(query)
        {
        }

        public DraftOrderMetafieldsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DraftOrderMetafieldsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DraftOrderMetafieldsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DraftOrderMetafieldsArgumentsBuilder Keys(ICollection<string>? keys)
        {
            base.InnerQuery.AddArgument("keys", keys);
            return this;
        }

        public DraftOrderMetafieldsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DraftOrderMetafieldsArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }

        public DraftOrderMetafieldsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}