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
    public sealed class QueryRootTranslatableResourceQueryBuilder : FieldsQueryBuilderBase<TranslatableResource, QueryRootTranslatableResourceQueryBuilder>, IHasArguments<QueryRootTranslatableResourceArgumentsBuilder>
    {
        public QueryRootTranslatableResourceArgumentsBuilder Arguments { get; }
        protected override QueryRootTranslatableResourceQueryBuilder Self => this;

        public QueryRootTranslatableResourceQueryBuilder(string name) : base(new Query<TranslatableResource>(name))
        {
            Arguments = new QueryRootTranslatableResourceArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootTranslatableResourceQueryBuilder(IQuery<TranslatableResource> query) : base(query)
        {
            Arguments = new QueryRootTranslatableResourceArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootTranslatableResourceQueryBuilder SetArguments(Action<QueryRootTranslatableResourceArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootTranslatableResourceQueryBuilder NestedTranslatableResources(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceConnectionQueryBuilder> build)
        {
            var query = new Query<TranslatableResourceConnection>("nestedTranslatableResources");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResourceConnection>(query);
            return this;
        }

        public QueryRootTranslatableResourceQueryBuilder ResourceId()
        {
            base.InnerQuery.AddField("resourceId");
            return this;
        }

        public QueryRootTranslatableResourceQueryBuilder TranslatableContent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableContentQueryBuilder> build)
        {
            var query = new Query<TranslatableContent>("translatableContent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableContentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableContent>(query);
            return this;
        }

        public QueryRootTranslatableResourceQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }
    }
}