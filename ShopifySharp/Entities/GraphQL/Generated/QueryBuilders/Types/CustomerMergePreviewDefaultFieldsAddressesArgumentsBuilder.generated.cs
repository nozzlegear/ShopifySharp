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
    public sealed class CustomerMergePreviewDefaultFieldsAddressesArgumentsBuilder : ArgumentsBuilderBase<MailingAddressConnection?, CustomerMergePreviewDefaultFieldsAddressesArgumentsBuilder>
    {
        protected override CustomerMergePreviewDefaultFieldsAddressesArgumentsBuilder Self => this;

        public CustomerMergePreviewDefaultFieldsAddressesArgumentsBuilder(IQuery<MailingAddressConnection?> query) : base(query)
        {
        }

        public CustomerMergePreviewDefaultFieldsAddressesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsAddressesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsAddressesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsAddressesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CustomerMergePreviewDefaultFieldsAddressesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}