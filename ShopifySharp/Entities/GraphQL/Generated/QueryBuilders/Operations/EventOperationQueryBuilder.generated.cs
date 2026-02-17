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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class EventOperationQueryBuilder : FieldsQueryBuilderBase<IEvent, EventOperationQueryBuilder>, IGraphOperationQueryBuilder<IEvent>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public EventArgumentsBuilder Arguments { get; }
        protected override EventOperationQueryBuilder Self => this;

        public EventOperationQueryBuilder() : this("event")
        {
        }

        public EventOperationQueryBuilder(string name) : base(new Query<IEvent>(name))
        {
            Arguments = new EventArgumentsBuilder(base.InnerQuery);
        }

        public EventOperationQueryBuilder(IQuery<IEvent> query) : base(query)
        {
            Arguments = new EventArgumentsBuilder(base.InnerQuery);
        }

        public EventOperationQueryBuilder Action()
        {
            base.InnerQuery.AddField("action");
            return this;
        }

        public EventOperationQueryBuilder AppTitle()
        {
            base.InnerQuery.AddField("appTitle");
            return this;
        }

        public EventOperationQueryBuilder AttributeToApp()
        {
            base.InnerQuery.AddField("attributeToApp");
            return this;
        }

        public EventOperationQueryBuilder AttributeToUser()
        {
            base.InnerQuery.AddField("attributeToUser");
            return this;
        }

        public EventOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public EventOperationQueryBuilder CriticalAlert()
        {
            base.InnerQuery.AddField("criticalAlert");
            return this;
        }

        public EventOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public EventOperationQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}