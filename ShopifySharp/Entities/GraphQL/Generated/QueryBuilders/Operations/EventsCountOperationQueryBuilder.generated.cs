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
    public sealed class EventsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, EventsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public EventsCountArgumentsBuilder Arguments { get; }
        protected override EventsCountOperationQueryBuilder Self => this;

        public EventsCountOperationQueryBuilder() : this("eventsCount")
        {
        }

        public EventsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new EventsCountArgumentsBuilder(base.InnerQuery);
        }

        public EventsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new EventsCountArgumentsBuilder(base.InnerQuery);
        }

        public EventsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public EventsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}