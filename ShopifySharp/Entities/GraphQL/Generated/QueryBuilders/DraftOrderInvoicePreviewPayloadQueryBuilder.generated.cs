#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class DraftOrderInvoicePreviewPayloadQueryBuilder() : GraphQueryBuilder<DraftOrderInvoicePreviewPayload>("draftOrderInvoicePreviewPayload")
{
    public DraftOrderInvoicePreviewPayloadQueryBuilder AddFieldPreviewHtml()
    {
        AddField("previewHtml");
        return this;
    }

    public DraftOrderInvoicePreviewPayloadQueryBuilder AddFieldPreviewSubject()
    {
        AddField("previewSubject");
        return this;
    }

    public DraftOrderInvoicePreviewPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}