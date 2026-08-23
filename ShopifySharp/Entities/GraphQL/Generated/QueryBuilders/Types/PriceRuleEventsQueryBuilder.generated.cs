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
    public sealed class PriceRuleEventsQueryBuilder : FieldsQueryBuilderBase<EventConnection, PriceRuleEventsQueryBuilder>, IHasArguments<PriceRuleEventsArgumentsBuilder>
    {
        public PriceRuleEventsArgumentsBuilder Arguments { get; }
        protected override PriceRuleEventsQueryBuilder Self => this;

        public PriceRuleEventsQueryBuilder(string name) : base(new Query<EventConnection>(name))
        {
            Arguments = new PriceRuleEventsArgumentsBuilder(base.InnerQuery);
        }

        public PriceRuleEventsQueryBuilder(IQuery<EventConnection> query) : base(query)
        {
            Arguments = new PriceRuleEventsArgumentsBuilder(base.InnerQuery);
        }

        public PriceRuleEventsQueryBuilder SetArguments(Action<PriceRuleEventsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PriceRuleEventsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventEdgeQueryBuilder> build)
        {
            var query = new Query<EventEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventEdge>(query);
            return this;
        }

        public PriceRuleEventsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public PriceRuleEventsQueryBuilder Nodes(Action<EventInterfaceCasesBuilder> build)
        {
            var query = new Query<IEvent>("nodes");
            var unionBuilder = new EventInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}