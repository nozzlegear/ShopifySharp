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
    public sealed class CustomerReplaceTaxExemptionsOperationQueryBuilder : FieldsQueryBuilderBase<CustomerReplaceTaxExemptionsPayload, CustomerReplaceTaxExemptionsOperationQueryBuilder>, IGraphOperationQueryBuilder<CustomerReplaceTaxExemptionsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CustomerReplaceTaxExemptionsArgumentsBuilder Arguments { get; }
        protected override CustomerReplaceTaxExemptionsOperationQueryBuilder Self => this;

        public CustomerReplaceTaxExemptionsOperationQueryBuilder() : this("customerReplaceTaxExemptions")
        {
        }

        public CustomerReplaceTaxExemptionsOperationQueryBuilder(string name) : base(new Query<CustomerReplaceTaxExemptionsPayload>(name))
        {
            Arguments = new CustomerReplaceTaxExemptionsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerReplaceTaxExemptionsOperationQueryBuilder(IQuery<CustomerReplaceTaxExemptionsPayload> query) : base(query)
        {
            Arguments = new CustomerReplaceTaxExemptionsArgumentsBuilder(base.InnerQuery);
        }

        public CustomerReplaceTaxExemptionsOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CustomerReplaceTaxExemptionsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}