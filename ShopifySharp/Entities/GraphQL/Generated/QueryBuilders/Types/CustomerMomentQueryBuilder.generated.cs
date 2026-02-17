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
    public sealed class CustomerMomentQueryBuilder : FieldsQueryBuilderBase<ICustomerMoment, CustomerMomentQueryBuilder>
    {
        protected override CustomerMomentQueryBuilder Self => this;

        public CustomerMomentQueryBuilder() : this("customerMoment")
        {
        }

        public CustomerMomentQueryBuilder(string name) : base(new Query<ICustomerMoment>(name))
        {
        }

        public CustomerMomentQueryBuilder(IQuery<ICustomerMoment> query) : base(query)
        {
        }

        public CustomerMomentQueryBuilder OccurredAt()
        {
            base.InnerQuery.AddField("occurredAt");
            return this;
        }
    }
}