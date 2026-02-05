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
    public sealed class BasicEventQueryBuilder : FieldsQueryBuilderBase<BasicEvent, BasicEventQueryBuilder>
    {
        protected override BasicEventQueryBuilder Self => this;

        public BasicEventQueryBuilder() : this("basicEvent")
        {
        }

        public BasicEventQueryBuilder(string name) : base(new Query<BasicEvent>(name))
        {
        }

        public BasicEventQueryBuilder(IQuery<BasicEvent> query) : base(query)
        {
        }

        public BasicEventQueryBuilder Action()
        {
            base.InnerQuery.AddField("action");
            return this;
        }

        public BasicEventQueryBuilder AdditionalContent()
        {
            base.InnerQuery.AddField("additionalContent");
            return this;
        }

        public BasicEventQueryBuilder AdditionalData()
        {
            base.InnerQuery.AddField("additionalData");
            return this;
        }

        public BasicEventQueryBuilder AppTitle()
        {
            base.InnerQuery.AddField("appTitle");
            return this;
        }

        public BasicEventQueryBuilder Arguments_()
        {
            base.InnerQuery.AddField("arguments");
            return this;
        }

        public BasicEventQueryBuilder AttributeToApp()
        {
            base.InnerQuery.AddField("attributeToApp");
            return this;
        }

        public BasicEventQueryBuilder AttributeToUser()
        {
            base.InnerQuery.AddField("attributeToUser");
            return this;
        }

        public BasicEventQueryBuilder Author()
        {
            base.InnerQuery.AddField("author");
            return this;
        }

        public BasicEventQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public BasicEventQueryBuilder CriticalAlert()
        {
            base.InnerQuery.AddField("criticalAlert");
            return this;
        }

        public BasicEventQueryBuilder HasAdditionalContent()
        {
            base.InnerQuery.AddField("hasAdditionalContent");
            return this;
        }

        public BasicEventQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public BasicEventQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }

        public BasicEventQueryBuilder SecondaryMessage()
        {
            base.InnerQuery.AddField("secondaryMessage");
            return this;
        }

        public BasicEventQueryBuilder Subject(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.HasEventsQueryBuilder> build)
        {
            var query = new Query<IHasEvents>("subject");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.HasEventsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IHasEvents>(query);
            return this;
        }

        public BasicEventQueryBuilder SubjectId()
        {
            base.InnerQuery.AddField("subjectId");
            return this;
        }

        public BasicEventQueryBuilder SubjectType()
        {
            base.InnerQuery.AddField("subjectType");
            return this;
        }
    }
}