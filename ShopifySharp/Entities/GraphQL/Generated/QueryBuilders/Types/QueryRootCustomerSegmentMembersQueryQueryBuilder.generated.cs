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
    public sealed class QueryRootCustomerSegmentMembersQueryQueryBuilder : FieldsQueryBuilderBase<CustomerSegmentMembersQuery, QueryRootCustomerSegmentMembersQueryQueryBuilder>, IHasArguments<QueryRootCustomerSegmentMembersQueryArgumentsBuilder>
    {
        public QueryRootCustomerSegmentMembersQueryArgumentsBuilder Arguments { get; }
        protected override QueryRootCustomerSegmentMembersQueryQueryBuilder Self => this;

        public QueryRootCustomerSegmentMembersQueryQueryBuilder(string name) : base(new Query<CustomerSegmentMembersQuery>(name))
        {
            Arguments = new QueryRootCustomerSegmentMembersQueryArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerSegmentMembersQueryQueryBuilder(IQuery<CustomerSegmentMembersQuery> query) : base(query)
        {
            Arguments = new QueryRootCustomerSegmentMembersQueryArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomerSegmentMembersQueryQueryBuilder SetArguments(Action<QueryRootCustomerSegmentMembersQueryArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCustomerSegmentMembersQueryQueryBuilder CurrentCount()
        {
            base.InnerQuery.AddField("currentCount");
            return this;
        }

        public QueryRootCustomerSegmentMembersQueryQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public QueryRootCustomerSegmentMembersQueryQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}