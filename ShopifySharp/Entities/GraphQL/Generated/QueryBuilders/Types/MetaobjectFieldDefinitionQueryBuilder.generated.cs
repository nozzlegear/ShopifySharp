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
    public sealed class MetaobjectFieldDefinitionQueryBuilder : FieldsQueryBuilderBase<MetaobjectFieldDefinition, MetaobjectFieldDefinitionQueryBuilder>
    {
        protected override MetaobjectFieldDefinitionQueryBuilder Self => this;

        public MetaobjectFieldDefinitionQueryBuilder() : this("metaobjectFieldDefinition")
        {
        }

        public MetaobjectFieldDefinitionQueryBuilder(string name) : base(new Query<MetaobjectFieldDefinition>(name))
        {
        }

        public MetaobjectFieldDefinitionQueryBuilder(IQuery<MetaobjectFieldDefinition> query) : base(query)
        {
        }

        public MetaobjectFieldDefinitionQueryBuilder Capabilities(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldDefinitionCapabilitiesQueryBuilder> build)
        {
            var query = new Query<MetaobjectFieldDefinitionCapabilities>("capabilities");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetaobjectFieldDefinitionCapabilitiesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectFieldDefinitionCapabilities>(query);
            return this;
        }

        public MetaobjectFieldDefinitionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public MetaobjectFieldDefinitionQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MetaobjectFieldDefinitionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetaobjectFieldDefinitionQueryBuilder Required()
        {
            base.InnerQuery.AddField("required");
            return this;
        }

        public MetaobjectFieldDefinitionQueryBuilder Type(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionType>("type");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionType>(query);
            return this;
        }

        public MetaobjectFieldDefinitionQueryBuilder Validations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionValidation>("validations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionValidation>(query);
            return this;
        }
    }
}