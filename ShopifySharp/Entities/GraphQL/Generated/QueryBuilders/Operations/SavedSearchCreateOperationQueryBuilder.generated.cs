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
    public sealed class SavedSearchCreateOperationQueryBuilder : FieldsQueryBuilderBase<SavedSearchCreatePayload, SavedSearchCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<SavedSearchCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SavedSearchCreateArgumentsBuilder Arguments { get; }
        protected override SavedSearchCreateOperationQueryBuilder Self => this;

        public SavedSearchCreateOperationQueryBuilder() : this("savedSearchCreate")
        {
        }

        public SavedSearchCreateOperationQueryBuilder(string name) : base(new Query<SavedSearchCreatePayload>(name))
        {
            Arguments = new SavedSearchCreateArgumentsBuilder(base.InnerQuery);
        }

        public SavedSearchCreateOperationQueryBuilder(IQuery<SavedSearchCreatePayload> query) : base(query)
        {
            Arguments = new SavedSearchCreateArgumentsBuilder(base.InnerQuery);
        }

        public SavedSearchCreateOperationQueryBuilder SavedSearch(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchQueryBuilder> build)
        {
            var query = new Query<SavedSearch>("savedSearch");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SavedSearchQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SavedSearch>(query);
            return this;
        }

        public SavedSearchCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}