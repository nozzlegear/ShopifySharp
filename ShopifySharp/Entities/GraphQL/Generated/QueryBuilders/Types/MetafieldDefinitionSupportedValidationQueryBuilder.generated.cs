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
    public sealed class MetafieldDefinitionSupportedValidationQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionSupportedValidation, MetafieldDefinitionSupportedValidationQueryBuilder>
    {
        protected override MetafieldDefinitionSupportedValidationQueryBuilder Self => this;

        public MetafieldDefinitionSupportedValidationQueryBuilder() : this("metafieldDefinitionSupportedValidation")
        {
        }

        public MetafieldDefinitionSupportedValidationQueryBuilder(string name) : base(new Query<MetafieldDefinitionSupportedValidation>(name))
        {
        }

        public MetafieldDefinitionSupportedValidationQueryBuilder(IQuery<MetafieldDefinitionSupportedValidation> query) : base(query)
        {
        }

        public MetafieldDefinitionSupportedValidationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetafieldDefinitionSupportedValidationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}