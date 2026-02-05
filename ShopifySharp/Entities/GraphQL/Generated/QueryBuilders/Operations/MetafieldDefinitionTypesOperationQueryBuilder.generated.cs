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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class MetafieldDefinitionTypesOperationQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionType, MetafieldDefinitionTypesOperationQueryBuilder>, IGraphOperationQueryBuilder<MetafieldDefinitionType>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override MetafieldDefinitionTypesOperationQueryBuilder Self => this;

        public MetafieldDefinitionTypesOperationQueryBuilder() : this("metafieldDefinitionTypes")
        {
        }

        public MetafieldDefinitionTypesOperationQueryBuilder(string name) : base(new Query<MetafieldDefinitionType>(name))
        {
        }

        public MetafieldDefinitionTypesOperationQueryBuilder(IQuery<MetafieldDefinitionType> query) : base(query)
        {
        }

        public MetafieldDefinitionTypesOperationQueryBuilder Category()
        {
            base.InnerQuery.AddField("category");
            return this;
        }

        public MetafieldDefinitionTypesOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetafieldDefinitionTypesOperationQueryBuilder SupportedValidations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionSupportedValidationQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionSupportedValidation>("supportedValidations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionSupportedValidationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionSupportedValidation>(query);
            return this;
        }

        public MetafieldDefinitionTypesOperationQueryBuilder SupportsDefinitionMigrations()
        {
            base.InnerQuery.AddField("supportsDefinitionMigrations");
            return this;
        }

        [Obsolete("`valueType` is deprecated and `name` should be used for type information.")]
        public MetafieldDefinitionTypesOperationQueryBuilder ValueType()
        {
            base.InnerQuery.AddField("valueType");
            return this;
        }
    }
}