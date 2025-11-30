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

public class CommentEventQueryBuilder() : GraphQueryBuilder<CommentEvent>("commentEvent")
{
    public CommentEventQueryBuilder AddFieldAction()
    {
        AddField("action");
        return this;
    }

    public CommentEventQueryBuilder AddFieldAppTitle()
    {
        AddField("appTitle");
        return this;
    }

    public CommentEventQueryBuilder AddFieldAttachments(Func<CommentEventAttachmentQueryBuilder, CommentEventAttachmentQueryBuilder> build)
    {
        AddField<CommentEventAttachment, CommentEventAttachmentQueryBuilder>("attachments", build);
        return this;
    }

    public CommentEventQueryBuilder AddFieldAttributeToApp()
    {
        AddField("attributeToApp");
        return this;
    }

    public CommentEventQueryBuilder AddFieldAttributeToUser()
    {
        AddField("attributeToUser");
        return this;
    }

    public CommentEventQueryBuilder AddFieldAuthor(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("author", build);
        return this;
    }

    public CommentEventQueryBuilder AddFieldCanDelete()
    {
        AddField("canDelete");
        return this;
    }

    public CommentEventQueryBuilder AddFieldCanEdit()
    {
        AddField("canEdit");
        return this;
    }

    public CommentEventQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public CommentEventQueryBuilder AddFieldCriticalAlert()
    {
        AddField("criticalAlert");
        return this;
    }

    public CommentEventQueryBuilder AddFieldEdited()
    {
        AddField("edited");
        return this;
    }

    public CommentEventQueryBuilder AddUnionCaseEmbed(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddUnion<Customer, CustomerQueryBuilder>("embed", build);
        return this;
    }

    public CommentEventQueryBuilder AddUnionCaseEmbed(Func<DraftOrderQueryBuilder, DraftOrderQueryBuilder> build)
    {
        AddUnion<DraftOrder, DraftOrderQueryBuilder>("embed", build);
        return this;
    }

    public CommentEventQueryBuilder AddUnionCaseEmbed(Func<InventoryTransferQueryBuilder, InventoryTransferQueryBuilder> build)
    {
        AddUnion<InventoryTransfer, InventoryTransferQueryBuilder>("embed", build);
        return this;
    }

    public CommentEventQueryBuilder AddUnionCaseEmbed(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddUnion<Order, OrderQueryBuilder>("embed", build);
        return this;
    }

    public CommentEventQueryBuilder AddUnionCaseEmbed(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddUnion<Product, ProductQueryBuilder>("embed", build);
        return this;
    }

    public CommentEventQueryBuilder AddUnionCaseEmbed(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddUnion<ProductVariant, ProductVariantQueryBuilder>("embed", build);
        return this;
    }

    public CommentEventQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CommentEventQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }

    public CommentEventQueryBuilder AddFieldRawMessage()
    {
        AddField("rawMessage");
        return this;
    }

    public CommentEventQueryBuilder AddFieldSubject(Func<CommentEventSubjectQueryBuilder, CommentEventSubjectQueryBuilder> build)
    {
        AddField<ICommentEventSubject, CommentEventSubjectQueryBuilder>("subject", build);
        return this;
    }
}