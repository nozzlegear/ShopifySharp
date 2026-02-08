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
    public sealed class MetafieldDefinitionUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionUpdateUserError, MetafieldDefinitionUpdateUserErrorQueryBuilder>
    {
        protected override MetafieldDefinitionUpdateUserErrorQueryBuilder Self => this;

        public MetafieldDefinitionUpdateUserErrorQueryBuilder() : this("metafieldDefinitionUpdateUserError")
        {
        }

        public MetafieldDefinitionUpdateUserErrorQueryBuilder(string name) : base(new Query<MetafieldDefinitionUpdateUserError>(name))
        {
        }

        public MetafieldDefinitionUpdateUserErrorQueryBuilder(IQuery<MetafieldDefinitionUpdateUserError> query) : base(query)
        {
        }

        public MetafieldDefinitionUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MetafieldDefinitionUpdateUserErrorQueryBuilder ElementIndex()
        {
            base.InnerQuery.AddField("elementIndex");
            return this;
        }

        public MetafieldDefinitionUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MetafieldDefinitionUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}