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