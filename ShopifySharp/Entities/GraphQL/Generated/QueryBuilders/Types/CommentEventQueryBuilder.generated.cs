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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class CommentEventQueryBuilder : FieldsQueryBuilderBase<CommentEvent, CommentEventQueryBuilder>
    {
        protected override CommentEventQueryBuilder Self => this;

        public CommentEventQueryBuilder() : this("commentEvent")
        {
        }

        public CommentEventQueryBuilder(string name) : base(new Query<CommentEvent>(name))
        {
        }

        public CommentEventQueryBuilder(IQuery<CommentEvent> query) : base(query)
        {
        }

        public CommentEventQueryBuilder Action()
        {
            base.InnerQuery.AddField("action");
            return this;
        }

        public CommentEventQueryBuilder AppTitle()
        {
            base.InnerQuery.AddField("appTitle");
            return this;
        }

        public CommentEventQueryBuilder Attachments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentEventAttachmentQueryBuilder> build)
        {
            var query = new Query<CommentEventAttachment>("attachments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentEventAttachmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CommentEventAttachment>(query);
            return this;
        }

        public CommentEventQueryBuilder AttributeToApp()
        {
            base.InnerQuery.AddField("attributeToApp");
            return this;
        }

        public CommentEventQueryBuilder AttributeToUser()
        {
            base.InnerQuery.AddField("attributeToUser");
            return this;
        }

        public CommentEventQueryBuilder Author(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("author");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public CommentEventQueryBuilder CanDelete()
        {
            base.InnerQuery.AddField("canDelete");
            return this;
        }

        public CommentEventQueryBuilder CanEdit()
        {
            base.InnerQuery.AddField("canEdit");
            return this;
        }

        public CommentEventQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CommentEventQueryBuilder CriticalAlert()
        {
            base.InnerQuery.AddField("criticalAlert");
            return this;
        }

        public CommentEventQueryBuilder Edited()
        {
            base.InnerQuery.AddField("edited");
            return this;
        }

        public CommentEventQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CommentEventQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }

        public CommentEventQueryBuilder RawMessage()
        {
            base.InnerQuery.AddField("rawMessage");
            return this;
        }

        public CommentEventQueryBuilder Subject(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentEventSubjectQueryBuilder> build)
        {
            var query = new Query<ICommentEventSubject>("subject");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CommentEventSubjectQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICommentEventSubject>(query);
            return this;
        }

        public CommentEventQueryBuilder Embed(Action<CommentEventEmbedUnionCasesBuilder> build)
        {
            var query = new Query<CommentEventEmbed>("embed");
            var unionBuilder = new CommentEventEmbedUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}