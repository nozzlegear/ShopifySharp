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
    public sealed class DeliveryPromiseParticipantOwnerUnionCasesBuilder : UnionCasesBuilderBase<DeliveryPromiseParticipantOwner, DeliveryPromiseParticipantOwnerUnionCasesBuilder>
    {
        protected override DeliveryPromiseParticipantOwnerUnionCasesBuilder Self => this;

        public DeliveryPromiseParticipantOwnerUnionCasesBuilder(string fieldName = "deliveryPromiseParticipantOwner") : this(new Query<DeliveryPromiseParticipantOwner>(fieldName))
        {
        }

        public DeliveryPromiseParticipantOwnerUnionCasesBuilder(IQuery<DeliveryPromiseParticipantOwner> query) : base(query)
        {
        }

        public DeliveryPromiseParticipantOwnerUnionCasesBuilder OnProductVariant(Action<ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("... on ProductVariant");
            var queryBuilder = new ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}