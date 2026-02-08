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
    public sealed class CustomerEmailMarketingConsentUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CustomerEmailMarketingConsentUpdatePayload, CustomerEmailMarketingConsentUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerEmailMarketingConsentUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerEmailMarketingConsentUpdateArgumentsBuilder Arguments { get; }
        protected override CustomerEmailMarketingConsentUpdateOperationQueryBuilder Self => this;

        public CustomerEmailMarketingConsentUpdateOperationQueryBuilder() : this("customerEmailMarketingConsentUpdate")
        {
        }

        public CustomerEmailMarketingConsentUpdateOperationQueryBuilder(string name) : base(new Query<CustomerEmailMarketingConsentUpdatePayload>(name))
        {
            Arguments = new CustomerEmailMarketingConsentUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerEmailMarketingConsentUpdateOperationQueryBuilder(IQuery<CustomerEmailMarketingConsentUpdatePayload> query) : base(query)
        {
            Arguments = new CustomerEmailMarketingConsentUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CustomerEmailMarketingConsentUpdateOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerEmailMarketingConsentUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerEmailMarketingConsentUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerEmailMarketingConsentUpdateUserError>(query);
            return this;
        }
    }
}