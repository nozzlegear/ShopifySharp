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
    public sealed class QueryRootEventQueryBuilder : FieldsQueryBuilderBase<IEvent, QueryRootEventQueryBuilder>, IHasArguments<QueryRootEventArgumentsBuilder>
    {
        public QueryRootEventArgumentsBuilder Arguments { get; }
        protected override QueryRootEventQueryBuilder Self => this;

        public QueryRootEventQueryBuilder(string name) : base(new Query<IEvent>(name))
        {
            Arguments = new QueryRootEventArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootEventQueryBuilder(IQuery<IEvent> query) : base(query)
        {
            Arguments = new QueryRootEventArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootEventQueryBuilder SetArguments(Action<QueryRootEventArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootEventQueryBuilder Action()
        {
            base.InnerQuery.AddField("action");
            return this;
        }

        public QueryRootEventQueryBuilder AppTitle()
        {
            base.InnerQuery.AddField("appTitle");
            return this;
        }

        public QueryRootEventQueryBuilder AttributeToApp()
        {
            base.InnerQuery.AddField("attributeToApp");
            return this;
        }

        public QueryRootEventQueryBuilder AttributeToUser()
        {
            base.InnerQuery.AddField("attributeToUser");
            return this;
        }

        public QueryRootEventQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootEventQueryBuilder CriticalAlert()
        {
            base.InnerQuery.AddField("criticalAlert");
            return this;
        }

        public QueryRootEventQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootEventQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}