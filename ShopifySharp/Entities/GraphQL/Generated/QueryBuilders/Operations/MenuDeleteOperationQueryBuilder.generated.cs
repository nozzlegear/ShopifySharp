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
    public sealed class MenuDeleteOperationQueryBuilder : FieldsQueryBuilderBase<MenuDeletePayload, MenuDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<MenuDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MenuDeleteArgumentsBuilder Arguments { get; }
        protected override MenuDeleteOperationQueryBuilder Self => this;

        public MenuDeleteOperationQueryBuilder() : this("menuDelete")
        {
        }

        public MenuDeleteOperationQueryBuilder(string name) : base(new Query<MenuDeletePayload>(name))
        {
            Arguments = new MenuDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MenuDeleteOperationQueryBuilder(IQuery<MenuDeletePayload> query) : base(query)
        {
            Arguments = new MenuDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MenuDeleteOperationQueryBuilder DeletedMenuId()
        {
            base.InnerQuery.AddField("deletedMenuId");
            return this;
        }

        public MenuDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<MenuDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MenuDeleteUserError>(query);
            return this;
        }
    }
}