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
    public sealed class CountryHarmonizedSystemCodeEdgeQueryBuilder : FieldsQueryBuilderBase<CountryHarmonizedSystemCodeEdge, CountryHarmonizedSystemCodeEdgeQueryBuilder>
    {
        protected override CountryHarmonizedSystemCodeEdgeQueryBuilder Self => this;

        public CountryHarmonizedSystemCodeEdgeQueryBuilder() : this("countryHarmonizedSystemCodeEdge")
        {
        }

        public CountryHarmonizedSystemCodeEdgeQueryBuilder(string name) : base(new Query<CountryHarmonizedSystemCodeEdge>(name))
        {
        }

        public CountryHarmonizedSystemCodeEdgeQueryBuilder(IQuery<CountryHarmonizedSystemCodeEdge> query) : base(query)
        {
        }

        public CountryHarmonizedSystemCodeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CountryHarmonizedSystemCodeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeQueryBuilder> build)
        {
            var query = new Query<CountryHarmonizedSystemCode>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CountryHarmonizedSystemCode>(query);
            return this;
        }
    }
}