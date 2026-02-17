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
    public sealed class CustomerGenerateAccountActivationUrlOperationQueryBuilder : FieldsQueryBuilderBase<CustomerGenerateAccountActivationUrlPayload, CustomerGenerateAccountActivationUrlOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerGenerateAccountActivationUrlPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerGenerateAccountActivationUrlArgumentsBuilder Arguments { get; }
        protected override CustomerGenerateAccountActivationUrlOperationQueryBuilder Self => this;

        public CustomerGenerateAccountActivationUrlOperationQueryBuilder() : this("customerGenerateAccountActivationUrl")
        {
        }

        public CustomerGenerateAccountActivationUrlOperationQueryBuilder(string name) : base(new Query<CustomerGenerateAccountActivationUrlPayload>(name))
        {
            Arguments = new CustomerGenerateAccountActivationUrlArgumentsBuilder(base.InnerQuery);
        }

        public CustomerGenerateAccountActivationUrlOperationQueryBuilder(IQuery<CustomerGenerateAccountActivationUrlPayload> query) : base(query)
        {
            Arguments = new CustomerGenerateAccountActivationUrlArgumentsBuilder(base.InnerQuery);
        }

        public CustomerGenerateAccountActivationUrlOperationQueryBuilder AccountActivationUrl()
        {
            base.InnerQuery.AddField("accountActivationUrl");
            return this;
        }

        public CustomerGenerateAccountActivationUrlOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}