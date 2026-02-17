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
    public sealed class ThemeCreateOperationQueryBuilder : FieldsQueryBuilderBase<ThemeCreatePayload, ThemeCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<ThemeCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ThemeCreateArgumentsBuilder Arguments { get; }
        protected override ThemeCreateOperationQueryBuilder Self => this;

        public ThemeCreateOperationQueryBuilder() : this("themeCreate")
        {
        }

        public ThemeCreateOperationQueryBuilder(string name) : base(new Query<ThemeCreatePayload>(name))
        {
            Arguments = new ThemeCreateArgumentsBuilder(base.InnerQuery);
        }

        public ThemeCreateOperationQueryBuilder(IQuery<ThemeCreatePayload> query) : base(query)
        {
            Arguments = new ThemeCreateArgumentsBuilder(base.InnerQuery);
        }

        public ThemeCreateOperationQueryBuilder Theme(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreTheme>("theme");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreTheme>(query);
            return this;
        }

        public ThemeCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ThemeCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<ThemeCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ThemeCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ThemeCreateUserError>(query);
            return this;
        }
    }
}