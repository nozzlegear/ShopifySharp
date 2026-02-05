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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class PublicationOperationQueryBuilder : FieldsQueryBuilderBase<PublicationOperation, PublicationOperationQueryBuilder>
    {
        protected override PublicationOperationQueryBuilder Self => this;

        public PublicationOperationQueryBuilder() : this("publicationOperation")
        {
        }

        public PublicationOperationQueryBuilder(string name) : base(new Query<PublicationOperation>(name))
        {
        }

        public PublicationOperationQueryBuilder(IQuery<PublicationOperation> query) : base(query)
        {
        }

        public PublicationOperationQueryBuilder PublicationOperation(Action<PublicationOperationUnionCasesBuilder> build)
        {
            var query = new Query<PublicationOperation>("publicationOperation");
            var unionBuilder = new PublicationOperationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}