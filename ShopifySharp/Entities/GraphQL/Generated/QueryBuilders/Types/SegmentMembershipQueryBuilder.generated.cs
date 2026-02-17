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
    public sealed class SegmentMembershipQueryBuilder : FieldsQueryBuilderBase<SegmentMembership, SegmentMembershipQueryBuilder>
    {
        protected override SegmentMembershipQueryBuilder Self => this;

        public SegmentMembershipQueryBuilder() : this("segmentMembership")
        {
        }

        public SegmentMembershipQueryBuilder(string name) : base(new Query<SegmentMembership>(name))
        {
        }

        public SegmentMembershipQueryBuilder(IQuery<SegmentMembership> query) : base(query)
        {
        }

        public SegmentMembershipQueryBuilder IsMember()
        {
            base.InnerQuery.AddField("isMember");
            return this;
        }

        public SegmentMembershipQueryBuilder SegmentId()
        {
            base.InnerQuery.AddField("segmentId");
            return this;
        }
    }
}