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
    public sealed class MetafieldDefinitionTypeQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionType, MetafieldDefinitionTypeQueryBuilder>
    {
        protected override MetafieldDefinitionTypeQueryBuilder Self => this;

        public MetafieldDefinitionTypeQueryBuilder() : this("metafieldDefinitionType")
        {
        }

        public MetafieldDefinitionTypeQueryBuilder(string name) : base(new Query<MetafieldDefinitionType>(name))
        {
        }

        public MetafieldDefinitionTypeQueryBuilder(IQuery<MetafieldDefinitionType> query) : base(query)
        {
        }

        public MetafieldDefinitionTypeQueryBuilder Category()
        {
            base.InnerQuery.AddField("category");
            return this;
        }

        public MetafieldDefinitionTypeQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetafieldDefinitionTypeQueryBuilder SupportedValidations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionSupportedValidationQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionSupportedValidation>("supportedValidations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionSupportedValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionSupportedValidation>(query);
            return this;
        }

        public MetafieldDefinitionTypeQueryBuilder SupportsDefinitionMigrations()
        {
            base.InnerQuery.AddField("supportsDefinitionMigrations");
            return this;
        }

        [Obsolete("`valueType` is deprecated and `name` should be used for type information.")]
        public MetafieldDefinitionTypeQueryBuilder ValueType()
        {
            base.InnerQuery.AddField("valueType");
            return this;
        }
    }
}