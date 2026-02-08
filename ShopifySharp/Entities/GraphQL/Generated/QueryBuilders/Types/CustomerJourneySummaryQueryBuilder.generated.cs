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
    public sealed class CustomerJourneySummaryQueryBuilder : FieldsQueryBuilderBase<CustomerJourneySummary, CustomerJourneySummaryQueryBuilder>
    {
        protected override CustomerJourneySummaryQueryBuilder Self => this;

        public CustomerJourneySummaryQueryBuilder() : this("customerJourneySummary")
        {
        }

        public CustomerJourneySummaryQueryBuilder(string name) : base(new Query<CustomerJourneySummary>(name))
        {
        }

        public CustomerJourneySummaryQueryBuilder(IQuery<CustomerJourneySummary> query) : base(query)
        {
        }

        public CustomerJourneySummaryQueryBuilder CustomerOrderIndex()
        {
            base.InnerQuery.AddField("customerOrderIndex");
            return this;
        }

        public CustomerJourneySummaryQueryBuilder DaysToConversion()
        {
            base.InnerQuery.AddField("daysToConversion");
            return this;
        }

        public CustomerJourneySummaryQueryBuilder FirstVisit(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitQueryBuilder> build)
        {
            var query = new Query<CustomerVisit>("firstVisit");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisit>(query);
            return this;
        }

        public CustomerJourneySummaryQueryBuilder LastVisit(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitQueryBuilder> build)
        {
            var query = new Query<CustomerVisit>("lastVisit");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisit>(query);
            return this;
        }

        public CustomerJourneySummaryQueryBuilder Moments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMomentConnectionQueryBuilder> build)
        {
            var query = new Query<CustomerMomentConnection>("moments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMomentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMomentConnection>(query);
            return this;
        }

        public CustomerJourneySummaryQueryBuilder MomentsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("momentsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public CustomerJourneySummaryQueryBuilder Ready()
        {
            base.InnerQuery.AddField("ready");
            return this;
        }
    }
}