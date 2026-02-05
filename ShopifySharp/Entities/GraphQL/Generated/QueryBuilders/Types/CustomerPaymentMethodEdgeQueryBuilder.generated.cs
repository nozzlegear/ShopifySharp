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
    public sealed class CustomerPaymentMethodEdgeQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodEdge, CustomerPaymentMethodEdgeQueryBuilder>
    {
        protected override CustomerPaymentMethodEdgeQueryBuilder Self => this;

        public CustomerPaymentMethodEdgeQueryBuilder() : this("customerPaymentMethodEdge")
        {
        }

        public CustomerPaymentMethodEdgeQueryBuilder(string name) : base(new Query<CustomerPaymentMethodEdge>(name))
        {
        }

        public CustomerPaymentMethodEdgeQueryBuilder(IQuery<CustomerPaymentMethodEdge> query) : base(query)
        {
        }

        public CustomerPaymentMethodEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CustomerPaymentMethodEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }
    }
}