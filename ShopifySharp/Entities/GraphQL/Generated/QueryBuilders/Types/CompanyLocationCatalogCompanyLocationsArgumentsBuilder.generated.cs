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
    public sealed class CompanyLocationCatalogCompanyLocationsArgumentsBuilder : ArgumentsBuilderBase<CompanyLocationConnection?, CompanyLocationCatalogCompanyLocationsArgumentsBuilder>
    {
        protected override CompanyLocationCatalogCompanyLocationsArgumentsBuilder Self => this;

        public CompanyLocationCatalogCompanyLocationsArgumentsBuilder(IQuery<CompanyLocationConnection?> query) : base(query)
        {
        }

        public CompanyLocationCatalogCompanyLocationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CompanyLocationCatalogCompanyLocationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CompanyLocationCatalogCompanyLocationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CompanyLocationCatalogCompanyLocationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CompanyLocationCatalogCompanyLocationsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public CompanyLocationCatalogCompanyLocationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CompanyLocationCatalogCompanyLocationsArgumentsBuilder SortKey(CompanyLocationSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}