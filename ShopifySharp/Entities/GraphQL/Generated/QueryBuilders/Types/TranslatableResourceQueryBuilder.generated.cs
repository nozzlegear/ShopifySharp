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
    public sealed class TranslatableResourceQueryBuilder : FieldsQueryBuilderBase<TranslatableResource, TranslatableResourceQueryBuilder>
    {
        protected override TranslatableResourceQueryBuilder Self => this;

        public TranslatableResourceQueryBuilder() : this("translatableResource")
        {
        }

        public TranslatableResourceQueryBuilder(string name) : base(new Query<TranslatableResource>(name))
        {
        }

        public TranslatableResourceQueryBuilder(IQuery<TranslatableResource> query) : base(query)
        {
        }

        public TranslatableResourceQueryBuilder NestedTranslatableResources(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceConnectionQueryBuilder> build)
        {
            var query = new Query<TranslatableResourceConnection>("nestedTranslatableResources");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResourceConnection>(query);
            return this;
        }

        public TranslatableResourceQueryBuilder ResourceId()
        {
            base.InnerQuery.AddField("resourceId");
            return this;
        }

        public TranslatableResourceQueryBuilder TranslatableContent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableContentQueryBuilder> build)
        {
            var query = new Query<TranslatableContent>("translatableContent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableContentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableContent>(query);
            return this;
        }

        public TranslatableResourceQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }
    }
}