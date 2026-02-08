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
    public sealed class MetafieldDefinitionValidationQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionValidation, MetafieldDefinitionValidationQueryBuilder>
    {
        protected override MetafieldDefinitionValidationQueryBuilder Self => this;

        public MetafieldDefinitionValidationQueryBuilder() : this("metafieldDefinitionValidation")
        {
        }

        public MetafieldDefinitionValidationQueryBuilder(string name) : base(new Query<MetafieldDefinitionValidation>(name))
        {
        }

        public MetafieldDefinitionValidationQueryBuilder(IQuery<MetafieldDefinitionValidation> query) : base(query)
        {
        }

        public MetafieldDefinitionValidationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetafieldDefinitionValidationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public MetafieldDefinitionValidationQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}