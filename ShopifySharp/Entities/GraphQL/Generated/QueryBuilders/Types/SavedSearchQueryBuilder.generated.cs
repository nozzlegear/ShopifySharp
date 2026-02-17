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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class SavedSearchQueryBuilder : FieldsQueryBuilderBase<SavedSearch, SavedSearchQueryBuilder>
    {
        protected override SavedSearchQueryBuilder Self => this;

        public SavedSearchQueryBuilder() : this("savedSearch")
        {
        }

        public SavedSearchQueryBuilder(string name) : base(new Query<SavedSearch>(name))
        {
        }

        public SavedSearchQueryBuilder(IQuery<SavedSearch> query) : base(query)
        {
        }

        public SavedSearchQueryBuilder Filters(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SearchFilterQueryBuilder> build)
        {
            var query = new Query<SearchFilter>("filters");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SearchFilterQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SearchFilter>(query);
            return this;
        }

        public SavedSearchQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SavedSearchQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public SavedSearchQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public SavedSearchQueryBuilder Query()
        {
            base.InnerQuery.AddField("query");
            return this;
        }

        public SavedSearchQueryBuilder ResourceType()
        {
            base.InnerQuery.AddField("resourceType");
            return this;
        }

        public SavedSearchQueryBuilder SearchTerms()
        {
            base.InnerQuery.AddField("searchTerms");
            return this;
        }
    }
}