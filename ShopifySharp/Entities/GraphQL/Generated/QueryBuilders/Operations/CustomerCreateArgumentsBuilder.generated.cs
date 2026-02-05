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
    public sealed class CustomerCreateArgumentsBuilder : ArgumentsBuilderBase<CustomerCreatePayload, CustomerCreateArgumentsBuilder>
    {
        protected override CustomerCreateArgumentsBuilder Self => this;

        public CustomerCreateArgumentsBuilder(IQuery<CustomerCreatePayload> query) : base(query)
        {
        }

        public CustomerCreateArgumentsBuilder Input(CustomerInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}