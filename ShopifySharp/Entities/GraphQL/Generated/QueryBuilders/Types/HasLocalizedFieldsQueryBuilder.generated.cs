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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class HasLocalizedFieldsQueryBuilder : FieldsQueryBuilderBase<IHasLocalizedFields, HasLocalizedFieldsQueryBuilder>
    {
        protected override HasLocalizedFieldsQueryBuilder Self => this;

        public HasLocalizedFieldsQueryBuilder() : this("hasLocalizedFields")
        {
        }

        public HasLocalizedFieldsQueryBuilder(string name) : base(new Query<IHasLocalizedFields>(name))
        {
        }

        public HasLocalizedFieldsQueryBuilder(IQuery<IHasLocalizedFields> query) : base(query)
        {
        }

        public HasLocalizedFieldsQueryBuilder LocalizedFields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizedFieldConnection>("localizedFields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizedFieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedFieldConnection>(query);
            return this;
        }
    }
}