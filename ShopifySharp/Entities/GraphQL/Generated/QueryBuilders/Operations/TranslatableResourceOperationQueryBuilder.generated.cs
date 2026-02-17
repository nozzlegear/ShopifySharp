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
    public sealed class TranslatableResourceOperationQueryBuilder : FieldsQueryBuilderBase<TranslatableResource, TranslatableResourceOperationQueryBuilder>, IGraphOperationQueryBuilder<TranslatableResource>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public TranslatableResourceArgumentsBuilder Arguments { get; }
        protected override TranslatableResourceOperationQueryBuilder Self => this;

        public TranslatableResourceOperationQueryBuilder() : this("translatableResource")
        {
        }

        public TranslatableResourceOperationQueryBuilder(string name) : base(new Query<TranslatableResource>(name))
        {
            Arguments = new TranslatableResourceArgumentsBuilder(base.InnerQuery);
        }

        public TranslatableResourceOperationQueryBuilder(IQuery<TranslatableResource> query) : base(query)
        {
            Arguments = new TranslatableResourceArgumentsBuilder(base.InnerQuery);
        }

        public TranslatableResourceOperationQueryBuilder NestedTranslatableResources(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceConnectionQueryBuilder> build)
        {
            var query = new Query<TranslatableResourceConnection>("nestedTranslatableResources");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResourceConnection>(query);
            return this;
        }

        public TranslatableResourceOperationQueryBuilder ResourceId()
        {
            base.InnerQuery.AddField("resourceId");
            return this;
        }

        public TranslatableResourceOperationQueryBuilder TranslatableContent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableContentQueryBuilder> build)
        {
            var query = new Query<TranslatableContent>("translatableContent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableContentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableContent>(query);
            return this;
        }

        public TranslatableResourceOperationQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }
    }
}