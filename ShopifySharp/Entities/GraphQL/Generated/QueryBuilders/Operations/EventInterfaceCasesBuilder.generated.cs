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
    public sealed class EventInterfaceCasesBuilder : InterfaceCasesBuilderBase<IEvent, EventInterfaceCasesBuilder>
    {
        protected override EventInterfaceCasesBuilder Self => this;

        public EventInterfaceCasesBuilder(string fieldName = "nodes") : this(new Query<IEvent>(fieldName))
        {
        }

        public EventInterfaceCasesBuilder(IQuery<IEvent> query) : base(query)
        {
        }

        public EventInterfaceCasesBuilder OnBasicEvent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BasicEventQueryBuilder> build)
        {
            var query = new Query<BasicEvent>("... on BasicEvent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BasicEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public EventInterfaceCasesBuilder OnCommentEvent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CommentEventQueryBuilder> build)
        {
            var query = new Query<CommentEvent>("... on CommentEvent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CommentEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}