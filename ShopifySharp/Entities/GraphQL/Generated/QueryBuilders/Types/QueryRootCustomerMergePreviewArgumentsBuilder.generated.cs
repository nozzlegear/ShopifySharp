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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootCustomerMergePreviewArgumentsBuilder : ArgumentsBuilderBase<CustomerMergePreview?, QueryRootCustomerMergePreviewArgumentsBuilder>
    {
        protected override QueryRootCustomerMergePreviewArgumentsBuilder Self => this;

        public QueryRootCustomerMergePreviewArgumentsBuilder(IQuery<CustomerMergePreview?> query) : base(query)
        {
        }

        public QueryRootCustomerMergePreviewArgumentsBuilder CustomerOneId(string? customerOneId)
        {
            base.InnerQuery.AddArgument("customerOneId", customerOneId);
            return this;
        }

        public QueryRootCustomerMergePreviewArgumentsBuilder CustomerTwoId(string? customerTwoId)
        {
            base.InnerQuery.AddArgument("customerTwoId", customerTwoId);
            return this;
        }

        public QueryRootCustomerMergePreviewArgumentsBuilder OverrideFields(CustomerMergeOverrideFields? overrideFields)
        {
            base.InnerQuery.AddArgument("overrideFields", overrideFields);
            return this;
        }
    }
}