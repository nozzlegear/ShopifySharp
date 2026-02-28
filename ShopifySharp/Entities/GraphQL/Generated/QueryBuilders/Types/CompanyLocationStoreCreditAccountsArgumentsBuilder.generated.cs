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
    public sealed class CompanyLocationStoreCreditAccountsArgumentsBuilder : ArgumentsBuilderBase<StoreCreditAccountConnection?, CompanyLocationStoreCreditAccountsArgumentsBuilder>
    {
        protected override CompanyLocationStoreCreditAccountsArgumentsBuilder Self => this;

        public CompanyLocationStoreCreditAccountsArgumentsBuilder(IQuery<StoreCreditAccountConnection?> query) : base(query)
        {
        }

        public CompanyLocationStoreCreditAccountsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CompanyLocationStoreCreditAccountsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CompanyLocationStoreCreditAccountsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CompanyLocationStoreCreditAccountsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CompanyLocationStoreCreditAccountsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }
    }
}