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
    public sealed class CustomerByIdentifierArgumentsBuilder : ArgumentsBuilderBase<Customer, CustomerByIdentifierArgumentsBuilder>
    {
        protected override CustomerByIdentifierArgumentsBuilder Self => this;

        public CustomerByIdentifierArgumentsBuilder(IQuery<Customer> query) : base(query)
        {
        }

        public CustomerByIdentifierArgumentsBuilder Identifier(CustomerIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}