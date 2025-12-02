#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class MetafieldQueryBuilder() : GraphQueryBuilder<Metafield>("metafield")
{
    public MetafieldQueryBuilder AddFieldCompareDigest()
    {
        AddField("compareDigest");
        return this;
    }

    public MetafieldQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public MetafieldQueryBuilder AddFieldDefinition(Func<MetafieldDefinitionQueryBuilder, MetafieldDefinitionQueryBuilder> build)
    {
        AddField<MetafieldDefinition, MetafieldDefinitionQueryBuilder>("definition", build);
        return this;
    }

    [Obsolete("This field will be removed in a future release. Use the `description` on the metafield definition instead. ")]
    public MetafieldQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public MetafieldQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public MetafieldQueryBuilder AddFieldJsonValue()
    {
        AddField("jsonValue");
        return this;
    }

    public MetafieldQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public MetafieldQueryBuilder AddFieldLegacyResourceId()
    {
        AddField("legacyResourceId");
        return this;
    }

    public MetafieldQueryBuilder AddFieldNamespace()
    {
        AddField("namespace");
        return this;
    }

    public MetafieldQueryBuilder AddFieldOwner(Func<HasMetafieldsQueryBuilder, HasMetafieldsQueryBuilder> build)
    {
        AddField<IHasMetafields, HasMetafieldsQueryBuilder>("owner", build);
        return this;
    }

    public MetafieldQueryBuilder AddFieldOwnerType()
    {
        AddField("ownerType");
        return this;
    }

    public MetafieldQueryBuilder AddUnionCaseReference(Func<CollectionQueryBuilder, CollectionQueryBuilder> build)
    {
        AddUnion<Collection, CollectionQueryBuilder>("reference", build);
        return this;
    }

    public MetafieldQueryBuilder AddUnionCaseReference(Func<CompanyQueryBuilder, CompanyQueryBuilder> build)
    {
        AddUnion<Company, CompanyQueryBuilder>("reference", build);
        return this;
    }

    public MetafieldQueryBuilder AddUnionCaseReference(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddUnion<Customer, CustomerQueryBuilder>("reference", build);
        return this;
    }

    public MetafieldQueryBuilder AddUnionCaseReference(Func<GenericFileQueryBuilder, GenericFileQueryBuilder> build)
    {
        AddUnion<GenericFile, GenericFileQueryBuilder>("reference", build);
        return this;
    }

    public MetafieldQueryBuilder AddUnionCaseReference(Func<MediaImageQueryBuilder, MediaImageQueryBuilder> build)
    {
        AddUnion<MediaImage, MediaImageQueryBuilder>("reference", build);
        return this;
    }

    public MetafieldQueryBuilder AddUnionCaseReference(Func<MetaobjectQueryBuilder, MetaobjectQueryBuilder> build)
    {
        AddUnion<Metaobject, MetaobjectQueryBuilder>("reference", build);
        return this;
    }

    public MetafieldQueryBuilder AddUnionCaseReference(Func<Model3dQueryBuilder, Model3dQueryBuilder> build)
    {
        AddUnion<Model3d, Model3dQueryBuilder>("reference", build);
        return this;
    }

    public MetafieldQueryBuilder AddUnionCaseReference(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddUnion<Order, OrderQueryBuilder>("reference", build);
        return this;
    }

    public MetafieldQueryBuilder AddUnionCaseReference(Func<PageQueryBuilder, PageQueryBuilder> build)
    {
        AddUnion<Page, PageQueryBuilder>("reference", build);
        return this;
    }

    public MetafieldQueryBuilder AddUnionCaseReference(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddUnion<Product, ProductQueryBuilder>("reference", build);
        return this;
    }

    public MetafieldQueryBuilder AddUnionCaseReference(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddUnion<ProductVariant, ProductVariantQueryBuilder>("reference", build);
        return this;
    }

    public MetafieldQueryBuilder AddUnionCaseReference(Func<TaxonomyValueQueryBuilder, TaxonomyValueQueryBuilder> build)
    {
        AddUnion<TaxonomyValue, TaxonomyValueQueryBuilder>("reference", build);
        return this;
    }

    public MetafieldQueryBuilder AddUnionCaseReference(Func<VideoQueryBuilder, VideoQueryBuilder> build)
    {
        AddUnion<Video, VideoQueryBuilder>("reference", build);
        return this;
    }

    public MetafieldQueryBuilder AddFieldReferences(Func<MetafieldReferenceConnectionQueryBuilder, MetafieldReferenceConnectionQueryBuilder> build)
    {
        AddField<MetafieldReferenceConnection, MetafieldReferenceConnectionQueryBuilder>("references", build);
        return this;
    }

    public MetafieldQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public MetafieldQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    public MetafieldQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}