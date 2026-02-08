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
    public sealed class ShopLocaleUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ShopLocaleUpdatePayload, ShopLocaleUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopLocaleUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ShopLocaleUpdateArgumentsBuilder Arguments { get; }
        protected override ShopLocaleUpdateOperationQueryBuilder Self => this;

        public ShopLocaleUpdateOperationQueryBuilder() : this("shopLocaleUpdate")
        {
        }

        public ShopLocaleUpdateOperationQueryBuilder(string name) : base(new Query<ShopLocaleUpdatePayload>(name))
        {
            Arguments = new ShopLocaleUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ShopLocaleUpdateOperationQueryBuilder(IQuery<ShopLocaleUpdatePayload> query) : base(query)
        {
            Arguments = new ShopLocaleUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ShopLocaleUpdateOperationQueryBuilder ShopLocale(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopLocaleQueryBuilder> build)
        {
            var query = new Query<ShopLocale>("shopLocale");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopLocaleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopLocale>(query);
            return this;
        }

        public ShopLocaleUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}