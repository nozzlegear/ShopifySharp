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
    public sealed class HasEventsQueryBuilder : FieldsQueryBuilderBase<IHasEvents, HasEventsQueryBuilder>
    {
        protected override HasEventsQueryBuilder Self => this;

        public HasEventsQueryBuilder() : this("hasEvents")
        {
        }

        public HasEventsQueryBuilder(string name) : base(new Query<IHasEvents>(name))
        {
        }

        public HasEventsQueryBuilder(IQuery<IHasEvents> query) : base(query)
        {
        }

        public HasEventsQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }
    }
}