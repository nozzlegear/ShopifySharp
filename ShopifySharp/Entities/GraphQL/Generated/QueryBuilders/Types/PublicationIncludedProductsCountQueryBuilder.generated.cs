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
    public sealed class PublicationIncludedProductsCountQueryBuilder : FieldsQueryBuilderBase<Count, PublicationIncludedProductsCountQueryBuilder>, IHasArguments<PublicationIncludedProductsCountArgumentsBuilder>
    {
        public PublicationIncludedProductsCountArgumentsBuilder Arguments { get; }
        protected override PublicationIncludedProductsCountQueryBuilder Self => this;

        public PublicationIncludedProductsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new PublicationIncludedProductsCountArgumentsBuilder(base.InnerQuery);
        }

        public PublicationIncludedProductsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new PublicationIncludedProductsCountArgumentsBuilder(base.InnerQuery);
        }

        public PublicationIncludedProductsCountQueryBuilder SetArguments(Action<PublicationIncludedProductsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PublicationIncludedProductsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public PublicationIncludedProductsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}