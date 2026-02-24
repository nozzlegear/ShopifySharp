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
    public sealed class ProductResourcePublicationsCountQueryBuilder : FieldsQueryBuilderBase<Count, ProductResourcePublicationsCountQueryBuilder>, IHasArguments<ProductResourcePublicationsCountArgumentsBuilder>
    {
        public ProductResourcePublicationsCountArgumentsBuilder Arguments { get; }
        protected override ProductResourcePublicationsCountQueryBuilder Self => this;

        public ProductResourcePublicationsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new ProductResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public ProductResourcePublicationsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new ProductResourcePublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public ProductResourcePublicationsCountQueryBuilder SetArguments(Action<ProductResourcePublicationsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductResourcePublicationsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public ProductResourcePublicationsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}