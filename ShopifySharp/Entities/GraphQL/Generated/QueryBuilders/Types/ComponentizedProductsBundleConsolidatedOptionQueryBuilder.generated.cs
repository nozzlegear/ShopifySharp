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
    public sealed class ComponentizedProductsBundleConsolidatedOptionQueryBuilder : FieldsQueryBuilderBase<ComponentizedProductsBundleConsolidatedOption, ComponentizedProductsBundleConsolidatedOptionQueryBuilder>
    {
        protected override ComponentizedProductsBundleConsolidatedOptionQueryBuilder Self => this;

        public ComponentizedProductsBundleConsolidatedOptionQueryBuilder() : this("componentizedProductsBundleConsolidatedOption")
        {
        }

        public ComponentizedProductsBundleConsolidatedOptionQueryBuilder(string name) : base(new Query<ComponentizedProductsBundleConsolidatedOption>(name))
        {
        }

        public ComponentizedProductsBundleConsolidatedOptionQueryBuilder(IQuery<ComponentizedProductsBundleConsolidatedOption> query) : base(query)
        {
        }

        public ComponentizedProductsBundleConsolidatedOptionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ComponentizedProductsBundleConsolidatedOptionQueryBuilder Selections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ComponentizedProductsBundleConsolidatedOptionSelectionQueryBuilder> build)
        {
            var query = new Query<ComponentizedProductsBundleConsolidatedOptionSelection>("selections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ComponentizedProductsBundleConsolidatedOptionSelectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ComponentizedProductsBundleConsolidatedOptionSelection>(query);
            return this;
        }
    }
}