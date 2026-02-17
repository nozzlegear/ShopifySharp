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
    public sealed class DeliveryAvailableServiceQueryBuilder : FieldsQueryBuilderBase<DeliveryAvailableService, DeliveryAvailableServiceQueryBuilder>
    {
        protected override DeliveryAvailableServiceQueryBuilder Self => this;

        public DeliveryAvailableServiceQueryBuilder() : this("deliveryAvailableService")
        {
        }

        public DeliveryAvailableServiceQueryBuilder(string name) : base(new Query<DeliveryAvailableService>(name))
        {
        }

        public DeliveryAvailableServiceQueryBuilder(IQuery<DeliveryAvailableService> query) : base(query)
        {
        }

        public DeliveryAvailableServiceQueryBuilder Countries(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCountryCodesOrRestOfWorldQueryBuilder> build)
        {
            var query = new Query<DeliveryCountryCodesOrRestOfWorld>("countries");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCountryCodesOrRestOfWorldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCountryCodesOrRestOfWorld>(query);
            return this;
        }

        public DeliveryAvailableServiceQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}