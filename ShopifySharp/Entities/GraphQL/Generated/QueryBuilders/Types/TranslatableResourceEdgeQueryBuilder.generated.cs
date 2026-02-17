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
    public sealed class TranslatableResourceEdgeQueryBuilder : FieldsQueryBuilderBase<TranslatableResourceEdge, TranslatableResourceEdgeQueryBuilder>
    {
        protected override TranslatableResourceEdgeQueryBuilder Self => this;

        public TranslatableResourceEdgeQueryBuilder() : this("translatableResourceEdge")
        {
        }

        public TranslatableResourceEdgeQueryBuilder(string name) : base(new Query<TranslatableResourceEdge>(name))
        {
        }

        public TranslatableResourceEdgeQueryBuilder(IQuery<TranslatableResourceEdge> query) : base(query)
        {
        }

        public TranslatableResourceEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public TranslatableResourceEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceQueryBuilder> build)
        {
            var query = new Query<TranslatableResource>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResource>(query);
            return this;
        }
    }
}