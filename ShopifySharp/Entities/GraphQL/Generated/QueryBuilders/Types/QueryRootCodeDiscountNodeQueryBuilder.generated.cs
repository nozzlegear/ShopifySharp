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
    public sealed class QueryRootCodeDiscountNodeQueryBuilder : FieldsQueryBuilderBase<DiscountCodeNode, QueryRootCodeDiscountNodeQueryBuilder>, IHasArguments<QueryRootCodeDiscountNodeArgumentsBuilder>
    {
        public QueryRootCodeDiscountNodeArgumentsBuilder Arguments { get; }
        protected override QueryRootCodeDiscountNodeQueryBuilder Self => this;

        public QueryRootCodeDiscountNodeQueryBuilder(string name) : base(new Query<DiscountCodeNode>(name))
        {
            Arguments = new QueryRootCodeDiscountNodeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCodeDiscountNodeQueryBuilder(IQuery<DiscountCodeNode> query) : base(query)
        {
            Arguments = new QueryRootCodeDiscountNodeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCodeDiscountNodeQueryBuilder SetArguments(Action<QueryRootCodeDiscountNodeArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCodeDiscountNodeQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public QueryRootCodeDiscountNodeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCodeDiscountNodeQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public QueryRootCodeDiscountNodeQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public QueryRootCodeDiscountNodeQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public QueryRootCodeDiscountNodeQueryBuilder CodeDiscount(Action<DiscountCodeUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCode>("codeDiscount");
            var unionBuilder = new DiscountCodeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}