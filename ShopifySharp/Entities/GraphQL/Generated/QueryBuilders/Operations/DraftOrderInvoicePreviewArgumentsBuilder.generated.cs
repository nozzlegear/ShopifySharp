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
    public sealed class DraftOrderInvoicePreviewArgumentsBuilder : ArgumentsBuilderBase<DraftOrderInvoicePreviewPayload, DraftOrderInvoicePreviewArgumentsBuilder>
    {
        protected override DraftOrderInvoicePreviewArgumentsBuilder Self => this;

        public DraftOrderInvoicePreviewArgumentsBuilder(IQuery<DraftOrderInvoicePreviewPayload> query) : base(query)
        {
        }

        public DraftOrderInvoicePreviewArgumentsBuilder Email(EmailInput? email)
        {
            base.InnerQuery.AddArgument("email", email);
            return this;
        }

        public DraftOrderInvoicePreviewArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}