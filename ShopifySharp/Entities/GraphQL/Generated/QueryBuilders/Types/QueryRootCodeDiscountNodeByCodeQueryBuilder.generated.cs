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
    public sealed class QueryRootCodeDiscountNodeByCodeQueryBuilder : FieldsQueryBuilderBase<DiscountCodeNode, QueryRootCodeDiscountNodeByCodeQueryBuilder>, IHasArguments<QueryRootCodeDiscountNodeByCodeArgumentsBuilder>
    {
        public QueryRootCodeDiscountNodeByCodeArgumentsBuilder Arguments { get; }
        protected override QueryRootCodeDiscountNodeByCodeQueryBuilder Self => this;

        public QueryRootCodeDiscountNodeByCodeQueryBuilder(string name) : base(new Query<DiscountCodeNode>(name))
        {
            Arguments = new QueryRootCodeDiscountNodeByCodeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCodeDiscountNodeByCodeQueryBuilder(IQuery<DiscountCodeNode> query) : base(query)
        {
            Arguments = new QueryRootCodeDiscountNodeByCodeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCodeDiscountNodeByCodeQueryBuilder SetArguments(Action<QueryRootCodeDiscountNodeByCodeArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCodeDiscountNodeByCodeQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public QueryRootCodeDiscountNodeByCodeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCodeDiscountNodeByCodeQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public QueryRootCodeDiscountNodeByCodeQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public QueryRootCodeDiscountNodeByCodeQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public QueryRootCodeDiscountNodeByCodeQueryBuilder CodeDiscount(Action<DiscountCodeUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCode>("codeDiscount");
            var unionBuilder = new DiscountCodeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}