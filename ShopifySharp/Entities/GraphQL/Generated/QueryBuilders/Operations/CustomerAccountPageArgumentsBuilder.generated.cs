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
    public sealed class CustomerAccountPageArgumentsBuilder : ArgumentsBuilderBase<ICustomerAccountPage, CustomerAccountPageArgumentsBuilder>
    {
        protected override CustomerAccountPageArgumentsBuilder Self => this;

        public CustomerAccountPageArgumentsBuilder(IQuery<ICustomerAccountPage> query) : base(query)
        {
        }

        public CustomerAccountPageArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}