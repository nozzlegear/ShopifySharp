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
    public sealed class EventQueryBuilder : FieldsQueryBuilderBase<IEvent, EventQueryBuilder>
    {
        protected override EventQueryBuilder Self => this;

        public EventQueryBuilder() : this("event")
        {
        }

        public EventQueryBuilder(string name) : base(new Query<IEvent>(name))
        {
        }

        public EventQueryBuilder(IQuery<IEvent> query) : base(query)
        {
        }

        public EventQueryBuilder Action()
        {
            base.InnerQuery.AddField("action");
            return this;
        }

        public EventQueryBuilder AppTitle()
        {
            base.InnerQuery.AddField("appTitle");
            return this;
        }

        public EventQueryBuilder AttributeToApp()
        {
            base.InnerQuery.AddField("attributeToApp");
            return this;
        }

        public EventQueryBuilder AttributeToUser()
        {
            base.InnerQuery.AddField("attributeToUser");
            return this;
        }

        public EventQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public EventQueryBuilder CriticalAlert()
        {
            base.InnerQuery.AddField("criticalAlert");
            return this;
        }

        public EventQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public EventQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}