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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class ShopBillingPreferencesOperationQueryBuilder : FieldsQueryBuilderBase<ShopBillingPreferences, ShopBillingPreferencesOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopBillingPreferences>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override ShopBillingPreferencesOperationQueryBuilder Self => this;

        public ShopBillingPreferencesOperationQueryBuilder() : this("shopBillingPreferences")
        {
        }

        public ShopBillingPreferencesOperationQueryBuilder(string name) : base(new Query<ShopBillingPreferences>(name))
        {
        }

        public ShopBillingPreferencesOperationQueryBuilder(IQuery<ShopBillingPreferences> query) : base(query)
        {
        }

        public ShopBillingPreferencesOperationQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }
    }
}