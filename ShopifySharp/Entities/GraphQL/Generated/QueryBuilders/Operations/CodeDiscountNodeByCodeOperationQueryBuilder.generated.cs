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
    public sealed class CodeDiscountNodeByCodeOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeNode, CodeDiscountNodeByCodeOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeNode>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CodeDiscountNodeByCodeArgumentsBuilder Arguments { get; }
        protected override CodeDiscountNodeByCodeOperationQueryBuilder Self => this;

        public CodeDiscountNodeByCodeOperationQueryBuilder() : this("codeDiscountNodeByCode")
        {
        }

        public CodeDiscountNodeByCodeOperationQueryBuilder(string name) : base(new Query<DiscountCodeNode>(name))
        {
            Arguments = new CodeDiscountNodeByCodeArgumentsBuilder(base.InnerQuery);
        }

        public CodeDiscountNodeByCodeOperationQueryBuilder(IQuery<DiscountCodeNode> query) : base(query)
        {
            Arguments = new CodeDiscountNodeByCodeArgumentsBuilder(base.InnerQuery);
        }

        public CodeDiscountNodeByCodeOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public CodeDiscountNodeByCodeOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CodeDiscountNodeByCodeOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public CodeDiscountNodeByCodeOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public CodeDiscountNodeByCodeOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public CodeDiscountNodeByCodeOperationQueryBuilder CodeDiscount(Action<DiscountCodeUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCode>("codeDiscount");
            var unionBuilder = new DiscountCodeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}