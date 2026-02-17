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
    public sealed class CustomerUpdateArgumentsBuilder : ArgumentsBuilderBase<CustomerUpdatePayload, CustomerUpdateArgumentsBuilder>
    {
        protected override CustomerUpdateArgumentsBuilder Self => this;

        public CustomerUpdateArgumentsBuilder(IQuery<CustomerUpdatePayload> query) : base(query)
        {
        }

        public CustomerUpdateArgumentsBuilder Input(CustomerInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}