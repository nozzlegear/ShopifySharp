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
    public sealed class SavedSearchCreatePayloadQueryBuilder : FieldsQueryBuilderBase<SavedSearchCreatePayload, SavedSearchCreatePayloadQueryBuilder>
    {
        protected override SavedSearchCreatePayloadQueryBuilder Self => this;

        public SavedSearchCreatePayloadQueryBuilder() : this("savedSearchCreatePayload")
        {
        }

        public SavedSearchCreatePayloadQueryBuilder(string name) : base(new Query<SavedSearchCreatePayload>(name))
        {
        }

        public SavedSearchCreatePayloadQueryBuilder(IQuery<SavedSearchCreatePayload> query) : base(query)
        {
        }

        public SavedSearchCreatePayloadQueryBuilder SavedSearch(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchQueryBuilder> build)
        {
            var query = new Query<SavedSearch>("savedSearch");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SavedSearchQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearch>(query);
            return this;
        }

        public SavedSearchCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}