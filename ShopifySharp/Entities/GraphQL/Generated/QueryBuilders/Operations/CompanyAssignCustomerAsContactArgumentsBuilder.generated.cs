#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CompanyAssignCustomerAsContactArgumentsBuilder : ArgumentsBuilderBase<CompanyAssignCustomerAsContactPayload, CompanyAssignCustomerAsContactArgumentsBuilder>
    {
        protected override CompanyAssignCustomerAsContactArgumentsBuilder Self => this;

        public CompanyAssignCustomerAsContactArgumentsBuilder(IQuery<CompanyAssignCustomerAsContactPayload> query) : base(query)
        {
        }

        public CompanyAssignCustomerAsContactArgumentsBuilder CompanyId(string? companyId)
        {
            base.InnerQuery.AddArgument("companyId", companyId);
            return this;
        }

        public CompanyAssignCustomerAsContactArgumentsBuilder CustomerId(string? customerId)
        {
            base.InnerQuery.AddArgument("customerId", customerId);
            return this;
        }
    }
}