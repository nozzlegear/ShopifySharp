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
    public sealed class CustomerMergePreviewArgumentsBuilder : ArgumentsBuilderBase<CustomerMergePreview, CustomerMergePreviewArgumentsBuilder>
    {
        protected override CustomerMergePreviewArgumentsBuilder Self => this;

        public CustomerMergePreviewArgumentsBuilder(IQuery<CustomerMergePreview> query) : base(query)
        {
        }

        public CustomerMergePreviewArgumentsBuilder CustomerOneId(string? customerOneId)
        {
            base.InnerQuery.AddArgument("customerOneId", customerOneId);
            return this;
        }

        public CustomerMergePreviewArgumentsBuilder CustomerTwoId(string? customerTwoId)
        {
            base.InnerQuery.AddArgument("customerTwoId", customerTwoId);
            return this;
        }

        public CustomerMergePreviewArgumentsBuilder OverrideFields(CustomerMergeOverrideFields? overrideFields)
        {
            base.InnerQuery.AddArgument("overrideFields", overrideFields);
            return this;
        }
    }
}