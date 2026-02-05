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
    public sealed class StandardMetafieldDefinitionTemplateQueryBuilder : FieldsQueryBuilderBase<StandardMetafieldDefinitionTemplate, StandardMetafieldDefinitionTemplateQueryBuilder>
    {
        protected override StandardMetafieldDefinitionTemplateQueryBuilder Self => this;

        public StandardMetafieldDefinitionTemplateQueryBuilder() : this("standardMetafieldDefinitionTemplate")
        {
        }

        public StandardMetafieldDefinitionTemplateQueryBuilder(string name) : base(new Query<StandardMetafieldDefinitionTemplate>(name))
        {
        }

        public StandardMetafieldDefinitionTemplateQueryBuilder(IQuery<StandardMetafieldDefinitionTemplate> query) : base(query)
        {
        }

        public StandardMetafieldDefinitionTemplateQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public StandardMetafieldDefinitionTemplateQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public StandardMetafieldDefinitionTemplateQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public StandardMetafieldDefinitionTemplateQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public StandardMetafieldDefinitionTemplateQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }

        public StandardMetafieldDefinitionTemplateQueryBuilder OwnerTypes()
        {
            base.InnerQuery.AddField("ownerTypes");
            return this;
        }

        public StandardMetafieldDefinitionTemplateQueryBuilder Type(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionType>("type");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionType>(query);
            return this;
        }

        public StandardMetafieldDefinitionTemplateQueryBuilder Validations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionValidation>("validations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionValidation>(query);
            return this;
        }

        public StandardMetafieldDefinitionTemplateQueryBuilder VisibleToStorefrontApi()
        {
            base.InnerQuery.AddField("visibleToStorefrontApi");
            return this;
        }
    }
}