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
    public sealed class CashDrawerFindOrCreateOperationQueryBuilder : FieldsQueryBuilderBase<CashDrawerFindOrCreatePayload, CashDrawerFindOrCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<CashDrawerFindOrCreatePayload>, IHasArguments<CashDrawerFindOrCreateArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public CashDrawerFindOrCreateArgumentsBuilder Arguments { get; }
        protected override CashDrawerFindOrCreateOperationQueryBuilder Self => this;

        public CashDrawerFindOrCreateOperationQueryBuilder() : this("cashDrawerFindOrCreate")
        {
        }

        public CashDrawerFindOrCreateOperationQueryBuilder(string name) : base(new Query<CashDrawerFindOrCreatePayload>(name))
        {
            Arguments = new CashDrawerFindOrCreateArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerFindOrCreateOperationQueryBuilder(IQuery<CashDrawerFindOrCreatePayload> query) : base(query)
        {
            Arguments = new CashDrawerFindOrCreateArgumentsBuilder(base.InnerQuery);
        }

        public CashDrawerFindOrCreateOperationQueryBuilder SetArguments(Action<CashDrawerFindOrCreateArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashDrawerFindOrCreateOperationQueryBuilder CashDrawer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("cashDrawer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawer>(query);
            return this;
        }

        public CashDrawerFindOrCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerFindOrCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<CashDrawerFindOrCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerFindOrCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawerFindOrCreateUserError>(query);
            return this;
        }
    }
}