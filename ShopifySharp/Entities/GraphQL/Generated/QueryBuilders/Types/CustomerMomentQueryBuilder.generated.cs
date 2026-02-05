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