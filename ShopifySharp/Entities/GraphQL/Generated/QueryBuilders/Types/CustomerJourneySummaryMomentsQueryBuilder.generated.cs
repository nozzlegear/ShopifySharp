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
    public sealed class CustomerJourneySummaryMomentsQueryBuilder : FieldsQueryBuilderBase<CustomerMomentConnection, CustomerJourneySummaryMomentsQueryBuilder>, IHasArguments<CustomerJourneySummaryMomentsArgumentsBuilder>
    {
        public CustomerJourneySummaryMomentsArgumentsBuilder Arguments { get; }
        protected override CustomerJourneySummaryMomentsQueryBuilder Self => this;

        public CustomerJourneySummaryMomentsQueryBuilder(string name) : base(new Query<CustomerMomentConnection>(name))
        {
            Arguments = new CustomerJourneySummaryMomentsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerJourneySummaryMomentsQueryBuilder(IQuery<CustomerMomentConnection> query) : base(query)
        {
            Arguments = new CustomerJourneySummaryMomentsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerJourneySummaryMomentsQueryBuilder SetArguments(Action<CustomerJourneySummaryMomentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CustomerJourneySummaryMomentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMomentEdgeQueryBuilder> build)
        {
            var query = new Query<CustomerMomentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMomentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMomentEdge>(query);
            return this;
        }

        public CustomerJourneySummaryMomentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMomentQueryBuilder> build)
        {
            var query = new Query<ICustomerMoment>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMomentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICustomerMoment>(query);
            return this;
        }

        public CustomerJourneySummaryMomentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}