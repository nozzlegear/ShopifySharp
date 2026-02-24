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
    public sealed class QueryRootMobilePlatformApplicationQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplication, QueryRootMobilePlatformApplicationQueryBuilder>, IHasArguments<QueryRootMobilePlatformApplicationArgumentsBuilder>
    {
        public QueryRootMobilePlatformApplicationArgumentsBuilder Arguments { get; }
        protected override QueryRootMobilePlatformApplicationQueryBuilder Self => this;

        public QueryRootMobilePlatformApplicationQueryBuilder(string name) : base(new Query<MobilePlatformApplication>(name))
        {
            Arguments = new QueryRootMobilePlatformApplicationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMobilePlatformApplicationQueryBuilder(IQuery<MobilePlatformApplication> query) : base(query)
        {
            Arguments = new QueryRootMobilePlatformApplicationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMobilePlatformApplicationQueryBuilder SetArguments(Action<QueryRootMobilePlatformApplicationArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootMobilePlatformApplicationQueryBuilder MobilePlatformApplication(Action<MobilePlatformApplicationUnionCasesBuilder> build)
        {
            var query = new Query<MobilePlatformApplication>("mobilePlatformApplication");
            var unionBuilder = new MobilePlatformApplicationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}