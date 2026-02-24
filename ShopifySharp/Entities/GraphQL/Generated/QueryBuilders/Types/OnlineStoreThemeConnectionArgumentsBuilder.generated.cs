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
    public sealed class OnlineStoreThemeConnectionArgumentsBuilder : ArgumentsBuilderBase<OnlineStoreThemeConnection, OnlineStoreThemeConnectionArgumentsBuilder>
    {
        protected override OnlineStoreThemeConnectionArgumentsBuilder Self => this;

        public OnlineStoreThemeConnectionArgumentsBuilder(IQuery<OnlineStoreThemeConnection> query) : base(query)
        {
        }

        public OnlineStoreThemeConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public OnlineStoreThemeConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public OnlineStoreThemeConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public OnlineStoreThemeConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public OnlineStoreThemeConnectionArgumentsBuilder Names(ICollection<string>? names)
        {
            base.InnerQuery.AddArgument("names", names);
            return this;
        }

        public OnlineStoreThemeConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public OnlineStoreThemeConnectionArgumentsBuilder Roles(ICollection<ThemeRole>? roles)
        {
            base.InnerQuery.AddArgument("roles", roles);
            return this;
        }
    }
}