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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CustomerSmsMarketingConsentUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CustomerSmsMarketingConsentUpdatePayload, CustomerSmsMarketingConsentUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerSmsMarketingConsentUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerSmsMarketingConsentUpdateArgumentsBuilder Arguments { get; }
        protected override CustomerSmsMarketingConsentUpdateOperationQueryBuilder Self => this;

        public CustomerSmsMarketingConsentUpdateOperationQueryBuilder() : this("customerSmsMarketingConsentUpdate")
        {
        }

        public CustomerSmsMarketingConsentUpdateOperationQueryBuilder(string name) : base(new Query<CustomerSmsMarketingConsentUpdatePayload>(name))
        {
            Arguments = new CustomerSmsMarketingConsentUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSmsMarketingConsentUpdateOperationQueryBuilder(IQuery<CustomerSmsMarketingConsentUpdatePayload> query) : base(query)
        {
            Arguments = new CustomerSmsMarketingConsentUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerSmsMarketingConsentUpdateOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerSmsMarketingConsentUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSmsMarketingConsentErrorQueryBuilder> build)
        {
            var query = new Query<CustomerSmsMarketingConsentError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerSmsMarketingConsentErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerSmsMarketingConsentError>(query);
            return this;
        }
    }
}