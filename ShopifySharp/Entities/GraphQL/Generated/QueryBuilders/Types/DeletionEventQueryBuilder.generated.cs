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
    public sealed class DeletionEventQueryBuilder : FieldsQueryBuilderBase<DeletionEvent, DeletionEventQueryBuilder>
    {
        protected override DeletionEventQueryBuilder Self => this;

        public DeletionEventQueryBuilder() : this("deletionEvent")
        {
        }

        public DeletionEventQueryBuilder(string name) : base(new Query<DeletionEvent>(name))
        {
        }

        public DeletionEventQueryBuilder(IQuery<DeletionEvent> query) : base(query)
        {
        }

        public DeletionEventQueryBuilder OccurredAt()
        {
            base.InnerQuery.AddField("occurredAt");
            return this;
        }

        public DeletionEventQueryBuilder SubjectId()
        {
            base.InnerQuery.AddField("subjectId");
            return this;
        }

        public DeletionEventQueryBuilder SubjectType()
        {
            base.InnerQuery.AddField("subjectType");
            return this;
        }
    }
}