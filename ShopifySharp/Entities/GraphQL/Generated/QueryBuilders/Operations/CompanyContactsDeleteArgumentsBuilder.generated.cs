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
    public sealed class CompanyContactsDeleteArgumentsBuilder : ArgumentsBuilderBase<CompanyContactsDeletePayload, CompanyContactsDeleteArgumentsBuilder>
    {
        protected override CompanyContactsDeleteArgumentsBuilder Self => this;

        public CompanyContactsDeleteArgumentsBuilder(IQuery<CompanyContactsDeletePayload> query) : base(query)
        {
        }

        public CompanyContactsDeleteArgumentsBuilder CompanyContactIds(ICollection<string>? companyContactIds)
        {
            base.InnerQuery.AddArgument("companyContactIds", companyContactIds);
            return this;
        }
    }
}