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
    public sealed class DeliveryCarrierServiceAvailableServicesForCountriesQueryBuilder : FieldsQueryBuilderBase<DeliveryAvailableService, DeliveryCarrierServiceAvailableServicesForCountriesQueryBuilder>, IHasArguments<DeliveryCarrierServiceAvailableServicesForCountriesArgumentsBuilder>
    {
        public DeliveryCarrierServiceAvailableServicesForCountriesArgumentsBuilder Arguments { get; }
        protected override DeliveryCarrierServiceAvailableServicesForCountriesQueryBuilder Self => this;

        public DeliveryCarrierServiceAvailableServicesForCountriesQueryBuilder(string name) : base(new Query<DeliveryAvailableService>(name))
        {
            Arguments = new DeliveryCarrierServiceAvailableServicesForCountriesArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCarrierServiceAvailableServicesForCountriesQueryBuilder(IQuery<DeliveryAvailableService> query) : base(query)
        {
            Arguments = new DeliveryCarrierServiceAvailableServicesForCountriesArgumentsBuilder(base.InnerQuery);
        }

        public DeliveryCarrierServiceAvailableServicesForCountriesQueryBuilder SetArguments(Action<DeliveryCarrierServiceAvailableServicesForCountriesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DeliveryCarrierServiceAvailableServicesForCountriesQueryBuilder Countries(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCountryCodesOrRestOfWorldQueryBuilder> build)
        {
            var query = new Query<DeliveryCountryCodesOrRestOfWorld>("countries");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCountryCodesOrRestOfWorldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCountryCodesOrRestOfWorld>(query);
            return this;
        }

        public DeliveryCarrierServiceAvailableServicesForCountriesQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}