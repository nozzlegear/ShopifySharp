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

        public CustomerEmailMarketingConsentUpdateOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerEmailMarketingConsentUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<CustomerEmailMarketingConsentUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerEmailMarketingConsentUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerEmailMarketingConsentUpdateUserError>(query);
            return this;
        }
    }
}