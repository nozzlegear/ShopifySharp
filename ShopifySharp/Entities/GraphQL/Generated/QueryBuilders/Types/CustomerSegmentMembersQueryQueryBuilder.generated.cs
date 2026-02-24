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
    public sealed class CustomerSegmentMembersQueryQueryBuilder : FieldsQueryBuilderBase<CustomerSegmentMembersQuery, CustomerSegmentMembersQueryQueryBuilder>, IHasArguments<CustomerSegmentMembersQueryArgumentsBuilder>
    {
        public CustomerSegmentMembersQueryArgumentsBuilder Arguments { get; }
        protected override CustomerSegmentMembersQueryQueryBuilder Self => this;

        public CustomerSegmentMembersQueryQueryBuilder() : this("customerSegmentMembersQuery")
        {
        }

        public CustomerSegmentMembersQueryQueryBuilder(string name) : base(new Query<CustomerSegmentMembersQuery>(name))
        {
            Arguments = new CustomerSegmentMembersQueryArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSegmentMembersQueryQueryBuilder(IQuery<CustomerSegmentMembersQuery> query) : base(query)
        {
            Arguments = new CustomerSegmentMembersQueryArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSegmentMembersQueryQueryBuilder SetArguments(Action<CustomerSegmentMembersQueryArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CustomerSegmentMembersQueryQueryBuilder CurrentCount()
        {
            base.InnerQuery.AddField("currentCount");
            return this;
        }

        public CustomerSegmentMembersQueryQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public CustomerSegmentMembersQueryQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}