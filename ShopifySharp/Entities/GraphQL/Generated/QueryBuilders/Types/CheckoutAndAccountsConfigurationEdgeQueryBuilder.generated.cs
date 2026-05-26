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
    public sealed class CheckoutAndAccountsConfigurationEdgeQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationEdge, CheckoutAndAccountsConfigurationEdgeQueryBuilder>
    {
        protected override CheckoutAndAccountsConfigurationEdgeQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationEdgeQueryBuilder() : this("checkoutAndAccountsConfigurationEdge")
        {
        }

        public CheckoutAndAccountsConfigurationEdgeQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationEdge>(name))
        {
        }

        public CheckoutAndAccountsConfigurationEdgeQueryBuilder(IQuery<CheckoutAndAccountsConfigurationEdge> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CheckoutAndAccountsConfigurationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfiguration>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfiguration>(query);
            return this;
        }
    }
}