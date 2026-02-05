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
    public sealed class CustomerRemoveTaxExemptionsOperationQueryBuilder : FieldsQueryBuilderBase<CustomerRemoveTaxExemptionsPayload, CustomerRemoveTaxExemptionsOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerRemoveTaxExemptionsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerRemoveTaxExemptionsArgumentsBuilder Arguments { get; }
        protected override CustomerRemoveTaxExemptionsOperationQueryBuilder Self => this;

        public CustomerRemoveTaxExemptionsOperationQueryBuilder() : this("customerRemoveTaxExemptions")
        {
        }

        public CustomerRemoveTaxExemptionsOperationQueryBuilder(string name) : base(new Query<CustomerRemoveTaxExemptionsPayload>(name))
        {
            Arguments = new CustomerRemoveTaxExemptionsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerRemoveTaxExemptionsOperationQueryBuilder(IQuery<CustomerRemoveTaxExemptionsPayload> query) : base(query)
        {
            Arguments = new CustomerRemoveTaxExemptionsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerRemoveTaxExemptionsOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerRemoveTaxExemptionsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}