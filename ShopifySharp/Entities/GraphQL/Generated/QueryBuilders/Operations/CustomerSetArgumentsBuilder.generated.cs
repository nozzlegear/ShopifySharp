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
    public sealed class CustomerSetArgumentsBuilder : ArgumentsBuilderBase<CustomerSetPayload, CustomerSetArgumentsBuilder>
    {
        protected override CustomerSetArgumentsBuilder Self => this;

        public CustomerSetArgumentsBuilder(IQuery<CustomerSetPayload> query) : base(query)
        {
        }

        public CustomerSetArgumentsBuilder Identifier(CustomerSetIdentifiers? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }

        public CustomerSetArgumentsBuilder Input(CustomerSetInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}