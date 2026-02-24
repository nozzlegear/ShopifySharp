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
    public sealed class QueryRootWebPixelQueryBuilder : FieldsQueryBuilderBase<WebPixel, QueryRootWebPixelQueryBuilder>, IHasArguments<QueryRootWebPixelArgumentsBuilder>
    {
        public QueryRootWebPixelArgumentsBuilder Arguments { get; }
        protected override QueryRootWebPixelQueryBuilder Self => this;

        public QueryRootWebPixelQueryBuilder(string name) : base(new Query<WebPixel>(name))
        {
            Arguments = new QueryRootWebPixelArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootWebPixelQueryBuilder(IQuery<WebPixel> query) : base(query)
        {
            Arguments = new QueryRootWebPixelArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootWebPixelQueryBuilder SetArguments(Action<QueryRootWebPixelArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootWebPixelQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootWebPixelQueryBuilder Settings()
        {
            base.InnerQuery.AddField("settings");
            return this;
        }
    }
}