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