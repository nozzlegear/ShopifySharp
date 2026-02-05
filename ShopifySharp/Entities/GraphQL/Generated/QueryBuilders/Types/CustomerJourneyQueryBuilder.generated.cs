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
    public sealed class CustomerJourneyQueryBuilder : FieldsQueryBuilderBase<CustomerJourney, CustomerJourneyQueryBuilder>
    {
        protected override CustomerJourneyQueryBuilder Self => this;

        public CustomerJourneyQueryBuilder() : this("customerJourney")
        {
        }

        public CustomerJourneyQueryBuilder(string name) : base(new Query<CustomerJourney>(name))
        {
        }

        public CustomerJourneyQueryBuilder(IQuery<CustomerJourney> query) : base(query)
        {
        }

        public CustomerJourneyQueryBuilder CustomerOrderIndex()
        {
            base.InnerQuery.AddField("customerOrderIndex");
            return this;
        }

        public CustomerJourneyQueryBuilder DaysToConversion()
        {
            base.InnerQuery.AddField("daysToConversion");
            return this;
        }

        public CustomerJourneyQueryBuilder FirstVisit(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitQueryBuilder> build)
        {
            var query = new Query<CustomerVisit>("firstVisit");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisit>(query);
            return this;
        }

        public CustomerJourneyQueryBuilder LastVisit(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitQueryBuilder> build)
        {
            var query = new Query<CustomerVisit>("lastVisit");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerVisitQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerVisit>(query);
            return this;
        }

        public CustomerJourneyQueryBuilder Moments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMomentQueryBuilder> build)
        {
            var query = new Query<ICustomerMoment>("moments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerMomentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICustomerMoment>(query);
            return this;
        }
    }
}