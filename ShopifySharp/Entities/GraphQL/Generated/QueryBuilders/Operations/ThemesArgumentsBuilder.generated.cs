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
    public sealed class ThemesArgumentsBuilder : ArgumentsBuilderBase<OnlineStoreThemeConnection, ThemesArgumentsBuilder>
    {
        protected override ThemesArgumentsBuilder Self => this;

        public ThemesArgumentsBuilder(IQuery<OnlineStoreThemeConnection> query) : base(query)
        {
        }

        public ThemesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ThemesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ThemesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ThemesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ThemesArgumentsBuilder Names(ICollection<string>? names)
        {
            base.InnerQuery.AddArgument("names", names);
            return this;
        }

        public ThemesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public ThemesArgumentsBuilder Roles(ICollection<ThemeRole>? roles)
        {
            base.InnerQuery.AddArgument("roles", roles);
            return this;
        }
    }
}