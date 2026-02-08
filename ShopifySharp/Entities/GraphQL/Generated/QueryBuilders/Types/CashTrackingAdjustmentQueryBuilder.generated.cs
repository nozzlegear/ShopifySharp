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
    public sealed class CashTrackingAdjustmentQueryBuilder : FieldsQueryBuilderBase<CashTrackingAdjustment, CashTrackingAdjustmentQueryBuilder>
    {
        protected override CashTrackingAdjustmentQueryBuilder Self => this;

        public CashTrackingAdjustmentQueryBuilder() : this("cashTrackingAdjustment")
        {
        }

        public CashTrackingAdjustmentQueryBuilder(string name) : base(new Query<CashTrackingAdjustment>(name))
        {
        }

        public CashTrackingAdjustmentQueryBuilder(IQuery<CashTrackingAdjustment> query) : base(query)
        {
        }

        public CashTrackingAdjustmentQueryBuilder Cash(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cash");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CashTrackingAdjustmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CashTrackingAdjustmentQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public CashTrackingAdjustmentQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public CashTrackingAdjustmentQueryBuilder Time()
        {
            base.InnerQuery.AddField("time");
            return this;
        }
    }
}