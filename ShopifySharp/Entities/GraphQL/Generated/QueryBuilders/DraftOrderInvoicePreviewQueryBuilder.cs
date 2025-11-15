#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class DraftOrderInvoicePreviewQueryBuilder() : GraphQueryBuilder<DraftOrderInvoicePreviewPayload>("query draftOrderInvoicePreview")
{
    public DraftOrderInvoicePreviewQueryBuilder AddArgumentEmail(EmailInput? email)
    {
        AddArgument("email", email);
        return this;
    }

    public DraftOrderInvoicePreviewQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}