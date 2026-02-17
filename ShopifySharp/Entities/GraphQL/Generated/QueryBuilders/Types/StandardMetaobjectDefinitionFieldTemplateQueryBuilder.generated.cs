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
    public sealed class StandardMetaobjectDefinitionFieldTemplateQueryBuilder : FieldsQueryBuilderBase<StandardMetaobjectDefinitionFieldTemplate, StandardMetaobjectDefinitionFieldTemplateQueryBuilder>
    {
        protected override StandardMetaobjectDefinitionFieldTemplateQueryBuilder Self => this;

        public StandardMetaobjectDefinitionFieldTemplateQueryBuilder() : this("standardMetaobjectDefinitionFieldTemplate")
        {
        }

        public StandardMetaobjectDefinitionFieldTemplateQueryBuilder(string name) : base(new Query<StandardMetaobjectDefinitionFieldTemplate>(name))
        {
        }

        public StandardMetaobjectDefinitionFieldTemplateQueryBuilder(IQuery<StandardMetaobjectDefinitionFieldTemplate> query) : base(query)
        {
        }

        public StandardMetaobjectDefinitionFieldTemplateQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public StandardMetaobjectDefinitionFieldTemplateQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public StandardMetaobjectDefinitionFieldTemplateQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public StandardMetaobjectDefinitionFieldTemplateQueryBuilder Required()
        {
            base.InnerQuery.AddField("required");
            return this;
        }

        public StandardMetaobjectDefinitionFieldTemplateQueryBuilder Type(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionType>("type");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionType>(query);
            return this;
        }

        public StandardMetaobjectDefinitionFieldTemplateQueryBuilder Validations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionValidation>("validations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionValidation>(query);
            return this;
        }

        public StandardMetaobjectDefinitionFieldTemplateQueryBuilder VisibleToStorefrontApi()
        {
            base.InnerQuery.AddField("visibleToStorefrontApi");
            return this;
        }
    }
}