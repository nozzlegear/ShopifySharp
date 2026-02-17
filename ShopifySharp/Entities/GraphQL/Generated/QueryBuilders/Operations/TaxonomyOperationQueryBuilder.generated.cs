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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class TaxonomyOperationQueryBuilder : FieldsQueryBuilderBase<Taxonomy, TaxonomyOperationQueryBuilder>, IGraphOperationQueryBuilder<Taxonomy>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override TaxonomyOperationQueryBuilder Self => this;

        public TaxonomyOperationQueryBuilder() : this("taxonomy")
        {
        }

        public TaxonomyOperationQueryBuilder(string name) : base(new Query<Taxonomy>(name))
        {
        }

        public TaxonomyOperationQueryBuilder(IQuery<Taxonomy> query) : base(query)
        {
        }

        public TaxonomyOperationQueryBuilder Categories(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryConnectionQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategoryConnection>("categories");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategoryConnection>(query);
            return this;
        }
    }
}