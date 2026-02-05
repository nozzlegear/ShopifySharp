#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CodeDiscountNodeOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeNode, CodeDiscountNodeOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeNode>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CodeDiscountNodeArgumentsBuilder Arguments { get; }
        protected override CodeDiscountNodeOperationQueryBuilder Self => this;

        public CodeDiscountNodeOperationQueryBuilder() : this("codeDiscountNode")
        {
        }

        public CodeDiscountNodeOperationQueryBuilder(string name) : base(new Query<DiscountCodeNode>(name))
        {
            Arguments = new CodeDiscountNodeArgumentsBuilder(base.InnerQuery);
        }

        public CodeDiscountNodeOperationQueryBuilder(IQuery<DiscountCodeNode> query) : base(query)
        {
            Arguments = new CodeDiscountNodeArgumentsBuilder(base.InnerQuery);
        }

        public CodeDiscountNodeOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public CodeDiscountNodeOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CodeDiscountNodeOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public CodeDiscountNodeOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public CodeDiscountNodeOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public CodeDiscountNodeOperationQueryBuilder CodeDiscount(Action<DiscountCodeUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCode>("codeDiscount");
            var unionBuilder = new DiscountCodeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}