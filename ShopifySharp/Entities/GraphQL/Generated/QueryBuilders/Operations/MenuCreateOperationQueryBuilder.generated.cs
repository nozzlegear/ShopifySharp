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
    public sealed class MenuCreateOperationQueryBuilder : FieldsQueryBuilderBase<MenuCreatePayload, MenuCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<MenuCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MenuCreateArgumentsBuilder Arguments { get; }
        protected override MenuCreateOperationQueryBuilder Self => this;

        public MenuCreateOperationQueryBuilder() : this("menuCreate")
        {
        }

        public MenuCreateOperationQueryBuilder(string name) : base(new Query<MenuCreatePayload>(name))
        {
            Arguments = new MenuCreateArgumentsBuilder(base.InnerQuery);
        }

        public MenuCreateOperationQueryBuilder(IQuery<MenuCreatePayload> query) : base(query)
        {
            Arguments = new MenuCreateArgumentsBuilder(base.InnerQuery);
        }

        public MenuCreateOperationQueryBuilder Menu(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder> build)
        {
            var query = new Query<Menu>("menu");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Menu>(query);
            return this;
        }

        public MenuCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<MenuCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuCreateUserError>(query);
            return this;
        }
    }
}