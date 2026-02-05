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
    public sealed class CustomerMergeArgumentsBuilder : ArgumentsBuilderBase<CustomerMergePayload, CustomerMergeArgumentsBuilder>
    {
        protected override CustomerMergeArgumentsBuilder Self => this;

        public CustomerMergeArgumentsBuilder(IQuery<CustomerMergePayload> query) : base(query)
        {
        }

        public CustomerMergeArgumentsBuilder CustomerOneId(string? customerOneId)
        {
            base.InnerQuery.AddArgument("customerOneId", customerOneId);
            return this;
        }

        public CustomerMergeArgumentsBuilder CustomerTwoId(string? customerTwoId)
        {
            base.InnerQuery.AddArgument("customerTwoId", customerTwoId);
            return this;
        }

        public CustomerMergeArgumentsBuilder OverrideFields(CustomerMergeOverrideFields? overrideFields)
        {
            base.InnerQuery.AddArgument("overrideFields", overrideFields);
            return this;
        }
    }
}