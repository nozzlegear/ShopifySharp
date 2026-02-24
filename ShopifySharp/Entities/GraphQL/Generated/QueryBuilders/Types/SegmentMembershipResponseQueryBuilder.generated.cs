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
    public sealed class SegmentMembershipResponseQueryBuilder : FieldsQueryBuilderBase<SegmentMembershipResponse, SegmentMembershipResponseQueryBuilder>, IHasArguments<SegmentMembershipResponseArgumentsBuilder>
    {
        public SegmentMembershipResponseArgumentsBuilder Arguments { get; }
        protected override SegmentMembershipResponseQueryBuilder Self => this;

        public SegmentMembershipResponseQueryBuilder() : this("segmentMembershipResponse")
        {
        }

        public SegmentMembershipResponseQueryBuilder(string name) : base(new Query<SegmentMembershipResponse>(name))
        {
            Arguments = new SegmentMembershipResponseArgumentsBuilder(base.InnerQuery);
        }

        public SegmentMembershipResponseQueryBuilder(IQuery<SegmentMembershipResponse> query) : base(query)
        {
            Arguments = new SegmentMembershipResponseArgumentsBuilder(base.InnerQuery);
        }

        public SegmentMembershipResponseQueryBuilder SetArguments(Action<SegmentMembershipResponseArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SegmentMembershipResponseQueryBuilder Memberships(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentMembershipQueryBuilder> build)
        {
            var query = new Query<SegmentMembership>("memberships");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentMembershipQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentMembership>(query);
            return this;
        }
    }
}