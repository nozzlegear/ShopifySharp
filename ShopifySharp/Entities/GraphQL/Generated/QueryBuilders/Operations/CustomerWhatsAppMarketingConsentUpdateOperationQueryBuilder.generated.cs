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
    public sealed class CustomerWhatsAppMarketingConsentUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CustomerWhatsAppMarketingConsentUpdatePayload, CustomerWhatsAppMarketingConsentUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerWhatsAppMarketingConsentUpdatePayload>, IHasArguments<CustomerWhatsAppMarketingConsentUpdateArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerWhatsAppMarketingConsentUpdateArgumentsBuilder Arguments { get; }
        protected override CustomerWhatsAppMarketingConsentUpdateOperationQueryBuilder Self => this;

        public CustomerWhatsAppMarketingConsentUpdateOperationQueryBuilder() : this("customerWhatsAppMarketingConsentUpdate")
        {
        }

        public CustomerWhatsAppMarketingConsentUpdateOperationQueryBuilder(string name) : base(new Query<CustomerWhatsAppMarketingConsentUpdatePayload>(name))
        {
            Arguments = new CustomerWhatsAppMarketingConsentUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerWhatsAppMarketingConsentUpdateOperationQueryBuilder(IQuery<CustomerWhatsAppMarketingConsentUpdatePayload> query) : base(query)
        {
            Arguments = new CustomerWhatsAppMarketingConsentUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerWhatsAppMarketingConsentUpdateOperationQueryBuilder SetArguments(Action<CustomerWhatsAppMarketingConsentUpdateArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CustomerWhatsAppMarketingConsentUpdateOperationQueryBuilder CustomerPhoneNumber(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPhoneNumberQueryBuilder> build)
        {
            var query = new Query<CustomerPhoneNumber>("customerPhoneNumber");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPhoneNumberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPhoneNumber>(query);
            return this;
        }

        public CustomerWhatsAppMarketingConsentUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMarketingConsentErrorQueryBuilder> build)
        {
            var query = new Query<CustomerMarketingConsentError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerMarketingConsentErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerMarketingConsentError>(query);
            return this;
        }
    }
}