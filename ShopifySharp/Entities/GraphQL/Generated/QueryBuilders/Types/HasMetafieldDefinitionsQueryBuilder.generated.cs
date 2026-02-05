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
    public sealed class HasMetafieldDefinitionsQueryBuilder : FieldsQueryBuilderBase<IHasMetafieldDefinitions, HasMetafieldDefinitionsQueryBuilder>
    {
        protected override HasMetafieldDefinitionsQueryBuilder Self => this;

        public HasMetafieldDefinitionsQueryBuilder() : this("hasMetafieldDefinitions")
        {
        }

        public HasMetafieldDefinitionsQueryBuilder(string name) : base(new Query<IHasMetafieldDefinitions>(name))
        {
        }

        public HasMetafieldDefinitionsQueryBuilder(IQuery<IHasMetafieldDefinitions> query) : base(query)
        {
        }

        public HasMetafieldDefinitionsQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }
    }
}