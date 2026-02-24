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
    public sealed class MobilePlatformApplicationQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplication, MobilePlatformApplicationQueryBuilder>, IHasArguments<MobilePlatformApplicationArgumentsBuilder>
    {
        public MobilePlatformApplicationArgumentsBuilder Arguments { get; }
        protected override MobilePlatformApplicationQueryBuilder Self => this;

        public MobilePlatformApplicationQueryBuilder() : this("mobilePlatformApplication")
        {
        }

        public MobilePlatformApplicationQueryBuilder(string name) : base(new Query<MobilePlatformApplication>(name))
        {
            Arguments = new MobilePlatformApplicationArgumentsBuilder(base.InnerQuery);
        }

        public MobilePlatformApplicationQueryBuilder(IQuery<MobilePlatformApplication> query) : base(query)
        {
            Arguments = new MobilePlatformApplicationArgumentsBuilder(base.InnerQuery);
        }

        public MobilePlatformApplicationQueryBuilder SetArguments(Action<MobilePlatformApplicationArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MobilePlatformApplicationQueryBuilder MobilePlatformApplication(Action<MobilePlatformApplicationUnionCasesBuilder> build)
        {
            var query = new Query<MobilePlatformApplication>("mobilePlatformApplication");
            var unionBuilder = new MobilePlatformApplicationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}