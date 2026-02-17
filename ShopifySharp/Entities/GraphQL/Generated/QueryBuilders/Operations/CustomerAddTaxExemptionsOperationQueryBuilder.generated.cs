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
    public sealed class CustomerAddTaxExemptionsOperationQueryBuilder : FieldsQueryBuilderBase<CustomerAddTaxExemptionsPayload, CustomerAddTaxExemptionsOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerAddTaxExemptionsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerAddTaxExemptionsArgumentsBuilder Arguments { get; }
        protected override CustomerAddTaxExemptionsOperationQueryBuilder Self => this;

        public CustomerAddTaxExemptionsOperationQueryBuilder() : this("customerAddTaxExemptions")
        {
        }

        public CustomerAddTaxExemptionsOperationQueryBuilder(string name) : base(new Query<CustomerAddTaxExemptionsPayload>(name))
        {
            Arguments = new CustomerAddTaxExemptionsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAddTaxExemptionsOperationQueryBuilder(IQuery<CustomerAddTaxExemptionsPayload> query) : base(query)
        {
            Arguments = new CustomerAddTaxExemptionsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerAddTaxExemptionsOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerAddTaxExemptionsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}