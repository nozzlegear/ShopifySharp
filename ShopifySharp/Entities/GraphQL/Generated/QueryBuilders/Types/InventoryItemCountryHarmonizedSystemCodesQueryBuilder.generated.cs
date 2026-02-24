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
    public sealed class InventoryItemCountryHarmonizedSystemCodesQueryBuilder : FieldsQueryBuilderBase<CountryHarmonizedSystemCodeConnection, InventoryItemCountryHarmonizedSystemCodesQueryBuilder>, IHasArguments<InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder>
    {
        public InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder Arguments { get; }
        protected override InventoryItemCountryHarmonizedSystemCodesQueryBuilder Self => this;

        public InventoryItemCountryHarmonizedSystemCodesQueryBuilder(string name) : base(new Query<CountryHarmonizedSystemCodeConnection>(name))
        {
            Arguments = new InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryItemCountryHarmonizedSystemCodesQueryBuilder(IQuery<CountryHarmonizedSystemCodeConnection> query) : base(query)
        {
            Arguments = new InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryItemCountryHarmonizedSystemCodesQueryBuilder SetArguments(Action<InventoryItemCountryHarmonizedSystemCodesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryItemCountryHarmonizedSystemCodesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeEdgeQueryBuilder> build)
        {
            var query = new Query<CountryHarmonizedSystemCodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CountryHarmonizedSystemCodeEdge>(query);
            return this;
        }

        public InventoryItemCountryHarmonizedSystemCodesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeQueryBuilder> build)
        {
            var query = new Query<CountryHarmonizedSystemCode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CountryHarmonizedSystemCode>(query);
            return this;
        }

        public InventoryItemCountryHarmonizedSystemCodesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}