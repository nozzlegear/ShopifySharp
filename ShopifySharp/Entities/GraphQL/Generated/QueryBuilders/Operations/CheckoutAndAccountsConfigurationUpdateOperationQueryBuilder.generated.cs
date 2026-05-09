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
    public sealed class CheckoutAndAccountsConfigurationUpdateOperationQueryBuilder : FieldsQueryBuilderBase<CheckoutAndAccountsConfigurationUpdatePayload, CheckoutAndAccountsConfigurationUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<CheckoutAndAccountsConfigurationUpdatePayload>, IHasArguments<CheckoutAndAccountsConfigurationUpdateArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CheckoutAndAccountsConfigurationUpdateArgumentsBuilder Arguments { get; }
        protected override CheckoutAndAccountsConfigurationUpdateOperationQueryBuilder Self => this;

        public CheckoutAndAccountsConfigurationUpdateOperationQueryBuilder() : this("checkoutAndAccountsConfigurationUpdate")
        {
        }

        public CheckoutAndAccountsConfigurationUpdateOperationQueryBuilder(string name) : base(new Query<CheckoutAndAccountsConfigurationUpdatePayload>(name))
        {
            Arguments = new CheckoutAndAccountsConfigurationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutAndAccountsConfigurationUpdateOperationQueryBuilder(IQuery<CheckoutAndAccountsConfigurationUpdatePayload> query) : base(query)
        {
            Arguments = new CheckoutAndAccountsConfigurationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutAndAccountsConfigurationUpdateOperationQueryBuilder SetArguments(Action<CheckoutAndAccountsConfigurationUpdateArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CheckoutAndAccountsConfigurationUpdateOperationQueryBuilder Configuration(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfiguration>("configuration");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfiguration>(query);
            return this;
        }

        public CheckoutAndAccountsConfigurationUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationUserErrorQueryBuilder> build)
        {
            var query = new Query<CheckoutAndAccountsConfigurationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CheckoutAndAccountsConfigurationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutAndAccountsConfigurationUserError>(query);
            return this;
        }
    }
}