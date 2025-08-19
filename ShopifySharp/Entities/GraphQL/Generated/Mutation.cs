#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The schema's entry point for all mutation operations.
/// </summary>
public record Mutation : IGraphQLObject
{
    /// <summary>
    /// Updates the email state value for an abandonment.
    /// </summary>
    [JsonPropertyName("abandonmentEmailStateUpdate")]
    [Obsolete("Use `abandonmentUpdateActivitiesDeliveryStatuses` instead.")]
    public AbandonmentEmailStateUpdatePayload? abandonmentEmailStateUpdate { get; set; } = null;

    /// <summary>
    /// Updates the marketing activities delivery statuses for an abandonment.
    /// </summary>
    [JsonPropertyName("abandonmentUpdateActivitiesDeliveryStatuses")]
    public AbandonmentUpdateActivitiesDeliveryStatusesPayload? abandonmentUpdateActivitiesDeliveryStatuses { get; set; } = null;

    /// <summary>
    /// Charges a shop for features or services one time.
    /// This type of charge is recommended for apps that aren't billed on a recurring basis.
    /// Test and demo shops aren't charged.
    /// </summary>
    [JsonPropertyName("appPurchaseOneTimeCreate")]
    public AppPurchaseOneTimeCreatePayload? appPurchaseOneTimeCreate { get; set; } = null;

    /// <summary>
    /// Revokes access scopes previously granted for an app installation.
    /// </summary>
    [JsonPropertyName("appRevokeAccessScopes")]
    public AppRevokeAccessScopesPayload? appRevokeAccessScopes { get; set; } = null;

    /// <summary>
    /// Cancels an app subscription on a store.
    /// </summary>
    [JsonPropertyName("appSubscriptionCancel")]
    public AppSubscriptionCancelPayload? appSubscriptionCancel { get; set; } = null;

    /// <summary>
    /// Allows an app to charge a store for features or services on a recurring basis.
    /// </summary>
    [JsonPropertyName("appSubscriptionCreate")]
    public AppSubscriptionCreatePayload? appSubscriptionCreate { get; set; } = null;

    /// <summary>
    /// Updates the capped amount on the usage pricing plan of an app subscription line item.
    /// </summary>
    [JsonPropertyName("appSubscriptionLineItemUpdate")]
    public AppSubscriptionLineItemUpdatePayload? appSubscriptionLineItemUpdate { get; set; } = null;

    /// <summary>
    /// Extends the trial of an app subscription.
    /// </summary>
    [JsonPropertyName("appSubscriptionTrialExtend")]
    public AppSubscriptionTrialExtendPayload? appSubscriptionTrialExtend { get; set; } = null;

    /// <summary>
    /// Uninstalls an app.
    /// </summary>
    [JsonPropertyName("appUninstall")]
    public AppUninstallPayload? appUninstall { get; set; } = null;

    /// <summary>
    /// Enables an app to charge a store for features or services on a per-use basis.
    /// The usage charge value is counted towards the `cappedAmount` limit that was
    /// specified in the `appUsagePricingDetails` field when the app subscription was created.
    /// If you create an app usage charge that causes the total usage charges in a
    /// billing interval to exceed the capped amount, then a `Total price exceeds
    /// balance remaining` error is returned.
    /// </summary>
    [JsonPropertyName("appUsageRecordCreate")]
    public AppUsageRecordCreatePayload? appUsageRecordCreate { get; set; } = null;

    /// <summary>
    /// Creates an article.
    /// </summary>
    [JsonPropertyName("articleCreate")]
    public ArticleCreatePayload? articleCreate { get; set; } = null;

    /// <summary>
    /// Deletes an article.
    /// </summary>
    [JsonPropertyName("articleDelete")]
    public ArticleDeletePayload? articleDelete { get; set; } = null;

    /// <summary>
    /// Updates an article.
    /// </summary>
    [JsonPropertyName("articleUpdate")]
    public ArticleUpdatePayload? articleUpdate { get; set; } = null;

    /// <summary>
    /// Update the backup region that is used when we have no better signal of what region a buyer is in.
    /// </summary>
    [JsonPropertyName("backupRegionUpdate")]
    public BackupRegionUpdatePayload? backupRegionUpdate { get; set; } = null;

    /// <summary>
    /// Creates a blog.
    /// </summary>
    [JsonPropertyName("blogCreate")]
    public BlogCreatePayload? blogCreate { get; set; } = null;

    /// <summary>
    /// Deletes a blog.
    /// </summary>
    [JsonPropertyName("blogDelete")]
    public BlogDeletePayload? blogDelete { get; set; } = null;

    /// <summary>
    /// Updates a blog.
    /// </summary>
    [JsonPropertyName("blogUpdate")]
    public BlogUpdatePayload? blogUpdate { get; set; } = null;

    /// <summary>
    /// Starts the cancelation process of a running bulk operation.
    /// There may be a short delay from when a cancelation starts until the operation is actually canceled.
    /// </summary>
    [JsonPropertyName("bulkOperationCancel")]
    public BulkOperationCancelPayload? bulkOperationCancel { get; set; } = null;

    /// <summary>
    /// Creates and runs a bulk operation mutation.
    /// To learn how to bulk import large volumes of data asynchronously, refer to the
    /// [bulk import data guide](https://shopify.dev/api/usage/bulk-operations/imports).
    /// </summary>
    [JsonPropertyName("bulkOperationRunMutation")]
    public BulkOperationRunMutationPayload? bulkOperationRunMutation { get; set; } = null;

    /// <summary>
    /// Creates and runs a bulk operation query.
    /// See the [bulk operations guide](https://shopify.dev/api/usage/bulk-operations/queries) for more details.
    /// </summary>
    [JsonPropertyName("bulkOperationRunQuery")]
    public BulkOperationRunQueryPayload? bulkOperationRunQuery { get; set; } = null;

    /// <summary>
    /// Creates product feedback for multiple products.
    /// </summary>
    [JsonPropertyName("bulkProductResourceFeedbackCreate")]
    public BulkProductResourceFeedbackCreatePayload? bulkProductResourceFeedbackCreate { get; set; } = null;

    /// <summary>
    /// Creates a new carrier service.
    /// </summary>
    [JsonPropertyName("carrierServiceCreate")]
    public CarrierServiceCreatePayload? carrierServiceCreate { get; set; } = null;

    /// <summary>
    /// Removes an existing carrier service.
    /// </summary>
    [JsonPropertyName("carrierServiceDelete")]
    public CarrierServiceDeletePayload? carrierServiceDelete { get; set; } = null;

    /// <summary>
    /// Updates a carrier service. Only the app that creates a carrier service can update it.
    /// </summary>
    [JsonPropertyName("carrierServiceUpdate")]
    public CarrierServiceUpdatePayload? carrierServiceUpdate { get; set; } = null;

    /// <summary>
    /// Create a CartTransform function to the Shop.
    /// </summary>
    [JsonPropertyName("cartTransformCreate")]
    public CartTransformCreatePayload? cartTransformCreate { get; set; } = null;

    /// <summary>
    /// Destroy a cart transform function from the Shop.
    /// </summary>
    [JsonPropertyName("cartTransformDelete")]
    public CartTransformDeletePayload? cartTransformDelete { get; set; } = null;

    /// <summary>
    /// Updates the context of a catalog.
    /// </summary>
    [JsonPropertyName("catalogContextUpdate")]
    public CatalogContextUpdatePayload? catalogContextUpdate { get; set; } = null;

    /// <summary>
    /// Creates a new catalog.
    /// </summary>
    [JsonPropertyName("catalogCreate")]
    public CatalogCreatePayload? catalogCreate { get; set; } = null;

    /// <summary>
    /// Delete a catalog.
    /// </summary>
    [JsonPropertyName("catalogDelete")]
    public CatalogDeletePayload? catalogDelete { get; set; } = null;

    /// <summary>
    /// Updates an existing catalog.
    /// </summary>
    [JsonPropertyName("catalogUpdate")]
    public CatalogUpdatePayload? catalogUpdate { get; set; } = null;

    /// <summary>
    /// Updates the checkout branding settings for a
    /// [checkout profile](https://shopify.dev/api/admin-graphql/unstable/queries/checkoutProfile).
    /// If the settings don't exist, then new settings are created. The checkout branding settings applied to a
    /// published checkout profile will be immediately visible within the store's checkout. The checkout branding
    /// settings applied to a draft checkout profile could be previewed within the admin checkout editor.
    /// To learn more about updating checkout branding settings, refer to the checkout branding
    /// [tutorial](https://shopify.dev/docs/apps/checkout/styling).
    /// </summary>
    [JsonPropertyName("checkoutBrandingUpsert")]
    public CheckoutBrandingUpsertPayload? checkoutBrandingUpsert { get; set; } = null;

    /// <summary>
    /// Adds products to a collection.
    /// </summary>
    [JsonPropertyName("collectionAddProducts")]
    public CollectionAddProductsPayload? collectionAddProducts { get; set; } = null;

    /// <summary>
    /// Asynchronously adds a set of products to a given collection. It can take a
    /// long time to run. Instead of returning a collection, it returns a job which
    /// should be polled.
    /// </summary>
    [JsonPropertyName("collectionAddProductsV2")]
    public CollectionAddProductsV2Payload? collectionAddProductsV2 { get; set; } = null;

    /// <summary>
    /// Creates a [collection](https://shopify.dev/docs/api/admin-graphql/latest/objects/Collection)
    /// to group [products](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) together
    /// in the [online store](https://shopify.dev/docs/apps/build/online-store) and
    /// other [sales channels](https://shopify.dev/docs/apps/build/sales-channels).
    /// For example, an athletics store might create different collections for running attire, shoes, and accessories.
    /// There are two types of collections:
    /// - **[Custom (manual) collections](https://help.shopify.com/manual/products/collections/manual-shopify-collection)**:
    /// You specify the products to include in a collection.
    /// - **[Smart (automated) collections](https://help.shopify.com/manual/products/collections/automated-collections)**:
    /// You define rules, and products matching those rules are automatically
    /// included in the collection.
    /// Use the `collectionCreate` mutation when you need to:
    /// - Create a new collection for a product launch or campaign
    /// - Organize products by category, season, or promotion
    /// - Automate product grouping using rules (for example, by tag, type, or price)
    /// > Note:
    /// > The created collection is unpublished by default. To make it available to customers,
    /// use the [`publishablePublish`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/publishablePublish)
    /// mutation after creation.
    /// Learn more about [using metafields with smart collections](https://shopify.dev/docs/apps/build/custom-data/metafields/use-metafield-capabilities).
    /// </summary>
    [JsonPropertyName("collectionCreate")]
    public CollectionCreatePayload? collectionCreate { get; set; } = null;

    /// <summary>
    /// Deletes a collection.
    /// </summary>
    [JsonPropertyName("collectionDelete")]
    public CollectionDeletePayload? collectionDelete { get; set; } = null;

    /// <summary>
    /// Publishes a collection to a channel.
    /// </summary>
    [JsonPropertyName("collectionPublish")]
    [Obsolete("Use `publishablePublish` instead.")]
    public CollectionPublishPayload? collectionPublish { get; set; } = null;

    /// <summary>
    /// Removes a set of products from a given collection. The mutation can take a
    /// long time to run. Instead of returning an updated collection the mutation
    /// returns a job, which should be
    /// [polled](https://shopify.dev/api/admin-graphql/latest/queries/job). For use
    /// with manual collections only.
    /// </summary>
    [JsonPropertyName("collectionRemoveProducts")]
    public CollectionRemoveProductsPayload? collectionRemoveProducts { get; set; } = null;

    /// <summary>
    /// Asynchronously reorders a set of products within a specified collection.
    /// Instead of returning an updated collection, this mutation returns a job, which
    /// should be [polled](https://shopify.dev/api/admin-graphql/latest/queries/job). The [`Collection.sortOrder`](https://shopify.dev/api/admin-graphql/latest/objects/Collection#field-collection-sortorder)
    /// must be `MANUAL`. Displaced products will have their position altered in a
    /// consistent manner, with no gaps.
    /// </summary>
    [JsonPropertyName("collectionReorderProducts")]
    public CollectionReorderProductsPayload? collectionReorderProducts { get; set; } = null;

    /// <summary>
    /// Unpublishes a collection.
    /// </summary>
    [JsonPropertyName("collectionUnpublish")]
    [Obsolete("Use `publishableUnpublish` instead.")]
    public CollectionUnpublishPayload? collectionUnpublish { get; set; } = null;

    /// <summary>
    /// Updates a [collection](https://shopify.dev/docs/api/admin-graphql/latest/objects/Collection),
    /// modifying its properties, products, or publication settings. Collections help organize
    /// [products](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) together
    /// in the [online store](https://shopify.dev/docs/apps/build/online-store) and
    /// other [sales channels](https://shopify.dev/docs/apps/build/sales-channels).
    /// Use the `collectionUpdate` mutation to programmatically modify collections in scenarios such as:
    /// - Updating collection details, like title, description, or image
    /// - Modifying SEO metadata for better search visibility
    /// - Changing which products are included (using rule updates for smart collections)
    /// - Publishing or unpublishing collections across different sales channels
    /// - Updating custom data using [metafields](https://shopify.dev/docs/apps/build/custom-data/metafields)
    /// There are two types of collections with different update capabilities:
    /// - **[Custom (manual) collections](https://help.shopify.com/manual/products/collections/manual-shopify-collection)**:
    /// You can update collection properties, but rule sets can't be modified since
    /// products are manually selected.
    /// - **[Smart (automated) collections](https://help.shopify.com/manual/products/collections/automated-collections)**:
    /// You can update both collection properties and the rules that automatically
    /// determine which products are included.
    /// When updating [rule sets](https://shopify.dev/docs/api/admin-graphql/latest/objects/CollectionRuleConditions)
    /// for smart collections, the operation might be processed asynchronously. In
    /// these cases, the mutation returns a
    /// [`job`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Job) object
    /// that you can use to track the progress of the update.
    /// To publish or unpublish collections to specific sales channels, use the dedicated
    /// [`publishablePublish`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/publishablePublish) and
    /// [`publishableUnpublish`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/publishableUnpublish) mutations.
    /// Learn more about [using metafields with smart collections](https://shopify.dev/docs/apps/build/custom-data/metafields/use-metafield-capabilities).
    /// </summary>
    [JsonPropertyName("collectionUpdate")]
    public CollectionUpdatePayload? collectionUpdate { get; set; } = null;

    /// <summary>
    /// Add, remove and update `CombinedListing`s of a given Product.
    /// `CombinedListing`s are comprised of multiple products to create a single
    /// listing. There are two kinds of products used in a `CombinedListing`:
    /// 1. Parent products
    /// 2. Child products
    /// The parent product is created with a `productCreate` with a
    /// `CombinedListingRole` of `PARENT`. Once created, you can associate child
    /// products with the parent product using this mutation. Parent products
    /// represent the idea of a product (e.g. Shoe).
    /// Child products represent a particular option value (or combination of option
    /// values) of a parent product. For instance, with your Shoe parent product, you
    /// may have several child products representing specific colors of the shoe (e.g.
    /// Shoe - Blue). You could also have child products representing more than a
    /// single option (e.g. Shoe - Blue/Canvas, Shoe - Blue/Leather, etc...).
    /// The combined listing is the association of parent product to one or more child products.
    /// Learn more about [Combined Listings](https://shopify.dev/apps/selling-strategies/combined-listings).
    /// </summary>
    [JsonPropertyName("combinedListingUpdate")]
    public CombinedListingUpdatePayload? combinedListingUpdate { get; set; } = null;

    /// <summary>
    /// Approves a comment.
    /// </summary>
    [JsonPropertyName("commentApprove")]
    public CommentApprovePayload? commentApprove { get; set; } = null;

    /// <summary>
    /// Deletes a comment.
    /// </summary>
    [JsonPropertyName("commentDelete")]
    public CommentDeletePayload? commentDelete { get; set; } = null;

    /// <summary>
    /// Marks a comment as not spam.
    /// </summary>
    [JsonPropertyName("commentNotSpam")]
    public CommentNotSpamPayload? commentNotSpam { get; set; } = null;

    /// <summary>
    /// Marks a comment as spam.
    /// </summary>
    [JsonPropertyName("commentSpam")]
    public CommentSpamPayload? commentSpam { get; set; } = null;

    /// <summary>
    /// Deletes a list of companies.
    /// </summary>
    [JsonPropertyName("companiesDelete")]
    public CompaniesDeletePayload? companiesDelete { get; set; } = null;

    /// <summary>
    /// Deletes a company address.
    /// </summary>
    [JsonPropertyName("companyAddressDelete")]
    public CompanyAddressDeletePayload? companyAddressDelete { get; set; } = null;

    /// <summary>
    /// Assigns the customer as a company contact.
    /// </summary>
    [JsonPropertyName("companyAssignCustomerAsContact")]
    public CompanyAssignCustomerAsContactPayload? companyAssignCustomerAsContact { get; set; } = null;

    /// <summary>
    /// Assigns the main contact for the company.
    /// </summary>
    [JsonPropertyName("companyAssignMainContact")]
    public CompanyAssignMainContactPayload? companyAssignMainContact { get; set; } = null;

    /// <summary>
    /// Assigns a role to a contact for a location.
    /// </summary>
    [JsonPropertyName("companyContactAssignRole")]
    public CompanyContactAssignRolePayload? companyContactAssignRole { get; set; } = null;

    /// <summary>
    /// Assigns roles on a company contact.
    /// </summary>
    [JsonPropertyName("companyContactAssignRoles")]
    public CompanyContactAssignRolesPayload? companyContactAssignRoles { get; set; } = null;

    /// <summary>
    /// Creates a company contact and the associated customer.
    /// </summary>
    [JsonPropertyName("companyContactCreate")]
    public CompanyContactCreatePayload? companyContactCreate { get; set; } = null;

    /// <summary>
    /// Deletes a company contact.
    /// </summary>
    [JsonPropertyName("companyContactDelete")]
    public CompanyContactDeletePayload? companyContactDelete { get; set; } = null;

    /// <summary>
    /// Removes a company contact from a Company.
    /// </summary>
    [JsonPropertyName("companyContactRemoveFromCompany")]
    public CompanyContactRemoveFromCompanyPayload? companyContactRemoveFromCompany { get; set; } = null;

    /// <summary>
    /// Revokes a role on a company contact.
    /// </summary>
    [JsonPropertyName("companyContactRevokeRole")]
    public CompanyContactRevokeRolePayload? companyContactRevokeRole { get; set; } = null;

    /// <summary>
    /// Revokes roles on a company contact.
    /// </summary>
    [JsonPropertyName("companyContactRevokeRoles")]
    public CompanyContactRevokeRolesPayload? companyContactRevokeRoles { get; set; } = null;

    /// <summary>
    /// Deletes one or more company contacts.
    /// </summary>
    [JsonPropertyName("companyContactsDelete")]
    public CompanyContactsDeletePayload? companyContactsDelete { get; set; } = null;

    /// <summary>
    /// Sends the company contact a welcome email.
    /// </summary>
    [JsonPropertyName("companyContactSendWelcomeEmail")]
    public CompanyContactSendWelcomeEmailPayload? companyContactSendWelcomeEmail { get; set; } = null;

    /// <summary>
    /// Updates a company contact.
    /// </summary>
    [JsonPropertyName("companyContactUpdate")]
    public CompanyContactUpdatePayload? companyContactUpdate { get; set; } = null;

    /// <summary>
    /// Creates a company.
    /// </summary>
    [JsonPropertyName("companyCreate")]
    public CompanyCreatePayload? companyCreate { get; set; } = null;

    /// <summary>
    /// Deletes a company.
    /// </summary>
    [JsonPropertyName("companyDelete")]
    public CompanyDeletePayload? companyDelete { get; set; } = null;

    /// <summary>
    /// Updates an address on a company location.
    /// </summary>
    [JsonPropertyName("companyLocationAssignAddress")]
    public CompanyLocationAssignAddressPayload? companyLocationAssignAddress { get; set; } = null;

    /// <summary>
    /// Assigns roles on a company location.
    /// </summary>
    [JsonPropertyName("companyLocationAssignRoles")]
    public CompanyLocationAssignRolesPayload? companyLocationAssignRoles { get; set; } = null;

    /// <summary>
    /// Creates one or more mappings between a staff member at a shop and a company location.
    /// </summary>
    [JsonPropertyName("companyLocationAssignStaffMembers")]
    public CompanyLocationAssignStaffMembersPayload? companyLocationAssignStaffMembers { get; set; } = null;

    /// <summary>
    /// Assigns tax exemptions to the company location.
    /// </summary>
    [JsonPropertyName("companyLocationAssignTaxExemptions")]
    [Obsolete("Use `companyLocationTaxSettingsUpdate` instead.")]
    public CompanyLocationAssignTaxExemptionsPayload? companyLocationAssignTaxExemptions { get; set; } = null;

    /// <summary>
    /// Creates a company location.
    /// </summary>
    [JsonPropertyName("companyLocationCreate")]
    public CompanyLocationCreatePayload? companyLocationCreate { get; set; } = null;

    /// <summary>
    /// Creates a tax registration for a company location.
    /// </summary>
    [JsonPropertyName("companyLocationCreateTaxRegistration")]
    [Obsolete("Use `companyLocationTaxSettingsUpdate` instead.")]
    public CompanyLocationCreateTaxRegistrationPayload? companyLocationCreateTaxRegistration { get; set; } = null;

    /// <summary>
    /// Deletes a company location.
    /// </summary>
    [JsonPropertyName("companyLocationDelete")]
    public CompanyLocationDeletePayload? companyLocationDelete { get; set; } = null;

    /// <summary>
    /// Deletes one or more existing mappings between a staff member at a shop and a company location.
    /// </summary>
    [JsonPropertyName("companyLocationRemoveStaffMembers")]
    public CompanyLocationRemoveStaffMembersPayload? companyLocationRemoveStaffMembers { get; set; } = null;

    /// <summary>
    /// Revokes roles on a company location.
    /// </summary>
    [JsonPropertyName("companyLocationRevokeRoles")]
    public CompanyLocationRevokeRolesPayload? companyLocationRevokeRoles { get; set; } = null;

    /// <summary>
    /// Revokes tax exemptions from the company location.
    /// </summary>
    [JsonPropertyName("companyLocationRevokeTaxExemptions")]
    [Obsolete("Use `companyLocationTaxSettingsUpdate` instead.")]
    public CompanyLocationRevokeTaxExemptionsPayload? companyLocationRevokeTaxExemptions { get; set; } = null;

    /// <summary>
    /// Revokes tax registration on a company location.
    /// </summary>
    [JsonPropertyName("companyLocationRevokeTaxRegistration")]
    [Obsolete("Use `companyLocationTaxSettingsUpdate` instead.")]
    public CompanyLocationRevokeTaxRegistrationPayload? companyLocationRevokeTaxRegistration { get; set; } = null;

    /// <summary>
    /// Deletes a list of company locations.
    /// </summary>
    [JsonPropertyName("companyLocationsDelete")]
    public CompanyLocationsDeletePayload? companyLocationsDelete { get; set; } = null;

    /// <summary>
    /// Sets the tax settings for a company location.
    /// </summary>
    [JsonPropertyName("companyLocationTaxSettingsUpdate")]
    public CompanyLocationTaxSettingsUpdatePayload? companyLocationTaxSettingsUpdate { get; set; } = null;

    /// <summary>
    /// Updates a company location.
    /// </summary>
    [JsonPropertyName("companyLocationUpdate")]
    public CompanyLocationUpdatePayload? companyLocationUpdate { get; set; } = null;

    /// <summary>
    /// Revokes the main contact from the company.
    /// </summary>
    [JsonPropertyName("companyRevokeMainContact")]
    public CompanyRevokeMainContactPayload? companyRevokeMainContact { get; set; } = null;

    /// <summary>
    /// Updates a company.
    /// </summary>
    [JsonPropertyName("companyUpdate")]
    public CompanyUpdatePayload? companyUpdate { get; set; } = null;

    /// <summary>
    /// Update or create consent policies in bulk.
    /// </summary>
    [JsonPropertyName("consentPolicyUpdate")]
    public ConsentPolicyUpdatePayload? consentPolicyUpdate { get; set; } = null;

    /// <summary>
    /// Create a new customer address.
    /// </summary>
    [JsonPropertyName("customerAddressCreate")]
    public CustomerAddressCreatePayload? customerAddressCreate { get; set; } = null;

    /// <summary>
    /// Deletes a customer's address.
    /// </summary>
    [JsonPropertyName("customerAddressDelete")]
    public CustomerAddressDeletePayload? customerAddressDelete { get; set; } = null;

    /// <summary>
    /// Update a customer's address information.
    /// </summary>
    [JsonPropertyName("customerAddressUpdate")]
    public CustomerAddressUpdatePayload? customerAddressUpdate { get; set; } = null;

    /// <summary>
    /// Add tax exemptions for the customer.
    /// </summary>
    [JsonPropertyName("customerAddTaxExemptions")]
    public CustomerAddTaxExemptionsPayload? customerAddTaxExemptions { get; set; } = null;

    /// <summary>
    /// Cancels a pending erasure of a customer's data. Read more [here](https://help.shopify.com/manual/privacy-and-security/privacy/processing-customer-data-requests#cancel-customer-data-erasure).
    /// To request an erasure of a customer's data use the [customerRequestDataErasure mutation](https://shopify.dev/api/admin-graphql/unstable/mutations/customerRequestDataErasure).
    /// </summary>
    [JsonPropertyName("customerCancelDataErasure")]
    public CustomerCancelDataErasurePayload? customerCancelDataErasure { get; set; } = null;

    /// <summary>
    /// Create a new customer. As of API version 2022-10, apps using protected
    /// customer data must meet the protected customer data [requirements](https://shopify.dev/apps/store/data-protection/protected-customer-data).
    /// </summary>
    [JsonPropertyName("customerCreate")]
    public CustomerCreatePayload? customerCreate { get; set; } = null;

    /// <summary>
    /// Delete a customer. As of API version 2022-10, apps using protected customer
    /// data must meet the protected customer data [requirements](https://shopify.dev/apps/store/data-protection/protected-customer-data).
    /// </summary>
    [JsonPropertyName("customerDelete")]
    public CustomerDeletePayload? customerDelete { get; set; } = null;

    /// <summary>
    /// Update a customer's email marketing information information.
    /// </summary>
    [JsonPropertyName("customerEmailMarketingConsentUpdate")]
    public CustomerEmailMarketingConsentUpdatePayload? customerEmailMarketingConsentUpdate { get; set; } = null;

    /// <summary>
    /// Generate an account activation URL for a customer.
    /// </summary>
    [JsonPropertyName("customerGenerateAccountActivationUrl")]
    public CustomerGenerateAccountActivationUrlPayload? customerGenerateAccountActivationUrl { get; set; } = null;

    /// <summary>
    /// Merges two customers.
    /// </summary>
    [JsonPropertyName("customerMerge")]
    public CustomerMergePayload? customerMerge { get; set; } = null;

    /// <summary>
    /// Creates a vaulted payment method for a customer from duplication data.
    /// This data must be obtained from another shop within the same organization.
    /// Currently, this only supports Shop Pay payment methods. This is only available for selected partner apps.
    /// </summary>
    [JsonPropertyName("customerPaymentMethodCreateFromDuplicationData")]
    public CustomerPaymentMethodCreateFromDuplicationDataPayload? customerPaymentMethodCreateFromDuplicationData { get; set; } = null;

    /// <summary>
    /// Creates a credit card payment method for a customer using a session id.
    /// These values are only obtained through card imports happening from a PCI compliant environment.
    /// Please use customerPaymentMethodRemoteCreate if you are not managing credit cards directly.
    /// </summary>
    [JsonPropertyName("customerPaymentMethodCreditCardCreate")]
    public CustomerPaymentMethodCreditCardCreatePayload? customerPaymentMethodCreditCardCreate { get; set; } = null;

    /// <summary>
    /// Updates the credit card payment method for a customer.
    /// </summary>
    [JsonPropertyName("customerPaymentMethodCreditCardUpdate")]
    public CustomerPaymentMethodCreditCardUpdatePayload? customerPaymentMethodCreditCardUpdate { get; set; } = null;

    /// <summary>
    /// Returns encrypted data that can be used to duplicate the payment method in another shop within the same organization.
    /// Currently, this only supports Shop Pay payment methods. This is only available for selected partner apps.
    /// </summary>
    [JsonPropertyName("customerPaymentMethodGetDuplicationData")]
    public CustomerPaymentMethodGetDuplicationDataPayload? customerPaymentMethodGetDuplicationData { get; set; } = null;

    /// <summary>
    /// Returns a URL that allows the customer to update a specific payment method.
    /// Currently, `customerPaymentMethodGetUpdateUrl` only supports Shop Pay.
    /// </summary>
    [JsonPropertyName("customerPaymentMethodGetUpdateUrl")]
    public CustomerPaymentMethodGetUpdateUrlPayload? customerPaymentMethodGetUpdateUrl { get; set; } = null;

    /// <summary>
    /// Creates a PayPal billing agreement for a customer.
    /// </summary>
    [JsonPropertyName("customerPaymentMethodPaypalBillingAgreementCreate")]
    public CustomerPaymentMethodPaypalBillingAgreementCreatePayload? customerPaymentMethodPaypalBillingAgreementCreate { get; set; } = null;

    /// <summary>
    /// Updates a PayPal billing agreement for a customer.
    /// </summary>
    [JsonPropertyName("customerPaymentMethodPaypalBillingAgreementUpdate")]
    public CustomerPaymentMethodPaypalBillingAgreementUpdatePayload? customerPaymentMethodPaypalBillingAgreementUpdate { get; set; } = null;

    /// <summary>
    /// Create a payment method from remote gateway identifiers. NOTE: This operation
    /// processes payment methods asynchronously. The returned payment method will
    /// initially have incomplete details. Developers must poll this payment method
    /// using customerPaymentMethod query until all payment method details are
    /// available, or the payment method is revoked (usually within seconds).
    /// </summary>
    [JsonPropertyName("customerPaymentMethodRemoteCreate")]
    public CustomerPaymentMethodRemoteCreatePayload? customerPaymentMethodRemoteCreate { get; set; } = null;

    /// <summary>
    /// Revokes a customer's payment method.
    /// </summary>
    [JsonPropertyName("customerPaymentMethodRevoke")]
    public CustomerPaymentMethodRevokePayload? customerPaymentMethodRevoke { get; set; } = null;

    /// <summary>
    /// Sends a link to the customer so they can update a specific payment method.
    /// </summary>
    [JsonPropertyName("customerPaymentMethodSendUpdateEmail")]
    public CustomerPaymentMethodSendUpdateEmailPayload? customerPaymentMethodSendUpdateEmail { get; set; } = null;

    /// <summary>
    /// Remove tax exemptions from a customer.
    /// </summary>
    [JsonPropertyName("customerRemoveTaxExemptions")]
    public CustomerRemoveTaxExemptionsPayload? customerRemoveTaxExemptions { get; set; } = null;

    /// <summary>
    /// Replace tax exemptions for a customer.
    /// </summary>
    [JsonPropertyName("customerReplaceTaxExemptions")]
    public CustomerReplaceTaxExemptionsPayload? customerReplaceTaxExemptions { get; set; } = null;

    /// <summary>
    /// Enqueues a request to erase customer's data. Read more [here](https://help.shopify.com/manual/privacy-and-security/privacy/processing-customer-data-requests#erase-customer-personal-data).
    /// To cancel the data erasure request use the [customerCancelDataErasure mutation](https://shopify.dev/api/admin-graphql/unstable/mutations/customerCancelDataErasure).
    /// </summary>
    [JsonPropertyName("customerRequestDataErasure")]
    public CustomerRequestDataErasurePayload? customerRequestDataErasure { get; set; } = null;

    /// <summary>
    /// Creates a customer segment members query.
    /// </summary>
    [JsonPropertyName("customerSegmentMembersQueryCreate")]
    public CustomerSegmentMembersQueryCreatePayload? customerSegmentMembersQueryCreate { get; set; } = null;

    /// <summary>
    /// Sends the customer an account invite email.
    /// </summary>
    [JsonPropertyName("customerSendAccountInviteEmail")]
    public CustomerSendAccountInviteEmailPayload? customerSendAccountInviteEmail { get; set; } = null;

    /// <summary>
    /// Creates or updates a customer in a single mutation.
    /// Use this mutation when syncing information from an external data source into Shopify.
    /// This mutation can be used to create a new customer, update an existing customer by id, or
    /// upsert a customer by a unique key (email or phone).
    /// To create a new customer omit the `identifier` argument.
    /// To update an existing customer, include the `identifier` with the id of the customer to update.
    /// To perform an 'upsert' by unique key (email or phone)
    /// use the `identifier` argument to upsert a customer by a unique key (email or phone). If a customer
    /// with the specified unique key exists, it will be updated. If not, a new customer will be created with
    /// that unique key.
    /// As of API version 2022-10, apps using protected customer data must meet the
    /// protected customer data [requirements](https://shopify.dev/apps/store/data-protection/protected-customer-data)
    /// Any list field (e.g.
    /// [addresses](https://shopify.dev/api/admin-graphql/unstable/input-objects/MailingAddressInput),
    /// will be updated so that all included entries are either created or updated, and all existing entries not
    /// included will be deleted.
    /// All other fields will be updated to the value passed. Omitted fields will not be updated.
    /// </summary>
    [JsonPropertyName("customerSet")]
    public CustomerSetPayload? customerSet { get; set; } = null;

    /// <summary>
    /// Update a customer's SMS marketing consent information.
    /// </summary>
    [JsonPropertyName("customerSmsMarketingConsentUpdate")]
    public CustomerSmsMarketingConsentUpdatePayload? customerSmsMarketingConsentUpdate { get; set; } = null;

    /// <summary>
    /// Update a customer's attributes. As of API version 2022-10, apps using
    /// protected customer data must meet the protected customer data [requirements](https://shopify.dev/apps/store/data-protection/protected-customer-data).
    /// </summary>
    [JsonPropertyName("customerUpdate")]
    public CustomerUpdatePayload? customerUpdate { get; set; } = null;

    /// <summary>
    /// Updates a customer's default address.
    /// </summary>
    [JsonPropertyName("customerUpdateDefaultAddress")]
    public CustomerUpdateDefaultAddressPayload? customerUpdateDefaultAddress { get; set; } = null;

    /// <summary>
    /// Opt out a customer from data sale.
    /// </summary>
    [JsonPropertyName("dataSaleOptOut")]
    public DataSaleOptOutPayload? dataSaleOptOut { get; set; } = null;

    /// <summary>
    /// Creates a delegate access token.
    /// To learn more about creating delegate access tokens, refer to
    /// [Delegate OAuth access tokens to subsystems](https://shopify.dev/docs/apps/build/authentication-authorization/access-tokens/use-delegate-tokens).
    /// </summary>
    [JsonPropertyName("delegateAccessTokenCreate")]
    public DelegateAccessTokenCreatePayload? delegateAccessTokenCreate { get; set; } = null;

    /// <summary>
    /// Destroys a delegate access token.
    /// </summary>
    [JsonPropertyName("delegateAccessTokenDestroy")]
    public DelegateAccessTokenDestroyPayload? delegateAccessTokenDestroy { get; set; } = null;

    /// <summary>
    /// Activates and deactivates delivery customizations.
    /// </summary>
    [JsonPropertyName("deliveryCustomizationActivation")]
    public DeliveryCustomizationActivationPayload? deliveryCustomizationActivation { get; set; } = null;

    /// <summary>
    /// Creates a delivery customization.
    /// </summary>
    [JsonPropertyName("deliveryCustomizationCreate")]
    public DeliveryCustomizationCreatePayload? deliveryCustomizationCreate { get; set; } = null;

    /// <summary>
    /// Creates a delivery customization.
    /// </summary>
    [JsonPropertyName("deliveryCustomizationDelete")]
    public DeliveryCustomizationDeletePayload? deliveryCustomizationDelete { get; set; } = null;

    /// <summary>
    /// Updates a delivery customization.
    /// </summary>
    [JsonPropertyName("deliveryCustomizationUpdate")]
    public DeliveryCustomizationUpdatePayload? deliveryCustomizationUpdate { get; set; } = null;

    /// <summary>
    /// Create a delivery profile.
    /// </summary>
    [JsonPropertyName("deliveryProfileCreate")]
    public DeliveryProfileCreatePayload? deliveryProfileCreate { get; set; } = null;

    /// <summary>
    /// Enqueue the removal of a delivery profile.
    /// </summary>
    [JsonPropertyName("deliveryProfileRemove")]
    public DeliveryProfileRemovePayload? deliveryProfileRemove { get; set; } = null;

    /// <summary>
    /// Update a delivery profile.
    /// </summary>
    [JsonPropertyName("deliveryProfileUpdate")]
    public DeliveryProfileUpdatePayload? deliveryProfileUpdate { get; set; } = null;

    /// <summary>
    /// Updates the delivery promise participants by adding or removing owners based on a branded promise handle.
    /// </summary>
    [JsonPropertyName("deliveryPromiseParticipantsUpdate")]
    public DeliveryPromiseParticipantsUpdatePayload? deliveryPromiseParticipantsUpdate { get; set; } = null;

    /// <summary>
    /// Creates or updates a delivery promise provider. Currently restricted to select approved delivery promise partners.
    /// </summary>
    [JsonPropertyName("deliveryPromiseProviderUpsert")]
    public DeliveryPromiseProviderUpsertPayload? deliveryPromiseProviderUpsert { get; set; } = null;

    /// <summary>
    /// Set the delivery settings for a shop.
    /// </summary>
    [JsonPropertyName("deliverySettingUpdate")]
    public DeliverySettingUpdatePayload? deliverySettingUpdate { get; set; } = null;

    /// <summary>
    /// Assigns a location as the shipping origin while using legacy compatibility mode for multi-location delivery profiles.
    /// </summary>
    [JsonPropertyName("deliveryShippingOriginAssign")]
    public DeliveryShippingOriginAssignPayload? deliveryShippingOriginAssign { get; set; } = null;

    /// <summary>
    /// Activates an automatic discount.
    /// </summary>
    [JsonPropertyName("discountAutomaticActivate")]
    public DiscountAutomaticActivatePayload? discountAutomaticActivate { get; set; } = null;

    /// <summary>
    /// Creates an automatic discount that's managed by an app.
    /// Use this mutation with [Shopify Functions](https://shopify.dev/docs/apps/build/functions)
    /// when you need advanced, custom, or dynamic discount capabilities that aren't supported by
    /// [Shopify's native discount types](https://help.shopify.com/manual/discounts/discount-types).
    /// For example, use this mutation to create an automatic discount using an app's
    /// "Volume" discount type that applies a percentage
    /// off when customers purchase more than the minimum quantity of a product. For an example implementation,
    /// refer to [our tutorial](https://shopify.dev/docs/apps/build/discounts/build-discount-function).
    /// > Note:
    /// > To create code discounts with custom logic, use the
    /// [`discountCodeAppCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountCodeAppCreate)
    /// mutation.
    /// </summary>
    [JsonPropertyName("discountAutomaticAppCreate")]
    public DiscountAutomaticAppCreatePayload? discountAutomaticAppCreate { get; set; } = null;

    /// <summary>
    /// Updates an existing automatic discount that's managed by an app using
    /// [Shopify Functions](https://shopify.dev/docs/apps/build/functions).
    /// Use this mutation when you need advanced, custom, or
    /// dynamic discount capabilities that aren't supported by
    /// [Shopify's native discount types](https://help.shopify.com/manual/discounts/discount-types).
    /// For example, use this mutation to update a new "Volume" discount type that applies a percentage
    /// off when customers purchase more than the minimum quantity of a product. For an example implementation,
    /// refer to [our tutorial](https://shopify.dev/docs/apps/build/discounts/build-discount-function).
    /// > Note:
    /// > To update code discounts with custom logic, use the
    /// [`discountCodeAppUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountCodeAppUpdate)
    /// mutation instead.
    /// </summary>
    [JsonPropertyName("discountAutomaticAppUpdate")]
    public DiscountAutomaticAppUpdatePayload? discountAutomaticAppUpdate { get; set; } = null;

    /// <summary>
    /// Creates an
    /// [amount off discount](https://help.shopify.com/manual/discounts/discount-types/percentage-fixed-amount)
    /// that's automatically applied on a cart and at checkout.
    /// > Note:
    /// > To create code discounts, use the
    /// [`discountCodeBasicCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountCodeBasicCreate)
    /// mutation.
    /// </summary>
    [JsonPropertyName("discountAutomaticBasicCreate")]
    public DiscountAutomaticBasicCreatePayload? discountAutomaticBasicCreate { get; set; } = null;

    /// <summary>
    /// Updates an existing
    /// [amount off discount](https://help.shopify.com/manual/discounts/discount-types/percentage-fixed-amount)
    /// that's automatically applied on a cart and at checkout.
    /// > Note:
    /// > To update code discounts, use the
    /// [`discountCodeBasicUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountCodeBasicUpdate)
    /// mutation instead.
    /// </summary>
    [JsonPropertyName("discountAutomaticBasicUpdate")]
    public DiscountAutomaticBasicUpdatePayload? discountAutomaticBasicUpdate { get; set; } = null;

    /// <summary>
    /// Asynchronously delete automatic discounts in bulk if a `search` or `saved_search_id` argument is provided or if a
    /// maximum discount threshold is reached (1,000). Otherwise, deletions will occur inline.
    /// **Warning:** All automatic discounts will be deleted if a blank `search` argument is provided.
    /// </summary>
    [JsonPropertyName("discountAutomaticBulkDelete")]
    public DiscountAutomaticBulkDeletePayload? discountAutomaticBulkDelete { get; set; } = null;

    /// <summary>
    /// Creates a
    /// [buy X get Y discount (BXGY)](https://help.shopify.com/manual/discounts/discount-types/buy-x-get-y)
    /// that's automatically applied on a cart and at checkout.
    /// > Note:
    /// > To create code discounts, use the
    /// [`discountCodeBxgyCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountCodeBxgyCreate)
    /// mutation.
    /// </summary>
    [JsonPropertyName("discountAutomaticBxgyCreate")]
    public DiscountAutomaticBxgyCreatePayload? discountAutomaticBxgyCreate { get; set; } = null;

    /// <summary>
    /// Updates an existing
    /// [buy X get Y discount (BXGY)](https://help.shopify.com/manual/discounts/discount-types/buy-x-get-y)
    /// that's automatically applied on a cart and at checkout.
    /// > Note:
    /// > To update code discounts, use the
    /// [`discountCodeBxgyUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountCodeBxgyUpdate)
    /// mutation instead.
    /// </summary>
    [JsonPropertyName("discountAutomaticBxgyUpdate")]
    public DiscountAutomaticBxgyUpdatePayload? discountAutomaticBxgyUpdate { get; set; } = null;

    /// <summary>
    /// Deactivates an automatic discount.
    /// </summary>
    [JsonPropertyName("discountAutomaticDeactivate")]
    public DiscountAutomaticDeactivatePayload? discountAutomaticDeactivate { get; set; } = null;

    /// <summary>
    /// Deletes an
    /// [automatic discount](https://help.shopify.com/manual/discounts/discount-types#automatic-discounts).
    /// </summary>
    [JsonPropertyName("discountAutomaticDelete")]
    public DiscountAutomaticDeletePayload? discountAutomaticDelete { get; set; } = null;

    /// <summary>
    /// Creates a
    /// [free shipping discount](https://help.shopify.com/manual/discounts/discount-types/free-shipping)
    /// that's automatically applied on a cart and at checkout.
    /// > Note:
    /// > To create code discounts, use the
    /// [`discountCodeFreeShippingCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountCodeFreeShippingCreate)
    /// mutation.
    /// </summary>
    [JsonPropertyName("discountAutomaticFreeShippingCreate")]
    public DiscountAutomaticFreeShippingCreatePayload? discountAutomaticFreeShippingCreate { get; set; } = null;

    /// <summary>
    /// Updates an existing
    /// [free shipping discount](https://help.shopify.com/manual/discounts/discount-types/free-shipping)
    /// that's automatically applied on a cart and at checkout.
    /// > Note:
    /// > To update code discounts, use the
    /// [`discountCodeFreeShippingUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountCodeFreeShippingUpdate)
    /// mutation instead.
    /// </summary>
    [JsonPropertyName("discountAutomaticFreeShippingUpdate")]
    public DiscountAutomaticFreeShippingUpdatePayload? discountAutomaticFreeShippingUpdate { get; set; } = null;

    /// <summary>
    /// Activates a code discount.
    /// </summary>
    [JsonPropertyName("discountCodeActivate")]
    public DiscountCodeActivatePayload? discountCodeActivate { get; set; } = null;

    /// <summary>
    /// Creates a code discount. The discount type must be provided by an app
    /// extension that uses [Shopify
    /// Functions](https://shopify.dev/docs/apps/build/functions). Functions can implement
    /// [order](https://shopify.dev/docs/api/functions/reference/order-discounts),
    /// [product](https://shopify.dev/docs/api/functions/reference/product-discounts), or [shipping](https://shopify.dev/docs/api/functions/reference/shipping-discounts)
    /// discount functions. Use this mutation with Shopify Functions when you need
    /// custom logic beyond [Shopify's native discount
    /// types](https://help.shopify.com/manual/discounts/discount-types).
    /// For example, use this mutation to create a code discount using an app's
    /// "Volume" discount type that applies a percentage off when customers purchase
    /// more than the minimum quantity
    /// of a product. For an example implementation, refer to [our tutorial](https://shopify.dev/docs/apps/build/discounts/build-discount-function).
    /// > Note:
    /// > To create automatic discounts with custom logic, use [`discountAutomaticAppCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountAutomaticAppCreate).
    /// </summary>
    [JsonPropertyName("discountCodeAppCreate")]
    public DiscountCodeAppCreatePayload? discountCodeAppCreate { get; set; } = null;

    /// <summary>
    /// Updates a code discount, where the discount type is provided by an app
    /// extension that uses [Shopify
    /// Functions](https://shopify.dev/docs/apps/build/functions). Use this mutation
    /// when you need advanced, custom, or dynamic discount capabilities that aren't
    /// supported by [Shopify's native discount
    /// types](https://help.shopify.com/manual/discounts/discount-types).
    /// > Note:
    /// > To update automatic discounts, use [`discountAutomaticAppUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountAutomaticAppUpdate).
    /// </summary>
    [JsonPropertyName("discountCodeAppUpdate")]
    public DiscountCodeAppUpdatePayload? discountCodeAppUpdate { get; set; } = null;

    /// <summary>
    /// Creates an [amount off discount](https://help.shopify.com/manual/discounts/discount-types/percentage-fixed-amount)
    /// that's applied on a cart and at checkout when a customer enters a code. Amount
    /// off discounts can be a percentage off or a fixed amount off.
    /// > Note:
    /// > To create discounts that are automatically applied on a cart and at
    /// checkout, use the [`discountAutomaticBasicCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountAutomaticBasicCreate) mutation.
    /// </summary>
    [JsonPropertyName("discountCodeBasicCreate")]
    public DiscountCodeBasicCreatePayload? discountCodeBasicCreate { get; set; } = null;

    /// <summary>
    /// Updates an [amount off discount](https://help.shopify.com/manual/discounts/discount-types/percentage-fixed-amount)
    /// that's applied on a cart and at checkout when a customer enters a code. Amount
    /// off discounts can be a percentage off or a fixed amount off.
    /// > Note:
    /// > To update discounts that are automatically applied on a cart and at
    /// checkout, use the [`discountAutomaticBasicUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountAutomaticBasicUpdate) mutation.
    /// </summary>
    [JsonPropertyName("discountCodeBasicUpdate")]
    public DiscountCodeBasicUpdatePayload? discountCodeBasicUpdate { get; set; } = null;

    /// <summary>
    /// Activates multiple [code discounts](https://help.shopify.com/manual/discounts/discount-types#discount-codes)
    /// asynchronously using one of the following:
    /// - A search query
    /// - A saved search ID
    /// - A list of discount code IDs
    /// For example, you can activate discounts for all codes that match a search
    /// criteria, or activate a predefined set of discount codes.
    /// </summary>
    [JsonPropertyName("discountCodeBulkActivate")]
    public DiscountCodeBulkActivatePayload? discountCodeBulkActivate { get; set; } = null;

    /// <summary>
    /// Deactivates multiple [code-based discounts](https://help.shopify.com/manual/discounts/discount-types#discount-codes)
    /// asynchronously using one of the following:
    /// - A search query
    /// - A saved search ID
    /// - A list of discount code IDs
    /// For example, you can deactivate discounts for all codes that match a search
    /// criteria, or deactivate a predefined set of discount codes.
    /// </summary>
    [JsonPropertyName("discountCodeBulkDeactivate")]
    public DiscountCodeBulkDeactivatePayload? discountCodeBulkDeactivate { get; set; } = null;

    /// <summary>
    /// Deletes multiple [code-based discounts](https://help.shopify.com/manual/discounts/discount-types#discount-codes)
    /// asynchronously using one of the following:
    /// - A search query
    /// - A saved search ID
    /// - A list of discount code IDs
    /// For example, you can delete discounts for all codes that match a search
    /// criteria, or delete a predefined set of discount codes.
    /// </summary>
    [JsonPropertyName("discountCodeBulkDelete")]
    public DiscountCodeBulkDeletePayload? discountCodeBulkDelete { get; set; } = null;

    /// <summary>
    /// Creates a
    /// [buy X get Y discount (BXGY)](https://help.shopify.com/manual/discounts/discount-types/buy-x-get-y)
    /// that's applied on a cart and at checkout when a customer enters a code.
    /// > Note:
    /// > To create discounts that are automatically applied on a cart and at checkout, use the
    /// [`discountAutomaticBxgyCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountAutomaticBxgyCreate)
    /// mutation.
    /// </summary>
    [JsonPropertyName("discountCodeBxgyCreate")]
    public DiscountCodeBxgyCreatePayload? discountCodeBxgyCreate { get; set; } = null;

    /// <summary>
    /// Updates a
    /// [buy X get Y discount (BXGY)](https://help.shopify.com/manual/discounts/discount-types/buy-x-get-y)
    /// that's applied on a cart and at checkout when a customer enters a code.
    /// > Note:
    /// > To update discounts that are automatically applied on a cart and at checkout, use the
    /// [`discountAutomaticBxgyUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountAutomaticBxgyUpdate)
    /// mutation.
    /// </summary>
    [JsonPropertyName("discountCodeBxgyUpdate")]
    public DiscountCodeBxgyUpdatePayload? discountCodeBxgyUpdate { get; set; } = null;

    /// <summary>
    /// Deactivates a code discount.
    /// </summary>
    [JsonPropertyName("discountCodeDeactivate")]
    public DiscountCodeDeactivatePayload? discountCodeDeactivate { get; set; } = null;

    /// <summary>
    /// Deletes a
    /// [code discount](https://help.shopify.com/manual/discounts/discount-types#discount-codes).
    /// </summary>
    [JsonPropertyName("discountCodeDelete")]
    public DiscountCodeDeletePayload? discountCodeDelete { get; set; } = null;

    /// <summary>
    /// Creates an [free shipping discount](https://help.shopify.com/manual/discounts/discount-types/free-shipping)
    /// that's applied on a cart and at checkout when a customer enters a code.
    /// > Note:
    /// > To create discounts that are automatically applied on a cart and at
    /// checkout, use the [`discountAutomaticFreeShippingCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountAutomaticFreeShippingCreate) mutation.
    /// </summary>
    [JsonPropertyName("discountCodeFreeShippingCreate")]
    public DiscountCodeFreeShippingCreatePayload? discountCodeFreeShippingCreate { get; set; } = null;

    /// <summary>
    /// Updates a [free shipping discount](https://help.shopify.com/manual/discounts/discount-types/free-shipping)
    /// that's applied on a cart and at checkout when a customer enters a code.
    /// > Note:
    /// > To update a free shipping discount that's automatically applied on a cart
    /// and at checkout, use the [`discountAutomaticFreeShippingUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/discountAutomaticFreeShippingUpdate) mutation.
    /// </summary>
    [JsonPropertyName("discountCodeFreeShippingUpdate")]
    public DiscountCodeFreeShippingUpdatePayload? discountCodeFreeShippingUpdate { get; set; } = null;

    /// <summary>
    /// Asynchronously delete
    /// [discount codes](https://help.shopify.com/manual/discounts/discount-types#discount-codes)
    /// in bulk that customers can use to redeem a discount.
    /// </summary>
    [JsonPropertyName("discountCodeRedeemCodeBulkDelete")]
    public DiscountCodeRedeemCodeBulkDeletePayload? discountCodeRedeemCodeBulkDelete { get; set; } = null;

    /// <summary>
    /// Asynchronously add
    /// [discount codes](https://help.shopify.com/manual/discounts/discount-types#discount-codes)
    /// in bulk that customers can use to redeem a discount. You can use the `discountRedeemCodeBulkAdd` mutation
    /// to automate the distribution of discount codes through emails or other
    /// marketing channels.
    /// </summary>
    [JsonPropertyName("discountRedeemCodeBulkAdd")]
    public DiscountRedeemCodeBulkAddPayload? discountRedeemCodeBulkAdd { get; set; } = null;

    /// <summary>
    /// Updates a dispute evidence.
    /// </summary>
    [JsonPropertyName("disputeEvidenceUpdate")]
    public DisputeEvidenceUpdatePayload? disputeEvidenceUpdate { get; set; } = null;

    /// <summary>
    /// Adds tags to multiple draft orders.
    /// </summary>
    [JsonPropertyName("draftOrderBulkAddTags")]
    public DraftOrderBulkAddTagsPayload? draftOrderBulkAddTags { get; set; } = null;

    /// <summary>
    /// Deletes multiple draft orders.
    /// </summary>
    [JsonPropertyName("draftOrderBulkDelete")]
    public DraftOrderBulkDeletePayload? draftOrderBulkDelete { get; set; } = null;

    /// <summary>
    /// Removes tags from multiple draft orders.
    /// </summary>
    [JsonPropertyName("draftOrderBulkRemoveTags")]
    public DraftOrderBulkRemoveTagsPayload? draftOrderBulkRemoveTags { get; set; } = null;

    /// <summary>
    /// Calculates the properties of a draft order. Useful for determining information
    /// such as total taxes or price without actually creating a draft order.
    /// </summary>
    [JsonPropertyName("draftOrderCalculate")]
    public DraftOrderCalculatePayload? draftOrderCalculate { get; set; } = null;

    /// <summary>
    /// Completes a [draft order](https://shopify.dev/docs/api/admin-graphql/latest/objects/DraftOrder) and
    /// converts it into a [regular order](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order).
    /// The order appears in the merchant's orders list, and the customer can be notified about their order.
    /// Use the `draftOrderComplete` mutation when a merchant is ready to finalize a draft order and create a real
    /// order in their store. The `draftOrderComplete` mutation also supports sales channel attribution for tracking
    /// order sources using the [`sourceName`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/draftOrderComplete#arguments-sourceName)
    /// argument, [cart validation](https://shopify.dev/docs/apps/build/checkout/cart-checkout-validation)
    /// controls for app integrations, and detailed error reporting for failed completions.
    /// You can complete a draft order with different [payment scenarios](https://help.shopify.com/manual/fulfillment/managing-orders/payments):
    /// - Mark the order as paid immediately.
    /// - Set the order as payment pending using [payment terms](https://shopify.dev/docs/api/admin-graphql/latest/objects/PaymentTerms).
    /// - Specify a custom payment amount.
    /// - Select a specific payment gateway.
    /// > Note:
    /// > When completing a draft order, inventory is [reserved](https://shopify.dev/docs/apps/build/orders-fulfillment/inventory-management-apps#inventory-states)
    /// for the items in the order. This means the items will no longer be available for other customers to purchase.
    /// Make sure to verify inventory availability before completing the draft order.
    /// </summary>
    [JsonPropertyName("draftOrderComplete")]
    public DraftOrderCompletePayload? draftOrderComplete { get; set; } = null;

    /// <summary>
    /// Creates a [draft order](https://shopify.dev/docs/api/admin-graphql/latest/objects/DraftOrder)
    /// with attributes such as customer information, line items, shipping and billing addresses, and payment terms.
    /// Draft orders are useful for merchants that need to:
    /// - Create new orders for sales made by phone, in person, by chat, or elsewhere.
    /// When a merchant accepts payment for a draft order, an order is created.
    /// - Send invoices to customers with a secure checkout link.
    /// - Use custom items to represent additional costs or products not in inventory.
    /// - Re-create orders manually from active sales channels.
    /// - Sell products at discount or wholesale rates.
    /// - Take pre-orders.
    /// After creating a draft order, you can:
    /// - Send an invoice to the customer using the [`draftOrderInvoiceSend`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/draftOrderInvoiceSend) mutation.
    /// - Complete the draft order using the [`draftOrderComplete`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/draftOrderComplete) mutation.
    /// - Update the draft order using the [`draftOrderUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/draftOrderUpdate) mutation.
    /// - Duplicate a draft order using the [`draftOrderDuplicate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/draftOrderDuplicate) mutation.
    /// - Delete the draft order using the [`draftOrderDelete`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/draftOrderDelete) mutation.
    /// > Note:
    /// > When you create a draft order, you can't [reserve or hold inventory](https://shopify.dev/docs/apps/build/orders-fulfillment/inventory-management-apps#inventory-states)
    /// for the items in the order by default.
    /// > However, you can reserve inventory using the [`reserveInventoryUntil`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/draftOrderCreate#arguments-input.fields.reserveInventoryUntil) input.
    /// </summary>
    [JsonPropertyName("draftOrderCreate")]
    public DraftOrderCreatePayload? draftOrderCreate { get; set; } = null;

    /// <summary>
    /// Creates a draft order from order.
    /// </summary>
    [JsonPropertyName("draftOrderCreateFromOrder")]
    public DraftOrderCreateFromOrderPayload? draftOrderCreateFromOrder { get; set; } = null;

    /// <summary>
    /// Deletes a draft order.
    /// </summary>
    [JsonPropertyName("draftOrderDelete")]
    public DraftOrderDeletePayload? draftOrderDelete { get; set; } = null;

    /// <summary>
    /// Duplicates a draft order.
    /// </summary>
    [JsonPropertyName("draftOrderDuplicate")]
    public DraftOrderDuplicatePayload? draftOrderDuplicate { get; set; } = null;

    /// <summary>
    /// Previews a draft order invoice email.
    /// </summary>
    [JsonPropertyName("draftOrderInvoicePreview")]
    public DraftOrderInvoicePreviewPayload? draftOrderInvoicePreview { get; set; } = null;

    /// <summary>
    /// Sends an email invoice for a draft order.
    /// </summary>
    [JsonPropertyName("draftOrderInvoiceSend")]
    public DraftOrderInvoiceSendPayload? draftOrderInvoiceSend { get; set; } = null;

    /// <summary>
    /// Updates a draft order.
    /// If a checkout has been started for a draft order, any update to the draft will unlink the checkout. Checkouts
    /// are created but not immediately completed when opening the merchant credit card modal in the admin, and when a
    /// buyer opens the invoice URL. This is usually fine, but there is an edge case where a checkout is in progress
    /// and the draft is updated before the checkout completes. This will not interfere with the checkout and order
    /// creation, but if the link from draft to checkout is broken the draft will remain open even after the order is
    /// created.
    /// </summary>
    [JsonPropertyName("draftOrderUpdate")]
    public DraftOrderUpdatePayload? draftOrderUpdate { get; set; } = null;

    /// <summary>
    /// Updates the server pixel to connect to an EventBridge endpoint.
    /// Running this mutation deletes any previous subscriptions for the server pixel.
    /// </summary>
    [JsonPropertyName("eventBridgeServerPixelUpdate")]
    public EventBridgeServerPixelUpdatePayload? eventBridgeServerPixelUpdate { get; set; } = null;

    /// <summary>
    /// Creates a new Amazon EventBridge webhook subscription.
    /// Building an app? If you only use app-specific webhooks, you won't need this.
    /// App-specific webhook subscriptions specified in your `shopify.app.toml` may be
    /// easier. They are automatically kept up to date by Shopify & require less
    /// maintenance. Please read [About managing webhook
    /// subscriptions](https://shopify.dev/docs/apps/build/webhooks/subscribe).
    /// </summary>
    [JsonPropertyName("eventBridgeWebhookSubscriptionCreate")]
    [Obsolete("Use `webhookSubscriptionCreate` instead.")]
    public EventBridgeWebhookSubscriptionCreatePayload? eventBridgeWebhookSubscriptionCreate { get; set; } = null;

    /// <summary>
    /// Updates an Amazon EventBridge webhook subscription.
    /// Building an app? If you only use app-specific webhooks, you won't need this.
    /// App-specific webhook subscriptions specified in your `shopify.app.toml` may be
    /// easier. They are automatically kept up to date by Shopify & require less
    /// maintenance. Please read [About managing webhook
    /// subscriptions](https://shopify.dev/docs/apps/build/webhooks/subscribe).
    /// </summary>
    [JsonPropertyName("eventBridgeWebhookSubscriptionUpdate")]
    [Obsolete("Use `webhookSubscriptionUpdate` instead.")]
    public EventBridgeWebhookSubscriptionUpdatePayload? eventBridgeWebhookSubscriptionUpdate { get; set; } = null;

    /// <summary>
    /// Acknowledges file update failure by resetting FAILED status to READY and clearing any media errors.
    /// </summary>
    [JsonPropertyName("fileAcknowledgeUpdateFailed")]
    public FileAcknowledgeUpdateFailedPayload? fileAcknowledgeUpdateFailed { get; set; } = null;

    /// <summary>
    /// Creates file assets for a store from external URLs or files that were previously uploaded using the
    /// [`stagedUploadsCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/stageduploadscreate)
    /// mutation.
    /// Use the `fileCreate` mutation to add various types of media and documents to your store. These files are added to the
    /// [**Files** page](https://shopify.com/admin/settings/files) in the Shopify admin and can be referenced by other
    /// resources in your store.
    /// The `fileCreate` mutation supports multiple file types:
    /// - **Images**: Product photos, variant images, and general store imagery
    /// - **Videos**: Shopify-hosted videos for product demonstrations and marketing
    /// - **External videos**: YouTube and Vimeo videos for enhanced product experiences
    /// - **3D models**: Interactive 3D representations of products
    /// - **Generic files**: PDFs, documents, and other file types for store resources
    /// The mutation handles duplicate filenames using configurable resolution modes that automatically append UUIDs,
    /// replace existing files, or raise errors when conflicts occur.
    /// > Note:
    /// > Files are processed asynchronously. Check the
    /// > [`fileStatus`](https://shopify.dev/docs/api/admin-graphql/latest/interfaces/File#fields-fileStatus)
    /// > field to monitor processing completion. The maximum number of files that can be created in a single batch is 250.
    /// After creating files, you can make subsequent updates using the following mutations:
    /// - [`fileUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/fileUpdate):
    /// Update file properties such as alt text or replace file contents while preserving the same URL.
    /// - [`fileDelete`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/fileDelete):
    /// Remove files from your store when they are no longer needed.
    /// To list all files in your store, use the
    /// [`files`](https://shopify.dev/docs/api/admin-graphql/latest/queries/files) query.
    /// Learn how to manage
    /// [product media and file assets](https://shopify.dev/docs/apps/build/online-store/product-media)
    /// in your app.
    /// </summary>
    [JsonPropertyName("fileCreate")]
    public FileCreatePayload? fileCreate { get; set; } = null;

    /// <summary>
    /// Deletes file assets that were previously uploaded to your store.
    /// Use the `fileDelete` mutation to permanently remove media and file assets from your store when they are no longer needed.
    /// This mutation handles the complete removal of files from both your store's file library and any associated references
    /// to products or other resources.
    /// The `fileDelete` mutation supports removal of multiple file types:
    /// - **Images**: Product photos, variant images, and general store imagery
    /// - **Videos**: Shopify-hosted videos for product demonstrations and marketing content
    /// - **External Videos**: YouTube and Vimeo videos linked to your products
    /// - **3D models**: Interactive 3D representations of products
    /// - **Generic files**: PDFs, documents, and other file types stored in your
    /// [**Files** page](https://shopify.com/admin/settings/files)
    /// When you delete files that are referenced by products, the mutation automatically removes those references and
    /// reorders any remaining media to maintain proper positioning. Product file references are database relationships
    /// managed through a media reference system, not just links in product descriptions. The Shopify admin provides a UI
    /// to manage these relationships, and when files are deleted, the system automatically cleans up all references.
    /// Files that are currently being processed by other operations are rejected to prevent conflicts.
    /// > Caution:
    /// > File deletion is permanent and can't be undone. When you delete a file that's being used in your store,
    /// > it will immediately stop appearing wherever it was displayed. For example, if you delete a product image,
    /// > that product will show a broken image or placeholder on your storefront and in the admin. The same applies
    /// > to any other files linked from themes, blog posts, or pages. Before deleting files, you can use the
    /// > [`files` query](https://shopify.dev/api/admin-graphql/latest/queries/files) to list and review
    /// > your store's file assets.
    /// Learn how to manage
    /// [product media and file assets](https://shopify.dev/docs/apps/build/online-store/product-media)
    /// in your app.
    /// </summary>
    [JsonPropertyName("fileDelete")]
    public FileDeletePayload? fileDelete { get; set; } = null;

    /// <summary>
    /// Updates properties, content, and metadata associated with an existing file
    /// asset that has already been uploaded to Shopify.
    /// Use the `fileUpdate` mutation to modify various aspects of files already stored in your store.
    /// Files can be updated individually or in batches.
    /// The `fileUpdate` mutation supports updating multiple file properties:
    /// - **Alt text**: Update accessibility descriptions for images and other media.
    /// - **File content**: Replace image or generic file content while maintaining the same URL.
    /// - **Filename**: Modify file names (extension must match the original).
    /// - **Product references**: Add or remove associations between files and products. Removing file-product associations
    /// deletes the file from the product's media gallery and clears the image from any product variants that were using it.
    /// The mutation handles different file types with specific capabilities:
    /// - **Images**: Update preview images, original source, filename, and alt text.
    /// - **Generic files**: Update original source, filename, and alt text.
    /// - **Videos and 3D models**: Update alt text and product references.
    /// > Note:
    /// > Files must be in `ready` state before they can be updated. The mutation includes file locking to prevent
    /// > conflicts during updates. You can't simultaneously update both `originalSource` and `previewImageSource`.
    /// After updating files, you can use related mutations for additional file management:
    /// - [`fileCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/fileCreate):
    /// Create new file assets from external URLs or staged uploads.
    /// - [`fileDelete`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/fileDelete):
    /// Remove files from your store when they are no longer needed.
    /// Learn how to manage
    /// [product media and file assets](https://shopify.dev/docs/apps/build/online-store/product-media)
    /// in your app.
    /// </summary>
    [JsonPropertyName("fileUpdate")]
    public FileUpdatePayload? fileUpdate { get; set; } = null;

    /// <summary>
    /// Generates a signature for a Flow action payload.
    /// </summary>
    [JsonPropertyName("flowGenerateSignature")]
    public FlowGenerateSignaturePayload? flowGenerateSignature { get; set; } = null;

    /// <summary>
    /// Triggers any workflows that begin with the trigger specified in the request
    /// body. To learn more, refer to [_Create Shopify Flow
    /// triggers_](https://shopify.dev/apps/flow/triggers).
    /// </summary>
    [JsonPropertyName("flowTriggerReceive")]
    public FlowTriggerReceivePayload? flowTriggerReceive { get; set; } = null;

    /// <summary>
    /// Cancels a fulfillment.
    /// </summary>
    [JsonPropertyName("fulfillmentCancel")]
    public FulfillmentCancelPayload? fulfillmentCancel { get; set; } = null;

    /// <summary>
    /// Creates a fulfillment constraint rule and its metafield.
    /// </summary>
    [JsonPropertyName("fulfillmentConstraintRuleCreate")]
    public FulfillmentConstraintRuleCreatePayload? fulfillmentConstraintRuleCreate { get; set; } = null;

    /// <summary>
    /// Deletes a fulfillment constraint rule and its metafields.
    /// </summary>
    [JsonPropertyName("fulfillmentConstraintRuleDelete")]
    public FulfillmentConstraintRuleDeletePayload? fulfillmentConstraintRuleDelete { get; set; } = null;

    /// <summary>
    /// Update a fulfillment constraint rule.
    /// </summary>
    [JsonPropertyName("fulfillmentConstraintRuleUpdate")]
    public FulfillmentConstraintRuleUpdatePayload? fulfillmentConstraintRuleUpdate { get; set; } = null;

    /// <summary>
    /// Creates a fulfillment for one or many fulfillment orders.
    /// The fulfillment orders are associated with the same order and are assigned to the same location.
    /// </summary>
    [JsonPropertyName("fulfillmentCreate")]
    public FulfillmentCreatePayload? fulfillmentCreate { get; set; } = null;

    /// <summary>
    /// Creates a fulfillment for one or many fulfillment orders.
    /// The fulfillment orders are associated with the same order and are assigned to the same location.
    /// </summary>
    [JsonPropertyName("fulfillmentCreateV2")]
    [Obsolete("Use `fulfillmentCreate` instead.")]
    public FulfillmentCreateV2Payload? fulfillmentCreateV2 { get; set; } = null;

    /// <summary>
    /// Creates a fulfillment event for a specified fulfillment.
    /// </summary>
    [JsonPropertyName("fulfillmentEventCreate")]
    public FulfillmentEventCreatePayload? fulfillmentEventCreate { get; set; } = null;

    /// <summary>
    /// Accept a cancellation request sent to a fulfillment service for a fulfillment order.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderAcceptCancellationRequest")]
    public FulfillmentOrderAcceptCancellationRequestPayload? fulfillmentOrderAcceptCancellationRequest { get; set; } = null;

    /// <summary>
    /// Accepts a fulfillment request sent to a fulfillment service for a fulfillment order.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderAcceptFulfillmentRequest")]
    public FulfillmentOrderAcceptFulfillmentRequestPayload? fulfillmentOrderAcceptFulfillmentRequest { get; set; } = null;

    /// <summary>
    /// Marks a fulfillment order as canceled.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderCancel")]
    public FulfillmentOrderCancelPayload? fulfillmentOrderCancel { get; set; } = null;

    /// <summary>
    /// Marks an in-progress fulfillment order as incomplete,
    /// indicating the fulfillment service is unable to ship any remaining items,
    /// and closes the fulfillment request.
    /// This mutation can only be called for fulfillment orders that meet the following criteria:
    ///   - Assigned to a fulfillment service location,
    ///   - The fulfillment request has been accepted,
    ///   - The fulfillment order status is `IN_PROGRESS`.
    /// This mutation can only be called by the fulfillment service app that accepted the fulfillment request.
    /// Calling this mutation returns the control of the fulfillment order to the merchant, allowing them to
    /// move the fulfillment order line items to another location and fulfill from there,
    /// remove and refund the line items, or to request fulfillment from the same fulfillment service again.
    /// Closing a fulfillment order is explained in
    /// [the fulfillment service guide](https://shopify.dev/apps/build/orders-fulfillment/fulfillment-service-apps/build-for-fulfillment-services#step-7-optional-close-a-fulfillment-order).
    /// </summary>
    [JsonPropertyName("fulfillmentOrderClose")]
    public FulfillmentOrderClosePayload? fulfillmentOrderClose { get; set; } = null;

    /// <summary>
    /// Applies a fulfillment hold on a fulfillment order.
    /// As of the
    /// [2025-01 API version](https://shopify.dev/changelog/apply-multiple-holds-to-a-single-fulfillment-order),
    /// the mutation can be successfully executed on fulfillment orders that are already on hold.
    /// To place multiple holds on a fulfillment order, apps need to supply the
    /// [handle](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentHold#field-handle)
    /// field. Each app can place up to
    /// 10 active holds
    /// per fulfillment order. If an app attempts to place more than this, the mutation will return
    /// [a user error indicating that the limit has been reached](https://shopify.dev/api/admin-graphql/latest/enums/FulfillmentOrderHoldUserErrorCode#value-fulfillmentorderholdlimitreached).
    /// The app would need to release one of its existing holds before being able to apply a new one.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderHold")]
    public FulfillmentOrderHoldPayload? fulfillmentOrderHold { get; set; } = null;

    /// <summary>
    /// Mark line items associated with a fulfillment order as being ready for pickup by a customer.
    /// Sends a Ready For Pickup notification to the customer to let them know that their order is ready
    /// to be picked up.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderLineItemsPreparedForPickup")]
    public FulfillmentOrderLineItemsPreparedForPickupPayload? fulfillmentOrderLineItemsPreparedForPickup { get; set; } = null;

    /// <summary>
    /// Merges a set or multiple sets of fulfillment orders together into one based on
    /// line item inputs and quantities.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderMerge")]
    public FulfillmentOrderMergePayload? fulfillmentOrderMerge { get; set; } = null;

    /// <summary>
    /// Changes the location which is assigned to fulfill a number of unfulfilled fulfillment order line items.
    /// Moving a fulfillment order will fail in the following circumstances:
    /// * The fulfillment order is closed.
    /// * The destination location doesn't stock the requested inventory item.
    /// * The API client doesn't have the correct permissions.
    /// Line items which have already been fulfilled can't be re-assigned
    /// and will always remain assigned to the original location.
    /// You can't change the assigned location while a fulfillment order has a
    /// [request status](https://shopify.dev/docs/api/admin-graphql/latest/enums/FulfillmentOrderRequestStatus)
    /// of `SUBMITTED`, `ACCEPTED`, `CANCELLATION_REQUESTED`, or `CANCELLATION_REJECTED`.
    /// These request statuses mean that a fulfillment order is awaiting action by a fulfillment service
    /// and can't be re-assigned without first having the fulfillment service accept a cancellation request.
    /// This behavior is intended to prevent items from being fulfilled by multiple locations or fulfillment services.
    /// ### How re-assigning line items affects fulfillment orders
    /// **First scenario:** Re-assign all line items belonging to a fulfillment order to a new location.
    /// In this case, the
    /// [assignedLocation](https://shopify.dev/docs/api/admin-graphql/latest/objects/fulfillmentorder#field-fulfillmentorder-assignedlocation)
    /// of the original fulfillment order will be updated to the new location.
    /// **Second scenario:** Re-assign a subset of the line items belonging to a fulfillment order to a new location.
    /// You can specify a subset of line items using the `fulfillmentOrderLineItems` parameter
    /// (available as of the `2023-04` API version),
    /// or specify that the original fulfillment order contains line items which have already been fulfilled.
    /// If the new location is already assigned to another active fulfillment order, on the same order, then
    /// a new fulfillment order is created. The existing fulfillment order is closed and line items are recreated
    /// in a new fulfillment order.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderMove")]
    public FulfillmentOrderMovePayload? fulfillmentOrderMove { get; set; } = null;

    /// <summary>
    /// Marks a scheduled fulfillment order as open.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderOpen")]
    public FulfillmentOrderOpenPayload? fulfillmentOrderOpen { get; set; } = null;

    /// <summary>
    /// Rejects a cancellation request sent to a fulfillment service for a fulfillment order.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderRejectCancellationRequest")]
    public FulfillmentOrderRejectCancellationRequestPayload? fulfillmentOrderRejectCancellationRequest { get; set; } = null;

    /// <summary>
    /// Rejects a fulfillment request sent to a fulfillment service for a fulfillment order.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderRejectFulfillmentRequest")]
    public FulfillmentOrderRejectFulfillmentRequestPayload? fulfillmentOrderRejectFulfillmentRequest { get; set; } = null;

    /// <summary>
    /// Releases the fulfillment hold on a fulfillment order.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderReleaseHold")]
    public FulfillmentOrderReleaseHoldPayload? fulfillmentOrderReleaseHold { get; set; } = null;

    /// <summary>
    /// Reschedules a scheduled fulfillment order.
    /// Updates the value of the `fulfillAt` field on a scheduled fulfillment order.
    /// The fulfillment order will be marked as ready for fulfillment at this date and time.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderReschedule")]
    public FulfillmentOrderReschedulePayload? fulfillmentOrderReschedule { get; set; } = null;

    /// <summary>
    /// Splits a fulfillment order or orders based on line item inputs and quantities.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderSplit")]
    public FulfillmentOrderSplitPayload? fulfillmentOrderSplit { get; set; } = null;

    /// <summary>
    /// Sets the latest date and time by which the fulfillment orders need to be fulfilled.
    /// </summary>
    [JsonPropertyName("fulfillmentOrdersSetFulfillmentDeadline")]
    public FulfillmentOrdersSetFulfillmentDeadlinePayload? fulfillmentOrdersSetFulfillmentDeadline { get; set; } = null;

    /// <summary>
    /// Sends a cancellation request to the fulfillment service of a fulfillment order.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderSubmitCancellationRequest")]
    public FulfillmentOrderSubmitCancellationRequestPayload? fulfillmentOrderSubmitCancellationRequest { get; set; } = null;

    /// <summary>
    /// Sends a fulfillment request to the fulfillment service of a fulfillment order.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderSubmitFulfillmentRequest")]
    public FulfillmentOrderSubmitFulfillmentRequestPayload? fulfillmentOrderSubmitFulfillmentRequest { get; set; } = null;

    /// <summary>
    /// Creates a fulfillment service.
    /// ## Fulfillment service location
    /// When creating a fulfillment service, a new location will be automatically created on the shop
    /// and will be associated with this fulfillment service.
    /// This location will be named after the fulfillment service and inherit the shop's address.
    /// If you are using API version `2023-10` or later, and you need to specify
    /// custom attributes for the fulfillment service location
    /// (for example, to change its address to a country different from the shop's country),
    /// use the
    /// [LocationEdit](https://shopify.dev/api/admin-graphql/latest/mutations/locationEdit)
    /// mutation after creating the fulfillment service.
    /// </summary>
    [JsonPropertyName("fulfillmentServiceCreate")]
    public FulfillmentServiceCreatePayload? fulfillmentServiceCreate { get; set; } = null;

    /// <summary>
    /// Deletes a fulfillment service.
    /// </summary>
    [JsonPropertyName("fulfillmentServiceDelete")]
    public FulfillmentServiceDeletePayload? fulfillmentServiceDelete { get; set; } = null;

    /// <summary>
    /// Updates a fulfillment service.
    /// If you are using API version `2023-10` or later,
    /// and you need to update the location managed by the fulfillment service
    /// (for example, to change the address of a fulfillment service),
    /// use the
    /// [LocationEdit](https://shopify.dev/api/admin-graphql/latest/mutations/locationEdit)
    /// mutation.
    /// </summary>
    [JsonPropertyName("fulfillmentServiceUpdate")]
    public FulfillmentServiceUpdatePayload? fulfillmentServiceUpdate { get; set; } = null;

    /// <summary>
    /// Updates tracking information for a fulfillment.
    /// </summary>
    [JsonPropertyName("fulfillmentTrackingInfoUpdate")]
    public FulfillmentTrackingInfoUpdatePayload? fulfillmentTrackingInfoUpdate { get; set; } = null;

    /// <summary>
    /// Updates tracking information for a fulfillment.
    /// </summary>
    [JsonPropertyName("fulfillmentTrackingInfoUpdateV2")]
    [Obsolete("Use `fulfillmentTrackingInfoUpdate` instead.")]
    public FulfillmentTrackingInfoUpdateV2Payload? fulfillmentTrackingInfoUpdateV2 { get; set; } = null;

    /// <summary>
    /// Create a gift card.
    /// </summary>
    [JsonPropertyName("giftCardCreate")]
    public GiftCardCreatePayload? giftCardCreate { get; set; } = null;

    /// <summary>
    /// Credit a gift card.
    /// </summary>
    [JsonPropertyName("giftCardCredit")]
    public GiftCardCreditPayload? giftCardCredit { get; set; } = null;

    /// <summary>
    /// Deactivate a gift card. A deactivated gift card cannot be used by a customer.
    /// A deactivated gift card cannot be re-enabled.
    /// </summary>
    [JsonPropertyName("giftCardDeactivate")]
    public GiftCardDeactivatePayload? giftCardDeactivate { get; set; } = null;

    /// <summary>
    /// Debit a gift card.
    /// </summary>
    [JsonPropertyName("giftCardDebit")]
    public GiftCardDebitPayload? giftCardDebit { get; set; } = null;

    /// <summary>
    /// Send notification to the customer of a gift card.
    /// </summary>
    [JsonPropertyName("giftCardSendNotificationToCustomer")]
    public GiftCardSendNotificationToCustomerPayload? giftCardSendNotificationToCustomer { get; set; } = null;

    /// <summary>
    /// Send notification to the recipient of a gift card.
    /// </summary>
    [JsonPropertyName("giftCardSendNotificationToRecipient")]
    public GiftCardSendNotificationToRecipientPayload? giftCardSendNotificationToRecipient { get; set; } = null;

    /// <summary>
    /// Update a gift card.
    /// </summary>
    [JsonPropertyName("giftCardUpdate")]
    public GiftCardUpdatePayload? giftCardUpdate { get; set; } = null;

    /// <summary>
    /// Activate an inventory item at a location.
    /// </summary>
    [JsonPropertyName("inventoryActivate")]
    public InventoryActivatePayload? inventoryActivate { get; set; } = null;

    /// <summary>
    /// Apply changes to inventory quantities.
    /// </summary>
    [JsonPropertyName("inventoryAdjustQuantities")]
    public InventoryAdjustQuantitiesPayload? inventoryAdjustQuantities { get; set; } = null;

    /// <summary>
    /// Modify the activation status of an inventory item at locations. Activating an
    /// inventory item at a particular location allows that location to stock that
    /// inventory item. Deactivating an inventory item at a location removes the
    /// inventory item's quantities and turns off the inventory item from that location.
    /// </summary>
    [JsonPropertyName("inventoryBulkToggleActivation")]
    public InventoryBulkToggleActivationPayload? inventoryBulkToggleActivation { get; set; } = null;

    /// <summary>
    /// Removes an inventory item's quantities from a location, and turns off inventory at the location.
    /// </summary>
    [JsonPropertyName("inventoryDeactivate")]
    public InventoryDeactivatePayload? inventoryDeactivate { get; set; } = null;

    /// <summary>
    /// Updates an inventory item.
    /// </summary>
    [JsonPropertyName("inventoryItemUpdate")]
    public InventoryItemUpdatePayload? inventoryItemUpdate { get; set; } = null;

    /// <summary>
    /// Moves inventory between inventory quantity names at a single location.
    /// </summary>
    [JsonPropertyName("inventoryMoveQuantities")]
    public InventoryMoveQuantitiesPayload? inventoryMoveQuantities { get; set; } = null;

    /// <summary>
    /// Set inventory on-hand quantities using absolute values.
    /// </summary>
    [JsonPropertyName("inventorySetOnHandQuantities")]
    [Obsolete("Use `inventorySetQuantities` to set on_hand or available quantites instead.")]
    public InventorySetOnHandQuantitiesPayload? inventorySetOnHandQuantities { get; set; } = null;

    /// <summary>
    /// Set quantities of specified name using absolute values. This mutation supports compare-and-set functionality to handle
    /// concurrent requests properly. If `ignoreCompareQuantity` is not set to true,
    /// the mutation will only update the quantity if the persisted quantity matches the `compareQuantity` value.
    /// If the `compareQuantity` value does not match the persisted value, the mutation will return an error. In order to opt out
    /// of the `compareQuantity` check, the `ignoreCompareQuantity` argument can be set to true.
    /// > Note:
    /// > Only use this mutation if calling on behalf of a system that acts as the source of truth for inventory quantities,
    /// > otherwise please consider using the [inventoryAdjustQuantities](https://shopify.dev/api/admin-graphql/latest/mutations/inventoryAdjustQuantities) mutation.
    /// >
    /// >
    /// > Opting out of the `compareQuantity` check can lead to inaccurate inventory
    /// quantities if multiple requests are made concurrently.
    /// > It is recommended to always include the `compareQuantity` value to ensure
    /// the accuracy of the inventory quantities and to opt out
    /// > of the check using `ignoreCompareQuantity` only when necessary.
    /// </summary>
    [JsonPropertyName("inventorySetQuantities")]
    public InventorySetQuantitiesPayload? inventorySetQuantities { get; set; } = null;

    /// <summary>
    /// Set up scheduled changes of inventory items.
    /// </summary>
    [JsonPropertyName("inventorySetScheduledChanges")]
    public InventorySetScheduledChangesPayload? inventorySetScheduledChanges { get; set; } = null;

    /// <summary>
    /// Adds items to an inventory shipment.
    /// </summary>
    [JsonPropertyName("inventoryShipmentAddItems")]
    public InventoryShipmentAddItemsPayload? inventoryShipmentAddItems { get; set; } = null;

    /// <summary>
    /// Adds a draft shipment to an inventory transfer.
    /// </summary>
    [JsonPropertyName("inventoryShipmentCreate")]
    public InventoryShipmentCreatePayload? inventoryShipmentCreate { get; set; } = null;

    /// <summary>
    /// Adds an in-transit shipment to an inventory transfer.
    /// </summary>
    [JsonPropertyName("inventoryShipmentCreateInTransit")]
    public InventoryShipmentCreateInTransitPayload? inventoryShipmentCreateInTransit { get; set; } = null;

    /// <summary>
    /// Deletes an inventory shipment. Only draft shipments can be deleted.
    /// </summary>
    [JsonPropertyName("inventoryShipmentDelete")]
    public InventoryShipmentDeletePayload? inventoryShipmentDelete { get; set; } = null;

    /// <summary>
    /// Marks a draft inventory shipment as in transit.
    /// </summary>
    [JsonPropertyName("inventoryShipmentMarkInTransit")]
    public InventoryShipmentMarkInTransitPayload? inventoryShipmentMarkInTransit { get; set; } = null;

    /// <summary>
    /// Receive an inventory shipment.
    /// </summary>
    [JsonPropertyName("inventoryShipmentReceive")]
    public InventoryShipmentReceivePayload? inventoryShipmentReceive { get; set; } = null;

    /// <summary>
    /// Remove items from an inventory shipment.
    /// </summary>
    [JsonPropertyName("inventoryShipmentRemoveItems")]
    public InventoryShipmentRemoveItemsPayload? inventoryShipmentRemoveItems { get; set; } = null;

    /// <summary>
    /// Edits the tracking info on an inventory shipment.
    /// </summary>
    [JsonPropertyName("inventoryShipmentSetTracking")]
    public InventoryShipmentSetTrackingPayload? inventoryShipmentSetTracking { get; set; } = null;

    /// <summary>
    /// Updates items on an inventory shipment.
    /// </summary>
    [JsonPropertyName("inventoryShipmentUpdateItemQuantities")]
    public InventoryShipmentUpdateItemQuantitiesPayload? inventoryShipmentUpdateItemQuantities { get; set; } = null;

    /// <summary>
    /// Cancels an inventory transfer.
    /// </summary>
    [JsonPropertyName("inventoryTransferCancel")]
    public InventoryTransferCancelPayload? inventoryTransferCancel { get; set; } = null;

    /// <summary>
    /// Creates an inventory transfer.
    /// </summary>
    [JsonPropertyName("inventoryTransferCreate")]
    public InventoryTransferCreatePayload? inventoryTransferCreate { get; set; } = null;

    /// <summary>
    /// Creates an inventory transfer in ready to ship.
    /// </summary>
    [JsonPropertyName("inventoryTransferCreateAsReadyToShip")]
    public InventoryTransferCreateAsReadyToShipPayload? inventoryTransferCreateAsReadyToShip { get; set; } = null;

    /// <summary>
    /// Deletes an inventory transfer.
    /// </summary>
    [JsonPropertyName("inventoryTransferDelete")]
    public InventoryTransferDeletePayload? inventoryTransferDelete { get; set; } = null;

    /// <summary>
    /// This mutation allows duplicating an existing inventory transfer. The duplicated transfer will have the same
    /// line items and quantities as the original transfer, but will be in a draft state with no shipments.
    /// </summary>
    [JsonPropertyName("inventoryTransferDuplicate")]
    public InventoryTransferDuplicatePayload? inventoryTransferDuplicate { get; set; } = null;

    /// <summary>
    /// Edits an inventory transfer.
    /// </summary>
    [JsonPropertyName("inventoryTransferEdit")]
    public InventoryTransferEditPayload? inventoryTransferEdit { get; set; } = null;

    /// <summary>
    /// Sets an inventory transfer to ready to ship.
    /// </summary>
    [JsonPropertyName("inventoryTransferMarkAsReadyToShip")]
    public InventoryTransferMarkAsReadyToShipPayload? inventoryTransferMarkAsReadyToShip { get; set; } = null;

    /// <summary>
    /// This mutation allows removing the shippable quantities of line items on a Transfer.
    /// It removes all quantities of the item from the transfer that are not associated with shipments.
    /// </summary>
    [JsonPropertyName("inventoryTransferRemoveItems")]
    public InventoryTransferRemoveItemsPayload? inventoryTransferRemoveItems { get; set; } = null;

    /// <summary>
    /// This mutation allows for the setting of line items on a Transfer. Will replace the items already set, if any.
    /// </summary>
    [JsonPropertyName("inventoryTransferSetItems")]
    public InventoryTransferSetItemsPayload? inventoryTransferSetItems { get; set; } = null;

    /// <summary>
    /// Activates a location so that you can stock inventory at the location. Refer to the
    /// [`isActive`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location#field-isactive) and
    /// [`activatable`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location#field-activatable)
    /// fields on the `Location` object.
    /// </summary>
    [JsonPropertyName("locationActivate")]
    public LocationActivatePayload? locationActivate { get; set; } = null;

    /// <summary>
    /// Adds a new location.
    /// </summary>
    [JsonPropertyName("locationAdd")]
    public LocationAddPayload? locationAdd { get; set; } = null;

    /// <summary>
    /// Deactivates a location and moves inventory, pending orders, and moving transfers to a destination location.
    /// </summary>
    [JsonPropertyName("locationDeactivate")]
    public LocationDeactivatePayload? locationDeactivate { get; set; } = null;

    /// <summary>
    /// Deletes a location.
    /// </summary>
    [JsonPropertyName("locationDelete")]
    public LocationDeletePayload? locationDelete { get; set; } = null;

    /// <summary>
    /// Edits an existing location.
    /// [As of the 2023-10 API version](https://shopify.dev/changelog/apps-can-now-change-the-name-and-address-of-their-fulfillment-service-locations),
    /// apps can change the name and address of their fulfillment service locations.
    /// </summary>
    [JsonPropertyName("locationEdit")]
    public LocationEditPayload? locationEdit { get; set; } = null;

    /// <summary>
    /// Disables local pickup for a location.
    /// </summary>
    [JsonPropertyName("locationLocalPickupDisable")]
    public LocationLocalPickupDisablePayload? locationLocalPickupDisable { get; set; } = null;

    /// <summary>
    /// Enables local pickup for a location.
    /// </summary>
    [JsonPropertyName("locationLocalPickupEnable")]
    public LocationLocalPickupEnablePayload? locationLocalPickupEnable { get; set; } = null;

    /// <summary>
    /// Creates a new market.
    /// </summary>
    [JsonPropertyName("marketCreate")]
    public MarketCreatePayload? marketCreate { get; set; } = null;

    /// <summary>
    /// Updates currency settings of a market.
    /// </summary>
    [JsonPropertyName("marketCurrencySettingsUpdate")]
    public MarketCurrencySettingsUpdatePayload? marketCurrencySettingsUpdate { get; set; } = null;

    /// <summary>
    /// Deletes a market definition.
    /// </summary>
    [JsonPropertyName("marketDelete")]
    public MarketDeletePayload? marketDelete { get; set; } = null;

    /// <summary>
    /// Deletes all external marketing activities. Deletion is performed by a
    /// background job, as it may take a bit of time to complete if a large number of
    /// activities are to be deleted. Attempting to create or modify external
    /// activities before the job has completed will result in the
    /// create/update/upsert mutation returning an error.
    /// </summary>
    [JsonPropertyName("marketingActivitiesDeleteAllExternal")]
    public MarketingActivitiesDeleteAllExternalPayload? marketingActivitiesDeleteAllExternal { get; set; } = null;

    /// <summary>
    /// Create new marketing activity. Marketing activity app extensions are deprecated and will be removed in the near future.
    /// </summary>
    [JsonPropertyName("marketingActivityCreate")]
    public MarketingActivityCreatePayload? marketingActivityCreate { get; set; } = null;

    /// <summary>
    /// Creates a new external marketing activity.
    /// </summary>
    [JsonPropertyName("marketingActivityCreateExternal")]
    public MarketingActivityCreateExternalPayload? marketingActivityCreateExternal { get; set; } = null;

    /// <summary>
    /// Deletes an external marketing activity.
    /// </summary>
    [JsonPropertyName("marketingActivityDeleteExternal")]
    public MarketingActivityDeleteExternalPayload? marketingActivityDeleteExternal { get; set; } = null;

    /// <summary>
    /// Updates a marketing activity with the latest information. Marketing activity
    /// app extensions are deprecated and will be removed in the near future.
    /// </summary>
    [JsonPropertyName("marketingActivityUpdate")]
    public MarketingActivityUpdatePayload? marketingActivityUpdate { get; set; } = null;

    /// <summary>
    /// Update an external marketing activity.
    /// </summary>
    [JsonPropertyName("marketingActivityUpdateExternal")]
    public MarketingActivityUpdateExternalPayload? marketingActivityUpdateExternal { get; set; } = null;

    /// <summary>
    /// Creates a new external marketing activity or updates an existing one. When
    /// optional fields are absent or null, associated information will be removed
    /// from an existing marketing activity.
    /// </summary>
    [JsonPropertyName("marketingActivityUpsertExternal")]
    public MarketingActivityUpsertExternalPayload? marketingActivityUpsertExternal { get; set; } = null;

    /// <summary>
    /// Creates a new marketing engagement for a marketing activity or a marketing channel.
    /// </summary>
    [JsonPropertyName("marketingEngagementCreate")]
    public MarketingEngagementCreatePayload? marketingEngagementCreate { get; set; } = null;

    /// <summary>
    /// Marks channel-level engagement data such that it no longer appears in reports.
    ///           Activity-level data cannot be deleted directly, instead the MarketingActivity itself should be deleted to
    ///           hide it from reports.
    /// </summary>
    [JsonPropertyName("marketingEngagementsDelete")]
    public MarketingEngagementsDeletePayload? marketingEngagementsDelete { get; set; } = null;

    /// <summary>
    /// Creates or updates market localizations.
    /// </summary>
    [JsonPropertyName("marketLocalizationsRegister")]
    public MarketLocalizationsRegisterPayload? marketLocalizationsRegister { get; set; } = null;

    /// <summary>
    /// Deletes market localizations.
    /// </summary>
    [JsonPropertyName("marketLocalizationsRemove")]
    public MarketLocalizationsRemovePayload? marketLocalizationsRemove { get; set; } = null;

    /// <summary>
    /// Deletes a market region.
    /// </summary>
    [JsonPropertyName("marketRegionDelete")]
    [Obsolete("Use `marketUpdate` instead.")]
    public MarketRegionDeletePayload? marketRegionDelete { get; set; } = null;

    /// <summary>
    /// Creates regions that belong to an existing market.
    /// </summary>
    [JsonPropertyName("marketRegionsCreate")]
    [Obsolete("This mutation is deprecated and will be removed in the future. Use `marketCreate` or `marketUpdate` instead.")]
    public MarketRegionsCreatePayload? marketRegionsCreate { get; set; } = null;

    /// <summary>
    /// Deletes a list of market regions.
    /// </summary>
    [JsonPropertyName("marketRegionsDelete")]
    [Obsolete("Use `marketUpdate` instead.")]
    public MarketRegionsDeletePayload? marketRegionsDelete { get; set; } = null;

    /// <summary>
    /// Updates the properties of a market.
    /// </summary>
    [JsonPropertyName("marketUpdate")]
    public MarketUpdatePayload? marketUpdate { get; set; } = null;

    /// <summary>
    /// Creates a web presence for a market.
    /// </summary>
    [JsonPropertyName("marketWebPresenceCreate")]
    [Obsolete("Use `webPresenceCreate` instead.")]
    public MarketWebPresenceCreatePayload? marketWebPresenceCreate { get; set; } = null;

    /// <summary>
    /// Deletes a market web presence.
    /// </summary>
    [JsonPropertyName("marketWebPresenceDelete")]
    [Obsolete("Use `webPresenceDelete` instead.")]
    public MarketWebPresenceDeletePayload? marketWebPresenceDelete { get; set; } = null;

    /// <summary>
    /// Updates a market web presence.
    /// </summary>
    [JsonPropertyName("marketWebPresenceUpdate")]
    [Obsolete("Use `webPresenceUpdate` instead.")]
    public MarketWebPresenceUpdatePayload? marketWebPresenceUpdate { get; set; } = null;

    /// <summary>
    /// Creates a menu.
    /// </summary>
    [JsonPropertyName("menuCreate")]
    public MenuCreatePayload? menuCreate { get; set; } = null;

    /// <summary>
    /// Deletes a menu.
    /// </summary>
    [JsonPropertyName("menuDelete")]
    public MenuDeletePayload? menuDelete { get; set; } = null;

    /// <summary>
    /// Updates a menu.
    /// </summary>
    [JsonPropertyName("menuUpdate")]
    public MenuUpdatePayload? menuUpdate { get; set; } = null;

    /// <summary>
    /// Creates a metafield definition. Any metafields existing under the same owner type, namespace, and key will be
    /// checked against this definition and will have their type updated accordingly. For metafields that are not
    /// valid, they will remain unchanged but any attempts to update them must align with this definition.
    /// </summary>
    [JsonPropertyName("metafieldDefinitionCreate")]
    public MetafieldDefinitionCreatePayload? metafieldDefinitionCreate { get; set; } = null;

    /// <summary>
    /// Delete a metafield definition.
    /// Optionally deletes all associated metafields asynchronously when specified.
    /// </summary>
    [JsonPropertyName("metafieldDefinitionDelete")]
    public MetafieldDefinitionDeletePayload? metafieldDefinitionDelete { get; set; } = null;

    /// <summary>
    /// You can organize your metafields in your Shopify admin by pinning/unpinning metafield definitions.
    /// The order of your pinned metafield definitions determines the order in which your metafields are displayed
    /// on the corresponding pages in your Shopify admin. By default, only pinned metafields are automatically displayed.
    /// </summary>
    [JsonPropertyName("metafieldDefinitionPin")]
    public MetafieldDefinitionPinPayload? metafieldDefinitionPin { get; set; } = null;

    /// <summary>
    /// You can organize your metafields in your Shopify admin by pinning/unpinning metafield definitions.
    /// The order of your pinned metafield definitions determines the order in which your metafields are displayed
    /// on the corresponding pages in your Shopify admin. By default, only pinned metafields are automatically displayed.
    /// </summary>
    [JsonPropertyName("metafieldDefinitionUnpin")]
    public MetafieldDefinitionUnpinPayload? metafieldDefinitionUnpin { get; set; } = null;

    /// <summary>
    /// Updates a metafield definition.
    /// </summary>
    [JsonPropertyName("metafieldDefinitionUpdate")]
    public MetafieldDefinitionUpdatePayload? metafieldDefinitionUpdate { get; set; } = null;

    /// <summary>
    /// Deletes multiple metafields in bulk.
    /// </summary>
    [JsonPropertyName("metafieldsDelete")]
    public MetafieldsDeletePayload? metafieldsDelete { get; set; } = null;

    /// <summary>
    /// Sets metafield values. Metafield values will be set regardless if they were previously created or not.
    /// Allows a maximum of 25 metafields to be set at a time.
    /// This operation is atomic, meaning no changes are persisted if an error is encountered.
    /// As of `2024-07`, this operation supports compare-and-set functionality to better handle concurrent requests.
    /// If `compareDigest` is set for any metafield, the mutation will only set that
    /// metafield if the persisted metafield value matches the digest used on
    /// `compareDigest`.
    /// If the metafield doesn't exist yet, but you want to guarantee that the
    /// operation will run in a safe manner, set `compareDigest` to `null`.
    /// The `compareDigest` value can be acquired by querying the metafield object and selecting `compareDigest` as a field.
    /// If the `compareDigest` value does not match the digest for the persisted value, the mutation will return an error.
    /// You can opt out of write guarantees by not sending `compareDigest` in the request.
    /// </summary>
    [JsonPropertyName("metafieldsSet")]
    public MetafieldsSetPayload? metafieldsSet { get; set; } = null;

    /// <summary>
    /// Asynchronously delete metaobjects and their associated metafields in bulk.
    /// </summary>
    [JsonPropertyName("metaobjectBulkDelete")]
    public MetaobjectBulkDeletePayload? metaobjectBulkDelete { get; set; } = null;

    /// <summary>
    /// Creates a new metaobject.
    /// </summary>
    [JsonPropertyName("metaobjectCreate")]
    public MetaobjectCreatePayload? metaobjectCreate { get; set; } = null;

    /// <summary>
    /// Creates a new metaobject definition.
    /// </summary>
    [JsonPropertyName("metaobjectDefinitionCreate")]
    public MetaobjectDefinitionCreatePayload? metaobjectDefinitionCreate { get; set; } = null;

    /// <summary>
    /// Deletes the specified metaobject definition.
    /// Also deletes all related metafield definitions, metaobjects, and metafields asynchronously.
    /// </summary>
    [JsonPropertyName("metaobjectDefinitionDelete")]
    public MetaobjectDefinitionDeletePayload? metaobjectDefinitionDelete { get; set; } = null;

    /// <summary>
    /// Updates a metaobject definition with new settings and metafield definitions.
    /// </summary>
    [JsonPropertyName("metaobjectDefinitionUpdate")]
    public MetaobjectDefinitionUpdatePayload? metaobjectDefinitionUpdate { get; set; } = null;

    /// <summary>
    /// Deletes the specified metaobject and its associated metafields.
    /// </summary>
    [JsonPropertyName("metaobjectDelete")]
    public MetaobjectDeletePayload? metaobjectDelete { get; set; } = null;

    /// <summary>
    /// Updates an existing metaobject.
    /// </summary>
    [JsonPropertyName("metaobjectUpdate")]
    public MetaobjectUpdatePayload? metaobjectUpdate { get; set; } = null;

    /// <summary>
    /// Retrieves a metaobject by handle, then updates it with the provided input values.
    /// If no matching metaobject is found, a new metaobject is created with the provided input values.
    /// </summary>
    [JsonPropertyName("metaobjectUpsert")]
    public MetaobjectUpsertPayload? metaobjectUpsert { get; set; } = null;

    /// <summary>
    /// Create a mobile platform application.
    /// </summary>
    [JsonPropertyName("mobilePlatformApplicationCreate")]
    public MobilePlatformApplicationCreatePayload? mobilePlatformApplicationCreate { get; set; } = null;

    /// <summary>
    /// Delete a mobile platform application.
    /// </summary>
    [JsonPropertyName("mobilePlatformApplicationDelete")]
    public MobilePlatformApplicationDeletePayload? mobilePlatformApplicationDelete { get; set; } = null;

    /// <summary>
    /// Update a mobile platform application.
    /// </summary>
    [JsonPropertyName("mobilePlatformApplicationUpdate")]
    public MobilePlatformApplicationUpdatePayload? mobilePlatformApplicationUpdate { get; set; } = null;

    /// <summary>
    /// Cancels an order, with options for refunding, restocking inventory, and customer notification.
    /// > Caution:
    /// > Order cancellation is irreversible. An order that has been cancelled can't be restored to its original state.
    /// Use the `orderCancel` mutation to programmatically cancel orders in scenarios such as:
    /// - Customer-requested cancellations due to size, color, or other preference changes
    /// - Payment processing failures or declined transactions
    /// - Fraud detection and prevention
    /// - Insufficient inventory availability
    /// - Staff errors in order processing
    /// - Wholesale or B2B order management workflows
    /// The `orderCancel` mutation provides flexible refund options including refunding to original payment methods
    /// or issuing store credit. If a payment was only authorized (temporarily held) but not yet charged,
    /// that hold will be automatically released when the order is cancelled, even if you choose not to refund other payments.
    /// The mutation supports different cancellation reasons: customer requests, payment declines, fraud,
    /// inventory issues, staff errors, or other unspecified reasons. Each cancellation can include optional
    /// staff notes for internal documentation (notes aren't visible to customers).
    /// An order can only be cancelled if it meets the following criteria:
    /// - The order hasn't already been cancelled.
    /// - The order has no pending payment authorizations.
    /// - The order has no active returns in progress.
    /// - The order has no outstanding fulfillments that can't be cancelled.
    /// Orders might be assigned to locations that become
    /// [deactivated](https://help.shopify.com/manual/fulfillment/setup/locations-management#deactivate-and-reactivate-locations)
    /// after the order was created. When cancelling such orders, inventory behavior depends on payment status:
    /// - **Paid orders**: Cancellation will fail with an error if restocking is enabled, since inventory
    /// can't be returned to deactivated locations.
    /// - **Unpaid orders**: Cancellation succeeds but inventory is not restocked anywhere, even when the
    /// restock option is enabled. The committed inventory effectively becomes unavailable rather than being
    /// returned to stock at the deactivated location.
    /// After you cancel an order, you can still make limited updates to certain fields (like
    /// notes and tags) using the
    /// [`orderUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/orderUpdate).
    /// For partial refunds or more complex refund scenarios on active orders,
    /// such as refunding only specific line items while keeping the rest of the order fulfilled,
    /// consider using the [`refundCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/refundCreate)
    /// mutation instead of full order cancellation.
    /// Learn how to build apps that integrate with
    /// [order management and fulfillment processes](https://shopify.dev/docs/apps/build/orders-fulfillment).
    /// </summary>
    [JsonPropertyName("orderCancel")]
    public OrderCancelPayload? orderCancel { get; set; } = null;

    /// <summary>
    /// Captures payment for an authorized transaction on an order. Use this mutation to claim the money that was previously
    /// reserved by an authorization transaction.
    /// The `orderCapture` mutation can be used in the following scenarios:
    /// - To capture the full amount of an authorized transaction
    /// - To capture a partial payment by specifying an amount less than the total order amount
    /// - To perform multiple captures on the same order, as long as the order transaction is
    /// [multi-capturable](https://shopify.dev/docs/api/admin-graphql/latest/objects/ordertransaction#field-OrderTransaction.fields.multiCapturable)
    /// > Note:
    /// > Multi-capture functionality is only available to stores on a
    /// [Shopify Plus plan](https://help.shopify.com/manual/intro-to-shopify/pricing-plans/plans-features/shopify-plus-plan).
    /// For multi-currency orders, the [`currency`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/orderCapture#arguments-input.fields.currency)
    /// field is required and should match the presentment currency from the order.
    /// After capturing a payment, you can:
    /// - View the transaction details including status, amount, and processing information.
    /// - Track the captured amount in both shop and presentment currencies.
    /// - Monitor the transaction's settlement status.
    /// Learn more about [order transactions](https://shopify.dev/docs/api/admin-graphql/latest/objects/OrderTransaction).
    /// </summary>
    [JsonPropertyName("orderCapture")]
    public OrderCapturePayload? orderCapture { get; set; } = null;

    /// <summary>
    /// Closes an open order.
    /// </summary>
    [JsonPropertyName("orderClose")]
    public OrderClosePayload? orderClose { get; set; } = null;

    /// <summary>
    /// Creates an order with attributes such as customer information, line items, and shipping and billing addresses.
    /// Use the `orderCreate` mutation to programmatically generate orders in scenarios where
    /// orders aren't created through the standard checkout process, such as when importing orders from an external
    /// system or creating orders for wholesale customers.
    /// The `orderCreate` mutation doesn't support applying multiple discounts, such as discounts on line items.
    /// Automatic discounts won't be applied unless you replicate the logic of those discounts in your custom
    /// implementation. You can [apply a discount code](https://shopify.dev/docs/api/admin-graphql/latest/input-objects/OrderCreateDiscountCodeInput),
    /// but only one discount code can be set for each order.
    /// > Note:
    /// > If you're using the `orderCreate` mutation with a
    /// > [trial](https://help.shopify.com/manual/intro-to-shopify/pricing-plans/free-trial) or
    /// > [development store](https://shopify.dev/docs/api/development-stores), then you can create a
    /// > maximum of five new orders per minute.
    /// After you create an order, you can make subsequent edits to the order using one of the following mutations:
    /// * [`orderUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/orderUpdate):
    /// Used for simple updates to an order, such as changing the order's note, tags, or customer information.
    /// * [`orderEditBegin`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/orderEditBegin):
    /// Used when you need to make significant updates to an order, such as adding or removing line items, changing
    /// quantities, or modifying discounts. The `orderEditBegin` mutation initiates an order editing session,
    /// allowing you to make multiple changes before finalizing them. Learn more about using the `orderEditBegin`
    /// mutation to [edit existing orders](https://shopify.dev/docs/apps/build/orders-fulfillment/order-management-apps/edit-orders).
    /// Learn how to build apps that integrate with
    /// [order management and fulfillment processes](https://shopify.dev/docs/apps/build/orders-fulfillment).
    /// </summary>
    [JsonPropertyName("orderCreate")]
    public OrderCreatePayload? orderCreate { get; set; } = null;

    /// <summary>
    /// Creates a payment for an order by mandate.
    /// </summary>
    [JsonPropertyName("orderCreateMandatePayment")]
    public OrderCreateMandatePaymentPayload? orderCreateMandatePayment { get; set; } = null;

    /// <summary>
    /// Create a manual payment for an order. You can only create a manual payment for an order if it isn't already
    /// fully paid.
    /// </summary>
    [JsonPropertyName("orderCreateManualPayment")]
    public OrderCreateManualPaymentPayload? orderCreateManualPayment { get; set; } = null;

    /// <summary>
    /// Removes customer from an order.
    /// </summary>
    [JsonPropertyName("orderCustomerRemove")]
    public OrderCustomerRemovePayload? orderCustomerRemove { get; set; } = null;

    /// <summary>
    /// Sets a customer on an order.
    /// </summary>
    [JsonPropertyName("orderCustomerSet")]
    public OrderCustomerSetPayload? orderCustomerSet { get; set; } = null;

    /// <summary>
    /// Deletes an order. For more information on which orders can be deleted, refer to [Delete an order](https://help.shopify.com/manual/orders/cancel-delete-order#delete-an-order).
    /// </summary>
    [JsonPropertyName("orderDelete")]
    public OrderDeletePayload? orderDelete { get; set; } = null;

    /// <summary>
    /// Adds a custom line item to an existing order. For example, you could add a
    /// gift wrapping service as a [custom line item](https://shopify.dev/apps/fulfillment/order-management-apps/order-editing#add-a-custom-line-item).
    /// To learn how to edit existing orders, refer to [Edit an existing order with Admin API](https://shopify.dev/apps/fulfillment/order-management-apps/order-editing).
    /// </summary>
    [JsonPropertyName("orderEditAddCustomItem")]
    public OrderEditAddCustomItemPayload? orderEditAddCustomItem { get; set; } = null;

    /// <summary>
    /// Adds a discount to a line item on the current order edit. For more information
    /// on how to use the GraphQL Admin API to edit an existing order, refer to [Edit existing orders](https://shopify.dev/apps/fulfillment/order-management-apps/order-editing).
    /// </summary>
    [JsonPropertyName("orderEditAddLineItemDiscount")]
    public OrderEditAddLineItemDiscountPayload? orderEditAddLineItemDiscount { get; set; } = null;

    /// <summary>
    /// Adds a shipping line to an existing order. For more information on how to use
    /// the GraphQL Admin API to edit an existing order, refer to [Edit existing orders](https://shopify.dev/apps/fulfillment/order-management-apps/order-editing).
    /// </summary>
    [JsonPropertyName("orderEditAddShippingLine")]
    public OrderEditAddShippingLinePayload? orderEditAddShippingLine { get; set; } = null;

    /// <summary>
    /// Adds a line item from an existing product variant. As of API version 2025-04, the [orderEditAddVariant](https://shopify.dev/api/admin-graphql/latest/mutations/ordereditaddvariant)
    /// API will respect the contextual pricing of the variant.
    /// </summary>
    [JsonPropertyName("orderEditAddVariant")]
    public OrderEditAddVariantPayload? orderEditAddVariant { get; set; } = null;

    /// <summary>
    /// Starts editing an order. Mutations are operating on `OrderEdit`.
    /// All order edits start with `orderEditBegin`, have any number of `orderEdit`*
    /// mutations made, and end with `orderEditCommit`.
    /// </summary>
    [JsonPropertyName("orderEditBegin")]
    public OrderEditBeginPayload? orderEditBegin { get; set; } = null;

    /// <summary>
    /// Applies and saves staged changes to an order. Mutations are operating on `OrderEdit`.
    /// All order edits start with `orderEditBegin`, have any number of `orderEdit`*
    /// mutations made, and end with `orderEditCommit`.
    /// </summary>
    [JsonPropertyName("orderEditCommit")]
    public OrderEditCommitPayload? orderEditCommit { get; set; } = null;

    /// <summary>
    /// Removes a discount on the current order edit. For more information on how to
    /// use the GraphQL Admin API to edit an existing order, refer to [Edit existing orders](https://shopify.dev/apps/fulfillment/order-management-apps/order-editing).
    /// </summary>
    [JsonPropertyName("orderEditRemoveDiscount")]
    public OrderEditRemoveDiscountPayload? orderEditRemoveDiscount { get; set; } = null;

    /// <summary>
    /// Removes a line item discount that was applied as part of an order edit.
    /// </summary>
    [JsonPropertyName("orderEditRemoveLineItemDiscount")]
    [Obsolete("Use `orderEditRemoveDiscount` instead.")]
    public OrderEditRemoveLineItemDiscountPayload? orderEditRemoveLineItemDiscount { get; set; } = null;

    /// <summary>
    /// Removes a shipping line from an existing order. For more information on how to
    /// use the GraphQL Admin API to edit an existing order, refer to [Edit existing orders](https://shopify.dev/apps/fulfillment/order-management-apps/order-editing).
    /// </summary>
    [JsonPropertyName("orderEditRemoveShippingLine")]
    public OrderEditRemoveShippingLinePayload? orderEditRemoveShippingLine { get; set; } = null;

    /// <summary>
    /// Sets the quantity of a line item on an order that is being edited. For more
    /// information on how to use the GraphQL Admin API to edit an existing order,
    /// refer to [Edit existing orders](https://shopify.dev/apps/fulfillment/order-management-apps/order-editing).
    /// </summary>
    [JsonPropertyName("orderEditSetQuantity")]
    public OrderEditSetQuantityPayload? orderEditSetQuantity { get; set; } = null;

    /// <summary>
    /// Updates a manual line level discount on the current order edit. For more
    /// information on how to use the GraphQL Admin API to edit an existing order,
    /// refer to [Edit existing orders](https://shopify.dev/apps/fulfillment/order-management-apps/order-editing).
    /// </summary>
    [JsonPropertyName("orderEditUpdateDiscount")]
    public OrderEditUpdateDiscountPayload? orderEditUpdateDiscount { get; set; } = null;

    /// <summary>
    /// Updates a shipping line on the current order edit. For more information on how
    /// to use the GraphQL Admin API to edit an existing order, refer to [Edit existing orders](https://shopify.dev/apps/fulfillment/order-management-apps/order-editing).
    /// </summary>
    [JsonPropertyName("orderEditUpdateShippingLine")]
    public OrderEditUpdateShippingLinePayload? orderEditUpdateShippingLine { get; set; } = null;

    /// <summary>
    /// Sends an email invoice for an order.
    /// </summary>
    [JsonPropertyName("orderInvoiceSend")]
    public OrderInvoiceSendPayload? orderInvoiceSend { get; set; } = null;

    /// <summary>
    /// Marks an order as paid by recording a payment transaction for the outstanding amount.
    /// Use the `orderMarkAsPaid` mutation to record payments received outside the standard checkout
    /// process. The `orderMarkAsPaid` mutation is particularly useful in scenarios where:
    /// - Orders were created with manual payment methods (cash on delivery, bank deposit, money order)
    /// - Payments were received offline and need to be recorded in the system
    /// - Previously authorized payments need to be captured manually
    /// - Orders require manual payment reconciliation due to external payment processing
    /// The mutation validates that the order can be marked as paid before processing.
    /// An order can be marked as paid only if it has a positive outstanding balance and its
    /// [financial status](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order#field-Order.fields.displayFinancialStatus)
    /// isn't already `PAID`. The mutation will either create a new sale transaction for the full
    /// outstanding amount or capture an existing authorized transaction, depending on the order's current payment state.
    /// After successfully marking an order as paid, the order's financial status is updated to
    /// reflect the payment, and payment events are logged for tracking and analytics
    /// purposes.
    /// Learn more about [managing orders](https://shopify.dev/docs/apps/build/orders-fulfillment/order-management-apps)
    /// in apps.
    /// </summary>
    [JsonPropertyName("orderMarkAsPaid")]
    public OrderMarkAsPaidPayload? orderMarkAsPaid { get; set; } = null;

    /// <summary>
    /// Opens a closed order.
    /// </summary>
    [JsonPropertyName("orderOpen")]
    public OrderOpenPayload? orderOpen { get; set; } = null;

    /// <summary>
    /// Create a risk assessment for an order.
    /// </summary>
    [JsonPropertyName("orderRiskAssessmentCreate")]
    public OrderRiskAssessmentCreatePayload? orderRiskAssessmentCreate { get; set; } = null;

    /// <summary>
    /// Updates the attributes of an order, such as the customer's email, the shipping address for the order,
    /// tags, and [metafields](https://shopify.dev/docs/apps/build/custom-data) associated with the order.
    /// If you need to make significant updates to an order, such as adding or removing line items, changing
    /// quantities, or modifying discounts, then use
    /// the [`orderEditBegin`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/orderEditBegin)
    /// mutation instead. The `orderEditBegin` mutation initiates an order editing session,
    /// allowing you to make multiple changes before finalizing them. Learn more about using the `orderEditBegin`
    /// mutation to [edit existing orders](https://shopify.dev/docs/apps/build/orders-fulfillment/order-management-apps/edit-orders).
    /// If you need to remove a customer from an order, then use the [`orderCustomerRemove`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/orderCustomerRemove)
    /// mutation instead.
    /// Learn how to build apps that integrate with
    /// [order management and fulfillment processes](https://shopify.dev/docs/apps/build/orders-fulfillment).
    /// </summary>
    [JsonPropertyName("orderUpdate")]
    public OrderUpdatePayload? orderUpdate { get; set; } = null;

    /// <summary>
    /// Creates a page.
    /// </summary>
    [JsonPropertyName("pageCreate")]
    public PageCreatePayload? pageCreate { get; set; } = null;

    /// <summary>
    /// Deletes a page.
    /// </summary>
    [JsonPropertyName("pageDelete")]
    public PageDeletePayload? pageDelete { get; set; } = null;

    /// <summary>
    /// Updates a page.
    /// </summary>
    [JsonPropertyName("pageUpdate")]
    public PageUpdatePayload? pageUpdate { get; set; } = null;

    /// <summary>
    /// Activates and deactivates payment customizations.
    /// </summary>
    [JsonPropertyName("paymentCustomizationActivation")]
    public PaymentCustomizationActivationPayload? paymentCustomizationActivation { get; set; } = null;

    /// <summary>
    /// Creates a payment customization.
    /// </summary>
    [JsonPropertyName("paymentCustomizationCreate")]
    public PaymentCustomizationCreatePayload? paymentCustomizationCreate { get; set; } = null;

    /// <summary>
    /// Deletes a payment customization.
    /// </summary>
    [JsonPropertyName("paymentCustomizationDelete")]
    public PaymentCustomizationDeletePayload? paymentCustomizationDelete { get; set; } = null;

    /// <summary>
    /// Updates a payment customization.
    /// </summary>
    [JsonPropertyName("paymentCustomizationUpdate")]
    public PaymentCustomizationUpdatePayload? paymentCustomizationUpdate { get; set; } = null;

    /// <summary>
    /// Sends an email payment reminder for a payment schedule.
    /// </summary>
    [JsonPropertyName("paymentReminderSend")]
    public PaymentReminderSendPayload? paymentReminderSend { get; set; } = null;

    /// <summary>
    /// Create payment terms on an order. To create payment terms on a draft order,
    /// use a draft order mutation and include the request with the `DraftOrderInput`.
    /// </summary>
    [JsonPropertyName("paymentTermsCreate")]
    public PaymentTermsCreatePayload? paymentTermsCreate { get; set; } = null;

    /// <summary>
    /// Delete payment terms for an order. To delete payment terms on a draft order,
    /// use a draft order mutation and include the request with the `DraftOrderInput`.
    /// </summary>
    [JsonPropertyName("paymentTermsDelete")]
    public PaymentTermsDeletePayload? paymentTermsDelete { get; set; } = null;

    /// <summary>
    /// Update payment terms on an order. To update payment terms on a draft order,
    /// use a draft order mutation and include the request with the `DraftOrderInput`.
    /// </summary>
    [JsonPropertyName("paymentTermsUpdate")]
    public PaymentTermsUpdatePayload? paymentTermsUpdate { get; set; } = null;

    /// <summary>
    /// Creates a price list. You can use the `priceListCreate` mutation to create a
    /// new price list and associate it with a catalog. This enables you to sell your
    /// products with contextual pricing.
    /// </summary>
    [JsonPropertyName("priceListCreate")]
    public PriceListCreatePayload? priceListCreate { get; set; } = null;

    /// <summary>
    /// Deletes a price list. For example, you can delete a price list so that it no
    /// longer applies for products in the associated market.
    /// </summary>
    [JsonPropertyName("priceListDelete")]
    public PriceListDeletePayload? priceListDelete { get; set; } = null;

    /// <summary>
    /// Creates or updates fixed prices on a price list. You can use the
    /// `priceListFixedPricesAdd` mutation to set a fixed price for specific product
    /// variants. This lets you change product variant pricing on a per country basis.
    /// Any existing fixed price list prices for these variants will be overwritten.
    /// </summary>
    [JsonPropertyName("priceListFixedPricesAdd")]
    public PriceListFixedPricesAddPayload? priceListFixedPricesAdd { get; set; } = null;

    /// <summary>
    /// Updates the fixed prices for all variants for a product on a price list. You
    /// can use the `priceListFixedPricesByProductUpdate` mutation to set or remove a
    /// fixed price for all variants of a product associated with the price list.
    /// </summary>
    [JsonPropertyName("priceListFixedPricesByProductUpdate")]
    public PriceListFixedPricesByProductUpdatePayload? priceListFixedPricesByProductUpdate { get; set; } = null;

    /// <summary>
    /// Deletes specific fixed prices from a price list using a product variant ID.
    /// You can use the `priceListFixedPricesDelete` mutation to delete a set of fixed
    /// prices from a price list. After deleting the set of fixed prices from the
    /// price list, the price of each product variant reverts to the original price
    /// that was determined by the price list adjustment.
    /// </summary>
    [JsonPropertyName("priceListFixedPricesDelete")]
    public PriceListFixedPricesDeletePayload? priceListFixedPricesDelete { get; set; } = null;

    /// <summary>
    /// Updates fixed prices on a price list. You can use the
    /// `priceListFixedPricesUpdate` mutation to set a fixed price for specific
    /// product variants or to delete prices for variants associated with the price list.
    /// </summary>
    [JsonPropertyName("priceListFixedPricesUpdate")]
    public PriceListFixedPricesUpdatePayload? priceListFixedPricesUpdate { get; set; } = null;

    /// <summary>
    /// Updates a price list.
    /// If you modify the currency, then any fixed prices set on the price list will be deleted.
    /// </summary>
    [JsonPropertyName("priceListUpdate")]
    public PriceListUpdatePayload? priceListUpdate { get; set; } = null;

    /// <summary>
    /// Disable a shop's privacy features.
    /// </summary>
    [JsonPropertyName("privacyFeaturesDisable")]
    public PrivacyFeaturesDisablePayload? privacyFeaturesDisable { get; set; } = null;

    /// <summary>
    /// Creates a new componentized product.
    /// </summary>
    [JsonPropertyName("productBundleCreate")]
    public ProductBundleCreatePayload? productBundleCreate { get; set; } = null;

    /// <summary>
    /// Updates a componentized product.
    /// </summary>
    [JsonPropertyName("productBundleUpdate")]
    public ProductBundleUpdatePayload? productBundleUpdate { get; set; } = null;

    /// <summary>
    /// Changes the status of a product. This allows you to set the availability of the product across all channels.
    /// </summary>
    [JsonPropertyName("productChangeStatus")]
    [Obsolete("Use `productUpdate` instead.")]
    public ProductChangeStatusPayload? productChangeStatus { get; set; } = null;

    /// <summary>
    /// Creates a [product](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
    /// with attributes such as title, description, vendor, and media.
    /// The `productCreate` mutation helps you create many products at once, avoiding the tedious or time-consuming
    /// process of adding them one by one in the Shopify admin. Common examples include creating products for a
    /// new collection, launching a new product line, or adding seasonal products.
    /// You can define product
    /// [options](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOption) and
    /// [values](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOptionValue),
    /// allowing you to create products with different variations like sizes or colors. You can also associate media
    /// files to your products, including images and videos.
    /// The `productCreate` mutation only supports creating a product with its initial
    /// [product variant](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant).
    /// To create multiple product variants for a single product and manage prices, use the
    /// [`productVariantsBulkCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkCreate)
    /// mutation.
    /// > Note:
    /// > The `productCreate` mutation has a [throttle](https://shopify.dev/docs/api/usage/rate-limits#resource-based-rate-limits)
    /// > that takes effect when a store has 50,000 product variants. After this threshold is reached, no more than
    /// > 1,000 new product variants can be created per day.
    /// After you create a product, you can make subsequent edits to the product using one of the following mutations:
    /// - [`publishablePublish`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/publishablePublish):
    /// Used to publish the product and make it available to customers. The `productCreate` mutation creates products
    /// in an unpublished state by default, so you must perform a separate operation to publish the product.
    /// - [`productUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productUpdate):
    /// Used to update a single product, such as changing the product's title, description, vendor, or associated media.
    /// - [`productSet`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productSet):
    /// Used to perform multiple operations on products, such as creating or modifying product options and variants.
    /// Learn more about the [product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model)
    /// and [adding product data](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/add-data).
    /// </summary>
    [JsonPropertyName("productCreate")]
    public ProductCreatePayload? productCreate { get; set; } = null;

    /// <summary>
    /// Creates media for a product.
    /// </summary>
    [JsonPropertyName("productCreateMedia")]
    [Obsolete("Use `productUpdate` or `productSet` instead.")]
    public ProductCreateMediaPayload? productCreateMedia { get; set; } = null;

    /// <summary>
    /// Permanently deletes a product and all its associated data, including variants, media, publications, and inventory items.
    /// Use the `productDelete` mutation to programmatically remove products from your store when they need to be
    /// permanently deleted from your catalog, such as when removing discontinued items, cleaning up test data, or
    /// synchronizing with external inventory management systems.
    /// The `productDelete` mutation removes the product from all associated collections,
    /// and removes all associated data for the product, including:
    /// - All product variants and their inventory items
    /// - Product media (images, videos) that are not referenced by other products
    /// - [Product options](https://shopify.dev/api/admin-graphql/latest/objects/ProductOption) and [option values](https://shopify.dev/api/admin-graphql/latest/objects/ProductOptionValue)
    /// - Product publications across all sales channels
    /// - Product tags and metadata associations
    /// The `productDelete` mutation also has the following effects on existing orders and transactions:
    /// - **Draft orders**: Existing draft orders that reference this product will
    /// retain the product information as stored data, but the product reference will
    /// be removed. Draft orders can still be completed with the stored product details.
    /// - **Completed orders and refunds**: Previously completed orders that included
    /// this product aren't affected. The product information in completed orders is
    /// preserved for record-keeping, and existing refunds for this product remain
    /// valid and processable.
    /// > Caution:
    /// > Product deletion is irreversible. After a product is deleted, it can't be recovered. Consider archiving
    /// > or unpublishing products instead if you might need to restore them later.
    /// If you need to delete a large product, such as one that has many
    /// [variants](https://shopify.dev/api/admin-graphql/latest/objects/ProductVariant)
    /// that are active at several
    /// [locations](https://shopify.dev/api/admin-graphql/latest/objects/Location),
    /// you might encounter timeout errors. To avoid these timeout errors, you can set the
    /// [`synchronous`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productDelete#arguments-synchronous)
    /// parameter to `false` to run the deletion asynchronously, which returns a
    /// [`ProductDeleteOperation`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductDeleteOperation)
    /// that you can monitor for completion status.
    /// If you need more granular control over product cleanup, consider using these alternative mutations:
    /// - [`productUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productUpdate):
    /// Update the product status to archived or unpublished instead of deleting.
    /// - [`productVariantsBulkDelete`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkDelete):
    /// Delete specific variants while keeping the product.
    /// - [`productOptionsDelete`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsDelete):
    /// Delete the choices available for a product, such as size, color, or material.
    /// Learn more about the [product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model).
    /// </summary>
    [JsonPropertyName("productDelete")]
    public ProductDeletePayload? productDelete { get; set; } = null;

    /// <summary>
    /// Deletes media for a product.
    /// </summary>
    [JsonPropertyName("productDeleteMedia")]
    [Obsolete("Use `fileUpdate` instead.")]
    public ProductDeleteMediaPayload? productDeleteMedia { get; set; } = null;

    /// <summary>
    /// Duplicates a product.
    /// If you need to duplicate a large product, such as one that has many
    /// [variants](https://shopify.dev/api/admin-graphql/latest/input-objects/ProductVariantInput)
    /// that are active at several
    /// [locations](https://shopify.dev/api/admin-graphql/latest/input-objects/InventoryLevelInput),
    /// you might encounter timeout errors.
    /// To avoid these timeout errors, you can instead duplicate the product asynchronously.
    /// In API version 2024-10 and higher, include `synchronous: false` argument in
    /// this mutation to perform the duplication asynchronously.
    /// In API version 2024-07 and lower, use the asynchronous [`ProductDuplicateAsyncV2`](https://shopify.dev/api/admin-graphql/2024-07/mutations/productDuplicateAsyncV2).
    /// Metafield values are not duplicated if the unique values capability is enabled.
    /// </summary>
    [JsonPropertyName("productDuplicate")]
    public ProductDuplicatePayload? productDuplicate { get; set; } = null;

    /// <summary>
    /// Creates a product feed for a specific publication.
    /// </summary>
    [JsonPropertyName("productFeedCreate")]
    public ProductFeedCreatePayload? productFeedCreate { get; set; } = null;

    /// <summary>
    /// Deletes a product feed for a specific publication.
    /// </summary>
    [JsonPropertyName("productFeedDelete")]
    public ProductFeedDeletePayload? productFeedDelete { get; set; } = null;

    /// <summary>
    /// Runs the full product sync for a given shop.
    /// </summary>
    [JsonPropertyName("productFullSync")]
    public ProductFullSyncPayload? productFullSync { get; set; } = null;

    /// <summary>
    /// Adds multiple selling plan groups to a product.
    /// </summary>
    [JsonPropertyName("productJoinSellingPlanGroups")]
    public ProductJoinSellingPlanGroupsPayload? productJoinSellingPlanGroups { get; set; } = null;

    /// <summary>
    /// Removes multiple groups from a product.
    /// </summary>
    [JsonPropertyName("productLeaveSellingPlanGroups")]
    public ProductLeaveSellingPlanGroupsPayload? productLeaveSellingPlanGroups { get; set; } = null;

    /// <summary>
    /// Creates one or more [options](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOption)
    /// on a [product](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product),
    /// such as size, color, or material. Each option includes a name, position, and a list of values. The combination
    /// of a product option and value creates a [product variant](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant).
    /// Use the `productOptionsCreate` mutation for the following use cases:
    /// - **Add product choices**: Add a new option, like "Size" (Small, Medium, Large) or
    /// "Color" (Red, Blue, Green), to an existing product so customers can select their preferred variant.
    /// - **Enable personalization features**: Add options such as "Engraving text" to let customers customize their purchase.
    /// - **Offer seasonal or limited edition products**: Add a new value
    /// (for example, "Holiday red") to an existing option to support limited-time or seasonal variants.
    /// - **Integrate with apps that manage product configuration**: Allow third-party apps to add options, like
    /// "Bundle size", when customers select or customize
    /// [product bundles](https://shopify.dev/docs/apps/build/product-merchandising/bundles).
    /// - **Link options to metafields**: Associate a product option with a custom
    /// [metafield](https://shopify.dev/docs/apps/build/custom-data), like "Fabric code", for
    /// richer integrations with other systems or apps.
    /// > Note:
    /// > The `productOptionsCreate` mutation enforces strict data integrity for product options and variants.
    /// All option positions must be sequential, and every option should be used by at least one variant.
    /// If you use the [`CREATE` variant strategy](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsCreate#arguments-variantStrategy.enums.CREATE),
    /// consider the maximum allowed number of variants for each product
    /// (100 by default, and 2,048 if you've
    /// [enabled the **Extended Variants** developer preview](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/migrate-and-test#create-a-development-store-that-allows-2-048-variants-per-product)).
    /// After you create product options, you can further manage a product's configuration using related mutations:
    /// - [`productOptionUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionUpdate)
    /// - [`productOptionsReorder`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsReorder)
    /// - [`productOptionsDelete`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsDelete)
    /// - [`productVariantsBulkCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkCreate)
    /// - [`productVariantsBulkUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkUpdate)
    /// - [`productSet`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productSet)
    /// Learn more about the [product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model)
    /// and [adding product data](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/add-data).
    /// </summary>
    [JsonPropertyName("productOptionsCreate")]
    public ProductOptionsCreatePayload? productOptionsCreate { get; set; } = null;

    /// <summary>
    /// Deletes one or more [options](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOption)
    /// from a [product](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product). Product options
    /// define the choices available for a product, such as size, color, or material.
    /// > Caution:
    /// > Removing an option can affect a product's
    /// > [variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant) and their
    /// > configuration. Deleting an option might also delete associated option values and, depending on the chosen
    /// > [strategy](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productoptionsdelete#arguments-strategy),
    /// > might affect variants.
    /// Use the `productOptionsDelete` mutation for the following use cases:
    /// - **Simplify product configuration**: Remove obsolete or unnecessary options
    /// (for example, discontinue "Material" if all variants are now the same material).
    /// - **Clean up after seasonal or limited-time offerings**: Delete options that are no longer
    /// relevant (for example, "Holiday edition").
    /// - **Automate catalog management**: Enable apps or integrations to programmatically remove options as product
    /// data changes.
    /// > Note:
    /// > The `productOptionsDelete` mutation enforces strict data integrity for product options and variants.
    /// > All option positions must remain sequential, and every remaining option must be used by at least one variant.
    /// After you delete a product option, you can further manage a product's configuration using related mutations:
    /// - [`productOptionsCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsCreate)
    /// - [`productOptionUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionUpdate)
    /// - [`productOptionsReorder`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsReorder)
    /// - [`productVariantsBulkCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkCreate)
    /// - [`productVariantsBulkUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkUpdate)
    /// - [`productSet`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productSet)
    /// Learn more about the [product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model)
    /// and [adding product data](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/add-data).
    /// </summary>
    [JsonPropertyName("productOptionsDelete")]
    public ProductOptionsDeletePayload? productOptionsDelete { get; set; } = null;

    /// <summary>
    /// Reorders the [options](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOption) and
    /// [option values](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOptionValue) on a
    /// [product](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product),
    /// updating the order in which [product variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant)
    /// are presented to customers.
    /// The `productOptionsReorder` mutation accepts a list of product options, each identified by `id` or `name`, and an
    /// optional list of values (also by `id` or `name`) specifying the new order. The order of options in the
    /// mutation's input determines their new positions (for example, the first option becomes `option1`).
    /// The order of values within each option determines their new positions. The mutation recalculates the order of
    /// variants based on the new option and value order.
    /// Suppose a product has the following variants:
    /// 1. `"Red / Small"`
    /// 2. `"Green / Medium"`
    /// 3. `"Blue / Small"`
    /// You reorder options and values:
    /// ```
    /// options: [
    ///   { name: "Size", values: [{ name: "Small" }, { name: "Medium" }] },
    ///   { name: "Color", values: [{ name: "Green" }, { name: "Red" }, { name: "Blue" }] }
    /// ]
    /// ```
    /// The resulting variant order will be:
    /// 1. `"Small / Green"`
    /// 2. `"Small / Red"`
    /// 3. `"Small / Blue"`
    /// 4. `"Medium / Green"`
    /// Use the `productOptionsReorder` mutation for the following use cases:
    /// - **Change the order of product options**: For example, display "Color" before "Size" in a store.
    /// - **Reorder option values within an option**: For example, show "Red" before "Blue" in a color picker.
    /// - **Control the order of product variants**: The order of options and their
    /// values determines the sequence in which variants are listed and selected.
    /// - **Highlight best-selling options**: Present the most popular or relevant options and values first.
    /// - **Promote merchandising strategies**: Highlight seasonal colors, limited editions, or featured sizes.
    /// > Note:
    /// > The `productOptionsReorder` mutation enforces strict data integrity for product options and variants.
    /// > All option positions must be sequential, and every option should be used by at least one variant.
    /// After you reorder product options, you can further manage a product's configuration using related mutations:
    /// - [`productOptionsCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsCreate)
    /// - [`productOptionsDelete`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsDelete)
    /// - [`productVariantsBulkCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkCreate)
    /// - [`productVariantsBulkUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkUpdate)
    /// - [`productSet`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productSet)
    /// Learn more about the [product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model)
    /// and [managing product data](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/add-data).
    /// </summary>
    [JsonPropertyName("productOptionsReorder")]
    public ProductOptionsReorderPayload? productOptionsReorder { get; set; } = null;

    /// <summary>
    /// Updates an [option](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductOption)
    /// on a [product](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product),
    /// such as size, color, or material. Each option includes a name, position, and a list of values. The combination
    /// of a product option and value creates a [product variant](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant).
    /// Use the `productOptionUpdate` mutation for the following use cases:
    /// - **Update product choices**: Modify an existing option, like "Size" (Small, Medium, Large) or
    /// "Color" (Red, Blue, Green), so customers can select their preferred variant.
    /// - **Enable personalization features**: Update an option (for example,
    /// "Engraving text") to let customers customize their purchase.
    /// - **Offer seasonal or limited edition products**: Update a value
    /// (for example, "Holiday red") on an existing option to support limited-time or seasonal variants.
    /// - **Integrate with apps that manage product configuration**: Allow third-party apps to update options, like
    /// "Bundle size", when customers select or customize
    /// [product bundles](https://shopify.dev/docs/apps/build/product-merchandising/bundles).
    /// - **Link options to metafields**: Associate a product option with a custom
    /// [metafield](https://shopify.dev/docs/apps/build/custom-data), like "Fabric code", for
    /// richer integrations with other systems or apps.
    /// > Note:
    /// > The `productOptionUpdate` mutation enforces strict data integrity for product options and variants.
    /// All option positions must be sequential, and every option should be used by at least one variant.
    /// After you update a product option, you can further manage a product's configuration using related mutations:
    /// - [`productOptionsCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsCreate)
    /// - [`productOptionsDelete`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsDelete)
    /// - [`productOptionsReorder`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsReorder)
    /// - [`productVariantsBulkCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkCreate)
    /// - [`productVariantsBulkUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkUpdate)
    /// - [`productSet`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productSet)
    /// Learn more about the [product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model)
    /// and [adding product data](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/add-data).
    /// </summary>
    [JsonPropertyName("productOptionUpdate")]
    public ProductOptionUpdatePayload? productOptionUpdate { get; set; } = null;

    /// <summary>
    /// Publishes a product. Products that are sold exclusively on subscription
    /// (`requiresSellingPlan: true`) can only be published on online stores.
    /// </summary>
    [JsonPropertyName("productPublish")]
    [Obsolete("Use `publishablePublish` instead.")]
    public ProductPublishPayload? productPublish { get; set; } = null;

    /// <summary>
    /// Asynchronously reorders the media attached to a product.
    /// </summary>
    [JsonPropertyName("productReorderMedia")]
    public ProductReorderMediaPayload? productReorderMedia { get; set; } = null;

    /// <summary>
    /// Performs multiple operations to create or update products in a single request.
    /// Use the `productSet` mutation to sync information from an external data source into Shopify, manage large
    /// product catalogs, and perform batch updates. The mutation is helpful for bulk product management, including price
    /// adjustments, inventory updates, and product lifecycle management.
    /// The behavior of `productSet` depends on the type of field it's modifying:
    /// - **For list fields**: Creates new entries, updates existing entries, and deletes existing entries
    /// that aren't included in the mutation's input. Common examples of list fields include
    /// [`collections`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productSet#arguments-input.fields.collections),
    /// [`metafields`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productSet#arguments-input.fields.metafields),
    /// and [`variants`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productSet#arguments-input.fields.variants).
    /// - **For all other field types**: Updates only the included fields. Any omitted fields will remain unchanged.
    /// > Note:
    /// > By default, stores have a limit of 100 product variants for each product. You can create a development store and
    /// > [enable the **Extended Variants** developer preview](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/migrate-and-test#create-a-development-store-that-allows-2-048-variants-per-product)
    /// > to create or update a maximum of 2,048 product variants in a single operation.
    /// You can run `productSet` in one of the following modes:
    /// - **Synchronously**: Returns the updated product in the response.
    /// - **Asynchronously**: Returns a [`ProductSetOperation`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductSetOperation) object.
    /// Use the [`productOperation`](https://shopify.dev/api/admin-graphql/latest/queries/productOperation) query to check the status of the operation and
    /// retrieve details of the updated product and its product variants.
    /// If you need to only manage product variants, then use one of the following mutations:
    /// - [`productVariantsBulkCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkCreate)
    /// - [`productVariantsBulkUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkUpdate)
    /// - [`productVariantsBulkDelete`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkDelete)
    /// If you need to only manage product options, then use one of the following mutations:
    /// - [`productOptionsCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsCreate)
    /// - [`productOptionUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionUpdate)
    /// - [`productOptionsReorder`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsReorder)
    /// - [`productOptionsDelete`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsDelete)
    /// Learn more about [syncing product data from an external source](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/sync-data).
    /// </summary>
    [JsonPropertyName("productSet")]
    public ProductSetPayload? productSet { get; set; } = null;

    /// <summary>
    /// Unpublishes a product.
    /// </summary>
    [JsonPropertyName("productUnpublish")]
    [Obsolete("Use `publishableUnpublish` instead.")]
    public ProductUnpublishPayload? productUnpublish { get; set; } = null;

    /// <summary>
    /// Updates a [product](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
    /// with attributes such as title, description, vendor, and media.
    /// The `productUpdate` mutation helps you modify many products at once, avoiding the tedious or time-consuming
    /// process of updating them one by one in the Shopify admin. Common examples including updating
    /// product details like status or tags.
    /// The `productUpdate` mutation doesn't support updating
    /// [product variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant).
    /// To update multiple product variants for a single product and manage prices, use the
    /// [`productVariantsBulkUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkUpdate)
    /// mutation.
    /// > Note:
    /// > The `productUpdate` mutation has a [throttle](https://shopify.dev/docs/api/usage/rate-limits#resource-based-rate-limits)
    /// > that takes effect when a store has 50,000 product variants. After this threshold is reached, no more than
    /// > 1,000 new product variants can be updated per day.
    /// After updating a product, you can make additional changes using one of the following mutations:
    /// - [`productSet`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productSet):
    /// Used to perform multiple operations on products, such as creating or modifying product options and variants.
    /// - [`publishablePublish`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/publishablePublish):
    /// Used to publish the product and make it available to customers, if the product is currently unpublished.
    /// Learn more about the [product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model)
    /// and [adding product data](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/add-data).
    /// </summary>
    [JsonPropertyName("productUpdate")]
    public ProductUpdatePayload? productUpdate { get; set; } = null;

    /// <summary>
    /// Updates media for a product.
    /// </summary>
    [JsonPropertyName("productUpdateMedia")]
    [Obsolete("Use `fileUpdate` instead.")]
    public ProductUpdateMediaPayload? productUpdateMedia { get; set; } = null;

    /// <summary>
    /// Appends media from a product to variants of the product.
    /// </summary>
    [JsonPropertyName("productVariantAppendMedia")]
    public ProductVariantAppendMediaPayload? productVariantAppendMedia { get; set; } = null;

    /// <summary>
    /// Detaches media from product variants.
    /// </summary>
    [JsonPropertyName("productVariantDetachMedia")]
    public ProductVariantDetachMediaPayload? productVariantDetachMedia { get; set; } = null;

    /// <summary>
    /// Adds multiple selling plan groups to a product variant.
    /// </summary>
    [JsonPropertyName("productVariantJoinSellingPlanGroups")]
    public ProductVariantJoinSellingPlanGroupsPayload? productVariantJoinSellingPlanGroups { get; set; } = null;

    /// <summary>
    /// Remove multiple groups from a product variant.
    /// </summary>
    [JsonPropertyName("productVariantLeaveSellingPlanGroups")]
    public ProductVariantLeaveSellingPlanGroupsPayload? productVariantLeaveSellingPlanGroups { get; set; } = null;

    /// <summary>
    /// Creates new bundles, updates existing bundles, and removes bundle components for one or multiple bundles.
    /// </summary>
    [JsonPropertyName("productVariantRelationshipBulkUpdate")]
    public ProductVariantRelationshipBulkUpdatePayload? productVariantRelationshipBulkUpdate { get; set; } = null;

    /// <summary>
    /// Creates multiple [product variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant)
    /// for a single [product](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) in one operation.
    /// You can run this mutation directly or as part of a [bulk
    /// operation](https://shopify.dev/docs/api/usage/bulk-operations/imports)
    /// for large-scale catalog updates.
    /// Use the `productVariantsBulkCreate` mutation to efficiently add new product variants—such as different sizes,
    /// colors, or materials—to an existing product. The mutation is helpful if you need to add product variants in bulk,
    /// such as importing from an external system.
    /// The mutation supports:
    /// - Creating variants with custom options and values
    /// - Associating media (for example, images, videos, and 3D models) with the product or its variants
    /// - Handling complex product configurations
    /// > Note:
    /// > By default, stores have a limit of 100 product variants for each product. You can create a development store and
    /// > [enable the **Extended Variants** developer preview](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/migrate-and-test#create-a-development-store-that-allows-2-048-variants-per-product)
    /// > to create a maximum of 2,048 product variants in a single operation.
    /// After creating variants, you can make additional changes using one of the following mutations:
    /// - [`productVariantsBulkUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productVariantsBulkUpdate):
    /// Updates multiple product variants for a single product in one operation.
    /// - [`productSet`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productSet):
    /// Used to perform multiple operations on products, such as creating or modifying product options and variants.
    /// You can also specifically manage product options through related mutations:
    /// - [`productOptionsCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsCreate)
    /// - [`productOptionUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionUpdate)
    /// - [`productOptionsReorder`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsReorder)
    /// - [`productOptionsDelete`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsDelete)
    /// Learn more about the [product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model)
    /// and [adding product data](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/add-data).
    /// </summary>
    [JsonPropertyName("productVariantsBulkCreate")]
    public ProductVariantsBulkCreatePayload? productVariantsBulkCreate { get; set; } = null;

    /// <summary>
    /// Deletes multiple variants in a single product. This mutation can be called directly or via the bulkOperation.
    /// </summary>
    [JsonPropertyName("productVariantsBulkDelete")]
    public ProductVariantsBulkDeletePayload? productVariantsBulkDelete { get; set; } = null;

    /// <summary>
    /// Reorders multiple variants in a single product. This mutation can be called directly or via the bulkOperation.
    /// </summary>
    [JsonPropertyName("productVariantsBulkReorder")]
    public ProductVariantsBulkReorderPayload? productVariantsBulkReorder { get; set; } = null;

    /// <summary>
    /// Updates multiple [product variants](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant)
    /// for a single [product](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) in one operation.
    /// You can run this mutation directly or as part of a [bulk
    /// operation](https://shopify.dev/docs/api/usage/bulk-operations/imports)
    /// for large-scale catalog updates.
    /// Use the `productVariantsBulkUpdate` mutation to efficiently modify product variants—such as different sizes,
    /// colors, or materials—associated with an existing product. The mutation is helpful if you need to update a
    /// product's variants in bulk, such as importing from an external system.
    /// The mutation supports:
    /// - Updating variants with custom options and values
    /// - Associating media (for example, images, videos, and 3D models) with the product or its variants
    /// - Handling complex product configurations
    /// > Note:
    /// > By default, stores have a limit of 100 product variants for each product. You can create a development store and
    /// > [enable the **Extended Variants** developer preview](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/migrate-and-test#create-a-development-store-that-allows-2-048-variants-per-product)
    /// > to update a maximum of 2,048 product variants in a single operation.
    /// After creating variants, you can make additional changes using the
    /// [`productSet`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productSet) mutation,
    /// which is used to perform multiple operations on products, such as creating or modifying product options and variants.
    /// You can also specifically manage product options through related mutations:
    /// - [`productOptionsCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsCreate)
    /// - [`productOptionUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionUpdate)
    /// - [`productOptionsReorder`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsReorder)
    /// - [`productOptionsDelete`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productOptionsDelete)
    /// Learn more about the [product model](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model)
    /// and [adding product data](https://shopify.dev/docs/apps/build/graphql/migrate/new-product-model/add-data).
    /// </summary>
    [JsonPropertyName("productVariantsBulkUpdate")]
    public ProductVariantsBulkUpdatePayload? productVariantsBulkUpdate { get; set; } = null;

    /// <summary>
    /// Creates a publication.
    /// </summary>
    [JsonPropertyName("publicationCreate")]
    public PublicationCreatePayload? publicationCreate { get; set; } = null;

    /// <summary>
    /// Deletes a publication.
    /// </summary>
    [JsonPropertyName("publicationDelete")]
    public PublicationDeletePayload? publicationDelete { get; set; } = null;

    /// <summary>
    /// Updates a publication.
    /// </summary>
    [JsonPropertyName("publicationUpdate")]
    public PublicationUpdatePayload? publicationUpdate { get; set; } = null;

    /// <summary>
    /// Publishes a resource to a channel. If the resource is a product, then it's
    /// visible in the channel only if the product status is `active`. Products that
    /// are sold exclusively on subscription (`requiresSellingPlan: true`) can be
    /// published only on online stores.
    /// </summary>
    [JsonPropertyName("publishablePublish")]
    public PublishablePublishPayload? publishablePublish { get; set; } = null;

    /// <summary>
    /// Publishes a resource to current channel. If the resource is a product, then
    /// it's visible in the channel only if the product status is `active`. Products
    /// that are sold exclusively on subscription (`requiresSellingPlan: true`) can be
    /// published only on online stores.
    /// </summary>
    [JsonPropertyName("publishablePublishToCurrentChannel")]
    public PublishablePublishToCurrentChannelPayload? publishablePublishToCurrentChannel { get; set; } = null;

    /// <summary>
    /// Unpublishes a resource from a channel. If the resource is a product, then it's
    /// visible in the channel only if the product status is `active`.
    /// </summary>
    [JsonPropertyName("publishableUnpublish")]
    public PublishableUnpublishPayload? publishableUnpublish { get; set; } = null;

    /// <summary>
    /// Unpublishes a resource from the current channel. If the resource is a product,
    /// then it's visible in the channel only if the product status is `active`.
    /// </summary>
    [JsonPropertyName("publishableUnpublishToCurrentChannel")]
    public PublishableUnpublishToCurrentChannelPayload? publishableUnpublishToCurrentChannel { get; set; } = null;

    /// <summary>
    /// Updates the server pixel to connect to a Google PubSub endpoint.
    /// Running this mutation deletes any previous subscriptions for the server pixel.
    /// </summary>
    [JsonPropertyName("pubSubServerPixelUpdate")]
    public PubSubServerPixelUpdatePayload? pubSubServerPixelUpdate { get; set; } = null;

    /// <summary>
    /// Creates a new Google Cloud Pub/Sub webhook subscription.
    /// Building an app? If you only use app-specific webhooks, you won't need this.
    /// App-specific webhook subscriptions specified in your `shopify.app.toml` may be
    /// easier. They are automatically kept up to date by Shopify & require less
    /// maintenance. Please read [About managing webhook
    /// subscriptions](https://shopify.dev/docs/apps/build/webhooks/subscribe).
    /// </summary>
    [JsonPropertyName("pubSubWebhookSubscriptionCreate")]
    [Obsolete("Use `webhookSubscriptionCreate` instead.")]
    public PubSubWebhookSubscriptionCreatePayload? pubSubWebhookSubscriptionCreate { get; set; } = null;

    /// <summary>
    /// Updates a Google Cloud Pub/Sub webhook subscription.
    /// Building an app? If you only use app-specific webhooks, you won't need this.
    /// App-specific webhook subscriptions specified in your `shopify.app.toml` may be
    /// easier. They are automatically kept up to date by Shopify & require less
    /// maintenance. Please read [About managing webhook
    /// subscriptions](https://shopify.dev/docs/apps/build/webhooks/subscribe).
    /// </summary>
    [JsonPropertyName("pubSubWebhookSubscriptionUpdate")]
    [Obsolete("Use `webhookSubscriptionUpdate` instead.")]
    public PubSubWebhookSubscriptionUpdatePayload? pubSubWebhookSubscriptionUpdate { get; set; } = null;

    /// <summary>
    /// Updates quantity pricing on a price list. You can use the
    /// `quantityPricingByVariantUpdate` mutation to set fixed prices, quantity rules,
    /// and quantity price breaks. This mutation does not allow partial successes. If
    /// any of the requested resources fail to update, none of the requested resources
    /// will be updated. Delete operations are executed before create operations.
    /// </summary>
    [JsonPropertyName("quantityPricingByVariantUpdate")]
    public QuantityPricingByVariantUpdatePayload? quantityPricingByVariantUpdate { get; set; } = null;

    /// <summary>
    /// Creates or updates existing quantity rules on a price list.
    /// You can use the `quantityRulesAdd` mutation to set order level minimums,
    /// maximumums and increments for specific product variants.
    /// </summary>
    [JsonPropertyName("quantityRulesAdd")]
    public QuantityRulesAddPayload? quantityRulesAdd { get; set; } = null;

    /// <summary>
    /// Deletes specific quantity rules from a price list using a product variant ID.
    /// You can use the `quantityRulesDelete` mutation to delete a set of quantity rules from a price list.
    /// </summary>
    [JsonPropertyName("quantityRulesDelete")]
    public QuantityRulesDeletePayload? quantityRulesDelete { get; set; } = null;

    /// <summary>
    /// Creates a refund for an order, allowing you to process returns and issue payments back to customers.
    /// Use the `refundCreate` mutation to programmatically process refunds in scenarios where you need to
    /// return money to customers, such as when handling returns, processing chargebacks, or correcting
    /// order errors.
    /// The `refundCreate` mutation supports various refund scenarios:
    /// - Refunding line items with optional restocking
    /// - Refunding shipping costs
    /// - Refunding duties and import taxes
    /// - Refunding additional fees
    /// - Processing refunds through different payment methods
    /// - Issuing store credit refunds (when enabled)
    /// You can create both full and partial refunds, and optionally allow over-refunding in specific
    /// cases.
    /// After creating a refund, you can track its status and details through the order's
    /// [`refunds`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order#field-Order.fields.refunds)
    /// field. The refund is associated with the order and can be used for reporting and reconciliation purposes.
    /// Learn more about
    /// [managing returns](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/build-return-management)
    /// and [refunding duties](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/view-and-refund-duties).
    /// > Note:
    /// > The refunding behavior of the `refundCreate` mutation is similar to the
    /// [`refundReturn`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/returnRefund)
    /// mutation. The key difference is that the `refundCreate` mutation lets you to specify restocking behavior
    /// for line items, whereas the `returnRefund` mutation focuses solely on handling the financial refund without
    /// any restocking input.
    /// </summary>
    [JsonPropertyName("refundCreate")]
    public RefundCreatePayload? refundCreate { get; set; } = null;

    /// <summary>
    /// Removes return and/or exchange lines from a return.
    /// </summary>
    [JsonPropertyName("removeFromReturn")]
    public RemoveFromReturnPayload? removeFromReturn { get; set; } = null;

    /// <summary>
    /// Approves a customer's return request.
    /// If this mutation is successful, then the `Return.status` field of the
    /// approved return is set to `OPEN`.
    /// </summary>
    [JsonPropertyName("returnApproveRequest")]
    public ReturnApproveRequestPayload? returnApproveRequest { get; set; } = null;

    /// <summary>
    /// Cancels a return and restores the items back to being fulfilled.
    /// Canceling a return is only available before any work has been done
    /// on the return (such as an inspection or refund).
    /// </summary>
    [JsonPropertyName("returnCancel")]
    public ReturnCancelPayload? returnCancel { get; set; } = null;

    /// <summary>
    /// Indicates a return is complete, either when a refund has been made and items restocked,
    /// or simply when it has been marked as returned in the system.
    /// </summary>
    [JsonPropertyName("returnClose")]
    public ReturnClosePayload? returnClose { get; set; } = null;

    /// <summary>
    /// Creates a return from an existing order that has at least one fulfilled
    /// [line item](https://shopify.dev/docs/api/admin-graphql/latest/objects/LineItem)
    /// that hasn't yet been refunded. If you create a return on an archived order, then the order is automatically
    /// unarchived.
    /// Use the `returnCreate` mutation when your workflow involves
    /// [approving](https://shopify.dev/docs/api/admin-graphql/latest/mutations/returnApproveRequest) or
    /// [declining](https://shopify.dev/docs/api/admin-graphql/latest/mutations/returnDeclineRequest) requested returns
    /// outside of the Shopify platform.
    /// The `returnCreate` mutation performs the following actions:
    /// - Creates a return in the `OPEN` state, and assumes that the return request from the customer has already been
    /// approved
    /// - Creates a [reverse fulfillment order](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/manage-reverse-fulfillment-orders),
    /// and enables you to create a [reverse delivery](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/manage-reverse-deliveries)
    /// for the reverse fulfillment order
    /// - Creates a sales agreement with a `RETURN` reason, which links to all sales created for the return or exchange
    /// - Generates sales records that reverse the sales records for the items being returned
    /// - Generates sales records for any exchange line items
    /// After you've created a return, use the
    /// [`return`](https://shopify.dev/docs/api/admin-graphql/latest/queries/return) query to retrieve the
    /// return by its ID. Learn more about providing a
    /// [return management workflow](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/build-return-management)
    /// for merchants.
    /// </summary>
    [JsonPropertyName("returnCreate")]
    public ReturnCreatePayload? returnCreate { get; set; } = null;

    /// <summary>
    /// Declines a return on an order.
    /// When a return is declined, each `ReturnLineItem.fulfillmentLineItem` can be associated to a new return.
    /// Use the `ReturnCreate` or `ReturnRequest` mutation to initiate a new return.
    /// </summary>
    [JsonPropertyName("returnDeclineRequest")]
    public ReturnDeclineRequestPayload? returnDeclineRequest { get; set; } = null;

    /// <summary>
    /// Removes return lines from a return.
    /// </summary>
    [JsonPropertyName("returnLineItemRemoveFromReturn")]
    [Obsolete("Use `removeFromReturn` instead.")]
    public ReturnLineItemRemoveFromReturnPayload? returnLineItemRemoveFromReturn { get; set; } = null;

    /// <summary>
    /// Process a return.
    /// </summary>
    [JsonPropertyName("returnProcess")]
    public ReturnProcessPayload? returnProcess { get; set; } = null;

    /// <summary>
    /// Refunds a return when its status is `OPEN` or `CLOSED` and associates it with the related return request.
    /// </summary>
    [JsonPropertyName("returnRefund")]
    [Obsolete("Use `returnProcess` instead.")]
    public ReturnRefundPayload? returnRefund { get; set; } = null;

    /// <summary>
    /// Reopens a closed return.
    /// </summary>
    [JsonPropertyName("returnReopen")]
    public ReturnReopenPayload? returnReopen { get; set; } = null;

    /// <summary>
    /// A customer's return request that hasn't been approved or declined.
    /// This mutation sets the value of the `Return.status` field to `REQUESTED`.
    /// To create a return that has the `Return.status` field set to `OPEN`, use the `returnCreate` mutation.
    /// </summary>
    [JsonPropertyName("returnRequest")]
    public ReturnRequestPayload? returnRequest { get; set; } = null;

    /// <summary>
    /// Creates a new reverse delivery with associated external shipping information.
    /// </summary>
    [JsonPropertyName("reverseDeliveryCreateWithShipping")]
    public ReverseDeliveryCreateWithShippingPayload? reverseDeliveryCreateWithShipping { get; set; } = null;

    /// <summary>
    /// Updates a reverse delivery with associated external shipping information.
    /// </summary>
    [JsonPropertyName("reverseDeliveryShippingUpdate")]
    public ReverseDeliveryShippingUpdatePayload? reverseDeliveryShippingUpdate { get; set; } = null;

    /// <summary>
    /// Disposes reverse fulfillment order line items.
    /// </summary>
    [JsonPropertyName("reverseFulfillmentOrderDispose")]
    public ReverseFulfillmentOrderDisposePayload? reverseFulfillmentOrderDispose { get; set; } = null;

    /// <summary>
    /// Creates a saved search.
    /// </summary>
    [JsonPropertyName("savedSearchCreate")]
    public SavedSearchCreatePayload? savedSearchCreate { get; set; } = null;

    /// <summary>
    /// Delete a saved search.
    /// </summary>
    [JsonPropertyName("savedSearchDelete")]
    public SavedSearchDeletePayload? savedSearchDelete { get; set; } = null;

    /// <summary>
    /// Updates a saved search.
    /// </summary>
    [JsonPropertyName("savedSearchUpdate")]
    public SavedSearchUpdatePayload? savedSearchUpdate { get; set; } = null;

    /// <summary>
    /// <div class="note"><h4>Theme app extensions</h4>
    ///   <p>If your app integrates with a Shopify theme and you plan to submit it to
    /// the Shopify App Store, you must use theme app extensions instead of Script
    /// tags. Script tags can only be used with vintage themes. <a 
    ///href="/apps/online-store#what-integration-method-should-i-use" 
    ///target="_blank">Learn more</a>.</p></div>
    /// <div class="note"><h4>Script tag deprecation</h4>
    ///   <p>Script tags will be sunset for the <b>Order status</b> page on August 28, 2025. <a href="https://www.shopify.com/plus/upgrading-to-checkout-extensibility">Upgrade
    /// to Checkout Extensibility</a> before this date. <a 
    ///href="/docs/api/liquid/objects#script">Shopify Scripts</a> will continue to
    /// work alongside Checkout Extensibility until August 28, 2025.</p></div>
    /// Creates a new script tag.
    /// </summary>
    [JsonPropertyName("scriptTagCreate")]
    public ScriptTagCreatePayload? scriptTagCreate { get; set; } = null;

    /// <summary>
    /// <div class="note"><h4>Theme app extensions</h4>
    ///   <p>If your app integrates with a Shopify theme and you plan to submit it to
    /// the Shopify App Store, you must use theme app extensions instead of Script
    /// tags. Script tags can only be used with vintage themes. <a 
    ///href="/apps/online-store#what-integration-method-should-i-use" 
    ///target="_blank">Learn more</a>.</p></div>
    /// <div class="note"><h4>Script tag deprecation</h4>
    ///   <p>Script tags will be sunset for the <b>Order status</b> page on August 28, 2025. <a href="https://www.shopify.com/plus/upgrading-to-checkout-extensibility">Upgrade
    /// to Checkout Extensibility</a> before this date. <a 
    ///href="/docs/api/liquid/objects#script">Shopify Scripts</a> will continue to
    /// work alongside Checkout Extensibility until August 28, 2025.</p></div>
    /// Deletes a script tag.
    /// </summary>
    [JsonPropertyName("scriptTagDelete")]
    public ScriptTagDeletePayload? scriptTagDelete { get; set; } = null;

    /// <summary>
    /// <div class="note"><h4>Theme app extensions</h4>
    ///   <p>If your app integrates with a Shopify theme and you plan to submit it to
    /// the Shopify App Store, you must use theme app extensions instead of Script
    /// tags. Script tags can only be used with vintage themes. <a 
    ///href="/apps/online-store#what-integration-method-should-i-use" 
    ///target="_blank">Learn more</a>.</p></div>
    /// <div class="note"><h4>Script tag deprecation</h4>
    ///   <p>Script tags will be sunset for the <b>Order status</b> page on August 28, 2025. <a href="https://www.shopify.com/plus/upgrading-to-checkout-extensibility">Upgrade
    /// to Checkout Extensibility</a> before this date. <a 
    ///href="/docs/api/liquid/objects#script">Shopify Scripts</a> will continue to
    /// work alongside Checkout Extensibility until August 28, 2025.</p></div>
    /// Updates a script tag.
    /// </summary>
    [JsonPropertyName("scriptTagUpdate")]
    public ScriptTagUpdatePayload? scriptTagUpdate { get; set; } = null;

    /// <summary>
    /// Creates a segment.
    /// </summary>
    [JsonPropertyName("segmentCreate")]
    public SegmentCreatePayload? segmentCreate { get; set; } = null;

    /// <summary>
    /// Deletes a segment.
    /// </summary>
    [JsonPropertyName("segmentDelete")]
    public SegmentDeletePayload? segmentDelete { get; set; } = null;

    /// <summary>
    /// Updates a segment.
    /// </summary>
    [JsonPropertyName("segmentUpdate")]
    public SegmentUpdatePayload? segmentUpdate { get; set; } = null;

    /// <summary>
    /// Adds multiple products to a selling plan group.
    /// </summary>
    [JsonPropertyName("sellingPlanGroupAddProducts")]
    public SellingPlanGroupAddProductsPayload? sellingPlanGroupAddProducts { get; set; } = null;

    /// <summary>
    /// Adds multiple product variants to a selling plan group.
    /// </summary>
    [JsonPropertyName("sellingPlanGroupAddProductVariants")]
    public SellingPlanGroupAddProductVariantsPayload? sellingPlanGroupAddProductVariants { get; set; } = null;

    /// <summary>
    /// Creates a Selling Plan Group.
    /// </summary>
    [JsonPropertyName("sellingPlanGroupCreate")]
    public SellingPlanGroupCreatePayload? sellingPlanGroupCreate { get; set; } = null;

    /// <summary>
    /// Delete a Selling Plan Group. This does not affect subscription contracts.
    /// </summary>
    [JsonPropertyName("sellingPlanGroupDelete")]
    public SellingPlanGroupDeletePayload? sellingPlanGroupDelete { get; set; } = null;

    /// <summary>
    /// Removes multiple products from a selling plan group.
    /// </summary>
    [JsonPropertyName("sellingPlanGroupRemoveProducts")]
    public SellingPlanGroupRemoveProductsPayload? sellingPlanGroupRemoveProducts { get; set; } = null;

    /// <summary>
    /// Removes multiple product variants from a selling plan group.
    /// </summary>
    [JsonPropertyName("sellingPlanGroupRemoveProductVariants")]
    public SellingPlanGroupRemoveProductVariantsPayload? sellingPlanGroupRemoveProductVariants { get; set; } = null;

    /// <summary>
    /// Update a Selling Plan Group.
    /// </summary>
    [JsonPropertyName("sellingPlanGroupUpdate")]
    public SellingPlanGroupUpdatePayload? sellingPlanGroupUpdate { get; set; } = null;

    /// <summary>
    /// Creates a new unconfigured server pixel. A single server pixel can exist for
    /// an app and shop combination. If you call this mutation when a server pixel
    /// already exists, then an error will return.
    /// </summary>
    [JsonPropertyName("serverPixelCreate")]
    public ServerPixelCreatePayload? serverPixelCreate { get; set; } = null;

    /// <summary>
    /// Deletes the Server Pixel associated with the current app & shop.
    /// </summary>
    [JsonPropertyName("serverPixelDelete")]
    public ServerPixelDeletePayload? serverPixelDelete { get; set; } = null;

    /// <summary>
    /// Deletes a shipping package.
    /// </summary>
    [JsonPropertyName("shippingPackageDelete")]
    public ShippingPackageDeletePayload? shippingPackageDelete { get; set; } = null;

    /// <summary>
    /// Set a shipping package as the default.
    /// The default shipping package is the one used to calculate shipping costs on checkout.
    /// </summary>
    [JsonPropertyName("shippingPackageMakeDefault")]
    public ShippingPackageMakeDefaultPayload? shippingPackageMakeDefault { get; set; } = null;

    /// <summary>
    /// Updates a shipping package.
    /// </summary>
    [JsonPropertyName("shippingPackageUpdate")]
    public ShippingPackageUpdatePayload? shippingPackageUpdate { get; set; } = null;

    /// <summary>
    /// Creates an alternate currency payout for a Shopify Payments account.
    /// </summary>
    [JsonPropertyName("shopifyPaymentsPayoutAlternateCurrencyCreate")]
    public ShopifyPaymentsPayoutAlternateCurrencyCreatePayload? shopifyPaymentsPayoutAlternateCurrencyCreate { get; set; } = null;

    /// <summary>
    /// Deletes a locale for a shop. This also deletes all translations of this locale.
    /// </summary>
    [JsonPropertyName("shopLocaleDisable")]
    public ShopLocaleDisablePayload? shopLocaleDisable { get; set; } = null;

    /// <summary>
    /// Adds a locale for a shop. The newly added locale is in the unpublished state.
    /// </summary>
    [JsonPropertyName("shopLocaleEnable")]
    public ShopLocaleEnablePayload? shopLocaleEnable { get; set; } = null;

    /// <summary>
    /// Updates a locale for a shop.
    /// </summary>
    [JsonPropertyName("shopLocaleUpdate")]
    public ShopLocaleUpdatePayload? shopLocaleUpdate { get; set; } = null;

    /// <summary>
    /// Updates a shop policy.
    /// </summary>
    [JsonPropertyName("shopPolicyUpdate")]
    public ShopPolicyUpdatePayload? shopPolicyUpdate { get; set; } = null;

    /// <summary>
    /// The `ResourceFeedback` object lets your app report the status of shops and their resources. For example, if
    /// your app is a marketplace channel, then you can use resource feedback to alert
    /// merchants that they need to connect their marketplace account by signing in.
    /// Resource feedback notifications are displayed to the merchant on the home
    /// screen of their Shopify admin, and in the product details view for any
    /// products that are published to your app.
    /// This resource should be used only in cases where you're describing steps that
    /// a merchant is required to complete. If your app offers optional or promotional
    /// set-up steps, or if it makes recommendations, then don't use resource feedback
    /// to let merchants know about them.
    /// ## Sending feedback on a shop
    /// You can send resource feedback on a shop to let the merchant know what steps
    /// they need to take to make sure that your app is set up correctly. Feedback can
    /// have one of two states: `requires_action` or `success`. You need to send a
    /// `requires_action` feedback request for each step that the merchant is required to complete.
    /// If there are multiple set-up steps that require merchant action, then send
    /// feedback with a state of `requires_action` as merchants complete prior steps.
    /// And to remove the feedback message from the Shopify admin, send a `success`
    /// feedback request.
    /// #### Important
    /// Sending feedback replaces previously sent feedback for the shop. Send a new
    /// `shopResourceFeedbackCreate` mutation to push the latest state of a shop or
    /// its resources to Shopify.
    /// </summary>
    [JsonPropertyName("shopResourceFeedbackCreate")]
    public ShopResourceFeedbackCreatePayload? shopResourceFeedbackCreate { get; set; } = null;

    /// <summary>
    /// Creates staged upload targets for file uploads such as images, videos, and 3D models.
    /// Use the `stagedUploadsCreate` mutation instead of direct file creation mutations when:
    /// - **Uploading large files**: Files over a few MB benefit from staged uploads for better reliability
    /// - **Uploading media files**: Videos, 3D models, and high-resolution images
    /// - **Bulk importing**: CSV files, product catalogs, or other bulk data
    /// - **Using external file sources**: When files are stored remotely and need to be transferred to Shopify
    /// For small files or simple use cases, you can use [`fileCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/fileCreate)
    /// directly by providing the file content inline.
    /// The `stagedUploadsCreate` mutation is the first step in Shopify's secure two-step upload process:
    /// **Step 1: Create staged upload targets** (this mutation)
    /// - Generate secure, temporary upload URLs for your files.
    /// - Receive authentication parameters for the upload.
    /// **Step 2: Upload files and create assets**
    /// - Upload your files directly to the provided URLs using the authentication parameters.
    /// - Use the returned `resourceUrl` as the `originalSource` in subsequent mutations like `fileCreate`.
    /// This approach provides better performance for large files, handles network interruptions gracefully,
    /// and ensures secure file transfers to Shopify's storage infrastructure.
    /// > Note:
    /// > File size is required when uploading
    /// > [`VIDEO`](https://shopify.dev/docs/api/admin-graphql/latest/enums/StagedUploadTargetGenerateUploadResource#enums-VIDEO) or
    /// > [`MODEL_3D`](https://shopify.dev/docs/api/admin-graphql/latest/enums/StagedUploadTargetGenerateUploadResource#enums-MODEL_3D)
    /// > resources.
    /// After creating staged upload targets, complete the process by:
    /// 1. **Uploading files**: Send your files to the returned [`url`](https://shopify.dev/docs/api/admin-graphql/latest/objects/StagedMediaUploadTarget#field-StagedMediaUploadTarget.fields.url)
    /// using the provided
    /// [`parameters`](https://shopify.dev/docs/api/admin-graphql/latest/objects/StagedMediaUploadTarget#field-StagedMediaUploadTarget.fields.parameters)
    /// for authentication
    /// 2. **Creating file assets**: Use the [`resourceUrl`](https://shopify.dev/docs/api/admin-graphql/latest/objects/StagedMediaUploadTarget#field-StagedMediaUploadTarget.fields.resourceUrl)
    /// as the `originalSource` in mutations such as:
    ///    - [`fileCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/fileCreate):
    ///      Creates file assets from staged uploads
    ///    - [`productUpdate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/productUpdate):
    ///      Updates products with new media from staged uploads
    /// Learn more about [uploading media to Shopify](https://shopify.dev/apps/online-store/media/products).
    /// </summary>
    [JsonPropertyName("stagedUploadsCreate")]
    public StagedUploadsCreatePayload? stagedUploadsCreate { get; set; } = null;

    /// <summary>
    /// Generates the URL and signed paramaters needed to upload an asset to Shopify.
    /// </summary>
    [JsonPropertyName("stagedUploadTargetGenerate")]
    [Obsolete("Use `stagedUploadsCreate` instead.")]
    public StagedUploadTargetGeneratePayload? stagedUploadTargetGenerate { get; set; } = null;

    /// <summary>
    /// Uploads multiple images.
    /// </summary>
    [JsonPropertyName("stagedUploadTargetsGenerate")]
    [Obsolete("Use `stagedUploadsCreate` instead.")]
    public StagedUploadTargetsGeneratePayload? stagedUploadTargetsGenerate { get; set; } = null;

    /// <summary>
    /// Activates the specified standard metafield definition from its template.
    /// Refer to the [list of standard metafield definition templates](https://shopify.dev/apps/metafields/definitions/standard-definitions).
    /// </summary>
    [JsonPropertyName("standardMetafieldDefinitionEnable")]
    public StandardMetafieldDefinitionEnablePayload? standardMetafieldDefinitionEnable { get; set; } = null;

    /// <summary>
    /// Enables the specified standard metaobject definition from its template.
    /// </summary>
    [JsonPropertyName("standardMetaobjectDefinitionEnable")]
    public StandardMetaobjectDefinitionEnablePayload? standardMetaobjectDefinitionEnable { get; set; } = null;

    /// <summary>
    /// Creates a credit transaction that increases the store credit account balance by the given amount.
    /// This operation will create an account if one does not already exist.
    /// A store credit account owner can hold multiple accounts each with a different currency.
    /// Use the most appropriate currency for the given store credit account owner.
    /// </summary>
    [JsonPropertyName("storeCreditAccountCredit")]
    public StoreCreditAccountCreditPayload? storeCreditAccountCredit { get; set; } = null;

    /// <summary>
    /// Creates a debit transaction that decreases the store credit account balance by the given amount.
    /// </summary>
    [JsonPropertyName("storeCreditAccountDebit")]
    public StoreCreditAccountDebitPayload? storeCreditAccountDebit { get; set; } = null;

    /// <summary>
    /// Creates a storefront access token for use with the [Storefront API](https://shopify.dev/docs/api/storefront).
    /// An app can have a maximum of 100 active storefront access tokens for each shop.
    /// [Get started with the Storefront API](https://shopify.dev/docs/storefronts/headless/building-with-the-storefront-api/getting-started).
    /// </summary>
    [JsonPropertyName("storefrontAccessTokenCreate")]
    public StorefrontAccessTokenCreatePayload? storefrontAccessTokenCreate { get; set; } = null;

    /// <summary>
    /// Deletes a storefront access token.
    /// </summary>
    [JsonPropertyName("storefrontAccessTokenDelete")]
    public StorefrontAccessTokenDeletePayload? storefrontAccessTokenDelete { get; set; } = null;

    /// <summary>
    /// Creates a new subscription billing attempt. For more information, refer to
    /// [Create a subscription contract](https://shopify.dev/docs/apps/selling-strategies/subscriptions/contracts/create#step-4-create-a-billing-attempt).
    /// </summary>
    [JsonPropertyName("subscriptionBillingAttemptCreate")]
    public SubscriptionBillingAttemptCreatePayload? subscriptionBillingAttemptCreate { get; set; } = null;

    /// <summary>
    /// Asynchronously queries and charges all subscription billing cycles whose [billingAttemptExpectedDate](https://shopify.dev/api/admin-graphql/latest/objects/SubscriptionBillingCycle#field-billingattemptexpecteddate)
    /// values fall within a specified date range and meet additional filtering
    /// criteria. The results of this action can be retrieved using the [subscriptionBillingCycleBulkResults](https://shopify.dev/api/admin-graphql/latest/queries/subscriptionBillingCycleBulkResults) query.
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycleBulkCharge")]
    public SubscriptionBillingCycleBulkChargePayload? subscriptionBillingCycleBulkCharge { get; set; } = null;

    /// <summary>
    /// Asynchronously queries all subscription billing cycles whose [billingAttemptExpectedDate](https://shopify.dev/api/admin-graphql/latest/objects/SubscriptionBillingCycle#field-billingattemptexpecteddate)
    /// values fall within a specified date range and meet additional filtering
    /// criteria. The results of this action can be retrieved using the [subscriptionBillingCycleBulkResults](https://shopify.dev/api/admin-graphql/latest/queries/subscriptionBillingCycleBulkResults) query.
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycleBulkSearch")]
    public SubscriptionBillingCycleBulkSearchPayload? subscriptionBillingCycleBulkSearch { get; set; } = null;

    /// <summary>
    /// Creates a new subscription billing attempt for a specified billing cycle. This
    /// is the alternative mutation for [subscriptionBillingAttemptCreate](https://shopify.dev/docs/api/admin-graphql/latest/mutations/subscriptionBillingAttemptCreate).
    /// For more information, refer to [Create a subscription contract](https://shopify.dev/docs/apps/selling-strategies/subscriptions/contracts/create#step-4-create-a-billing-attempt).
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycleCharge")]
    public SubscriptionBillingCycleChargePayload? subscriptionBillingCycleCharge { get; set; } = null;

    /// <summary>
    /// Commits the updates of a Subscription Billing Cycle Contract draft.
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycleContractDraftCommit")]
    public SubscriptionBillingCycleContractDraftCommitPayload? subscriptionBillingCycleContractDraftCommit { get; set; } = null;

    /// <summary>
    /// Concatenates a contract to a Subscription Draft.
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycleContractDraftConcatenate")]
    public SubscriptionBillingCycleContractDraftConcatenatePayload? subscriptionBillingCycleContractDraftConcatenate { get; set; } = null;

    /// <summary>
    /// Edit the contents of a subscription contract for the specified billing cycle.
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycleContractEdit")]
    public SubscriptionBillingCycleContractEditPayload? subscriptionBillingCycleContractEdit { get; set; } = null;

    /// <summary>
    /// Delete the schedule and contract edits of the selected subscription billing cycle.
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycleEditDelete")]
    public SubscriptionBillingCycleEditDeletePayload? subscriptionBillingCycleEditDelete { get; set; } = null;

    /// <summary>
    /// Delete the current and future schedule and contract edits of a list of subscription billing cycles.
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycleEditsDelete")]
    public SubscriptionBillingCycleEditsDeletePayload? subscriptionBillingCycleEditsDelete { get; set; } = null;

    /// <summary>
    /// Modify the schedule of a specific billing cycle.
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycleScheduleEdit")]
    public SubscriptionBillingCycleScheduleEditPayload? subscriptionBillingCycleScheduleEdit { get; set; } = null;

    /// <summary>
    /// Skips a Subscription Billing Cycle.
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycleSkip")]
    public SubscriptionBillingCycleSkipPayload? subscriptionBillingCycleSkip { get; set; } = null;

    /// <summary>
    /// Unskips a Subscription Billing Cycle.
    /// </summary>
    [JsonPropertyName("subscriptionBillingCycleUnskip")]
    public SubscriptionBillingCycleUnskipPayload? subscriptionBillingCycleUnskip { get; set; } = null;

    /// <summary>
    /// Activates a Subscription Contract. Contract status must be either active, paused, or failed.
    /// </summary>
    [JsonPropertyName("subscriptionContractActivate")]
    public SubscriptionContractActivatePayload? subscriptionContractActivate { get; set; } = null;

    /// <summary>
    /// Creates a Subscription Contract.
    /// </summary>
    [JsonPropertyName("subscriptionContractAtomicCreate")]
    public SubscriptionContractAtomicCreatePayload? subscriptionContractAtomicCreate { get; set; } = null;

    /// <summary>
    /// Cancels a Subscription Contract.
    /// </summary>
    [JsonPropertyName("subscriptionContractCancel")]
    public SubscriptionContractCancelPayload? subscriptionContractCancel { get; set; } = null;

    /// <summary>
    /// Creates a Subscription Contract Draft.
    /// You can submit all the desired information for the draft using [Subscription Draft Input object](https://shopify.dev/docs/api/admin-graphql/latest/input-objects/SubscriptionDraftInput).
    /// You can also update the draft using the [Subscription Contract Update](https://shopify.dev/docs/api/admin-graphql/latest/mutations/subscriptionContractUpdate) mutation.
    /// The draft is not saved until you call the [Subscription Draft Commit](https://shopify.dev/docs/api/admin-graphql/latest/mutations/subscriptionDraftCommit) mutation.
    /// </summary>
    [JsonPropertyName("subscriptionContractCreate")]
    public SubscriptionContractCreatePayload? subscriptionContractCreate { get; set; } = null;

    /// <summary>
    /// Expires a Subscription Contract.
    /// </summary>
    [JsonPropertyName("subscriptionContractExpire")]
    public SubscriptionContractExpirePayload? subscriptionContractExpire { get; set; } = null;

    /// <summary>
    /// Fails a Subscription Contract.
    /// </summary>
    [JsonPropertyName("subscriptionContractFail")]
    public SubscriptionContractFailPayload? subscriptionContractFail { get; set; } = null;

    /// <summary>
    /// Pauses a Subscription Contract.
    /// </summary>
    [JsonPropertyName("subscriptionContractPause")]
    public SubscriptionContractPausePayload? subscriptionContractPause { get; set; } = null;

    /// <summary>
    /// Allows for the easy change of a Product in a Contract or a Product price change.
    /// </summary>
    [JsonPropertyName("subscriptionContractProductChange")]
    public SubscriptionContractProductChangePayload? subscriptionContractProductChange { get; set; } = null;

    /// <summary>
    /// Sets the next billing date of a Subscription Contract. This field is managed by the apps.
    ///         Alternatively you can utilize our
    ///         [Billing Cycles APIs](https://shopify.dev/docs/apps/selling-strategies/subscriptions/billing-cycles),
    ///         which provide auto-computed billing dates and additional functionalities.
    /// </summary>
    [JsonPropertyName("subscriptionContractSetNextBillingDate")]
    public SubscriptionContractSetNextBillingDatePayload? subscriptionContractSetNextBillingDate { get; set; } = null;

    /// <summary>
    /// The subscriptionContractUpdate mutation allows you to create a draft of an
    /// existing subscription contract. This [draft](https://shopify.dev/api/admin-graphql/latest/objects/SubscriptionDraft)
    /// can be reviewed and modified as needed. Once the draft is committed with [subscriptionDraftCommit](https://shopify.dev/api/admin-graphql/latest/mutations/subscriptionDraftCommit),
    /// the changes are applied to the original subscription contract.
    /// </summary>
    [JsonPropertyName("subscriptionContractUpdate")]
    public SubscriptionContractUpdatePayload? subscriptionContractUpdate { get; set; } = null;

    /// <summary>
    /// Commits the updates of a Subscription Contract draft.
    /// </summary>
    [JsonPropertyName("subscriptionDraftCommit")]
    public SubscriptionDraftCommitPayload? subscriptionDraftCommit { get; set; } = null;

    /// <summary>
    /// Adds a subscription discount to a subscription draft.
    /// </summary>
    [JsonPropertyName("subscriptionDraftDiscountAdd")]
    public SubscriptionDraftDiscountAddPayload? subscriptionDraftDiscountAdd { get; set; } = null;

    /// <summary>
    /// Applies a code discount on the subscription draft.
    /// </summary>
    [JsonPropertyName("subscriptionDraftDiscountCodeApply")]
    public SubscriptionDraftDiscountCodeApplyPayload? subscriptionDraftDiscountCodeApply { get; set; } = null;

    /// <summary>
    /// Removes a subscription discount from a subscription draft.
    /// </summary>
    [JsonPropertyName("subscriptionDraftDiscountRemove")]
    public SubscriptionDraftDiscountRemovePayload? subscriptionDraftDiscountRemove { get; set; } = null;

    /// <summary>
    /// Updates a subscription discount on a subscription draft.
    /// </summary>
    [JsonPropertyName("subscriptionDraftDiscountUpdate")]
    public SubscriptionDraftDiscountUpdatePayload? subscriptionDraftDiscountUpdate { get; set; } = null;

    /// <summary>
    /// Adds a subscription free shipping discount to a subscription draft.
    /// </summary>
    [JsonPropertyName("subscriptionDraftFreeShippingDiscountAdd")]
    public SubscriptionDraftFreeShippingDiscountAddPayload? subscriptionDraftFreeShippingDiscountAdd { get; set; } = null;

    /// <summary>
    /// Updates a subscription free shipping discount on a subscription draft.
    /// </summary>
    [JsonPropertyName("subscriptionDraftFreeShippingDiscountUpdate")]
    public SubscriptionDraftFreeShippingDiscountUpdatePayload? subscriptionDraftFreeShippingDiscountUpdate { get; set; } = null;

    /// <summary>
    /// Adds a subscription line to a subscription draft.
    /// </summary>
    [JsonPropertyName("subscriptionDraftLineAdd")]
    public SubscriptionDraftLineAddPayload? subscriptionDraftLineAdd { get; set; } = null;

    /// <summary>
    /// Removes a subscription line from a subscription draft.
    /// </summary>
    [JsonPropertyName("subscriptionDraftLineRemove")]
    public SubscriptionDraftLineRemovePayload? subscriptionDraftLineRemove { get; set; } = null;

    /// <summary>
    /// Updates a subscription line on a subscription draft.
    /// </summary>
    [JsonPropertyName("subscriptionDraftLineUpdate")]
    public SubscriptionDraftLineUpdatePayload? subscriptionDraftLineUpdate { get; set; } = null;

    /// <summary>
    /// Updates a Subscription Draft.
    /// </summary>
    [JsonPropertyName("subscriptionDraftUpdate")]
    public SubscriptionDraftUpdatePayload? subscriptionDraftUpdate { get; set; } = null;

    /// <summary>
    /// Add tags to an order, a draft order, a customer, a product, or an online store article.
    /// </summary>
    [JsonPropertyName("tagsAdd")]
    public TagsAddPayload? tagsAdd { get; set; } = null;

    /// <summary>
    /// Remove tags from an order, a draft order, a customer, a product, or an online store article.
    /// </summary>
    [JsonPropertyName("tagsRemove")]
    public TagsRemovePayload? tagsRemove { get; set; } = null;

    /// <summary>
    /// Allows tax app configurations for tax partners.
    /// </summary>
    [JsonPropertyName("taxAppConfigure")]
    public TaxAppConfigurePayload? taxAppConfigure { get; set; } = null;

    /// <summary>
    /// Creates a theme using an external URL or for files that were previously uploaded using the
    /// [stagedUploadsCreate mutation](https://shopify.dev/api/admin-graphql/latest/mutations/stageduploadscreate).
    /// These themes are added to the [Themes page](https://admin.shopify.com/themes) in Shopify admin.
    /// </summary>
    [JsonPropertyName("themeCreate")]
    public ThemeCreatePayload? themeCreate { get; set; } = null;

    /// <summary>
    /// Deletes a theme.
    /// </summary>
    [JsonPropertyName("themeDelete")]
    public ThemeDeletePayload? themeDelete { get; set; } = null;

    /// <summary>
    /// Copy theme files. Copying to existing theme files will overwrite them.
    /// </summary>
    [JsonPropertyName("themeFilesCopy")]
    public ThemeFilesCopyPayload? themeFilesCopy { get; set; } = null;

    /// <summary>
    /// Deletes a theme's files.
    /// </summary>
    [JsonPropertyName("themeFilesDelete")]
    public ThemeFilesDeletePayload? themeFilesDelete { get; set; } = null;

    /// <summary>
    /// Create or update theme files.
    /// </summary>
    [JsonPropertyName("themeFilesUpsert")]
    public ThemeFilesUpsertPayload? themeFilesUpsert { get; set; } = null;

    /// <summary>
    /// Publishes a theme.
    /// </summary>
    [JsonPropertyName("themePublish")]
    public ThemePublishPayload? themePublish { get; set; } = null;

    /// <summary>
    /// Updates a theme.
    /// </summary>
    [JsonPropertyName("themeUpdate")]
    public ThemeUpdatePayload? themeUpdate { get; set; } = null;

    /// <summary>
    /// Trigger the voiding of an uncaptured authorization transaction.
    /// </summary>
    [JsonPropertyName("transactionVoid")]
    public TransactionVoidPayload? transactionVoid { get; set; } = null;

    /// <summary>
    /// Creates or updates translations.
    /// </summary>
    [JsonPropertyName("translationsRegister")]
    public TranslationsRegisterPayload? translationsRegister { get; set; } = null;

    /// <summary>
    /// Deletes translations.
    /// </summary>
    [JsonPropertyName("translationsRemove")]
    public TranslationsRemovePayload? translationsRemove { get; set; } = null;

    /// <summary>
    /// Asynchronously delete [URL redirects](https://shopify.dev/api/admin-graphql/latest/objects/UrlRedirect) in bulk.
    /// </summary>
    [JsonPropertyName("urlRedirectBulkDeleteAll")]
    public UrlRedirectBulkDeleteAllPayload? urlRedirectBulkDeleteAll { get; set; } = null;

    /// <summary>
    /// Asynchronously delete [URLRedirect](https://shopify.dev/api/admin-graphql/latest/objects/UrlRedirect) 
    /// objects in bulk by IDs.
    /// Learn more about [URLRedirect](https://help.shopify.com/en/manual/online-store/menus-and-links/url-redirect) 
    /// objects.
    /// </summary>
    [JsonPropertyName("urlRedirectBulkDeleteByIds")]
    public UrlRedirectBulkDeleteByIdsPayload? urlRedirectBulkDeleteByIds { get; set; } = null;

    /// <summary>
    /// Asynchronously delete redirects in bulk.
    /// </summary>
    [JsonPropertyName("urlRedirectBulkDeleteBySavedSearch")]
    public UrlRedirectBulkDeleteBySavedSearchPayload? urlRedirectBulkDeleteBySavedSearch { get; set; } = null;

    /// <summary>
    /// Asynchronously delete redirects in bulk.
    /// </summary>
    [JsonPropertyName("urlRedirectBulkDeleteBySearch")]
    public UrlRedirectBulkDeleteBySearchPayload? urlRedirectBulkDeleteBySearch { get; set; } = null;

    /// <summary>
    /// Creates a [`UrlRedirect`](https://shopify.dev/api/admin-graphql/latest/objects/UrlRedirect) object.
    /// </summary>
    [JsonPropertyName("urlRedirectCreate")]
    public UrlRedirectCreatePayload? urlRedirectCreate { get; set; } = null;

    /// <summary>
    /// Deletes a [`UrlRedirect`](https://shopify.dev/api/admin-graphql/latest/objects/UrlRedirect) object.
    /// </summary>
    [JsonPropertyName("urlRedirectDelete")]
    public UrlRedirectDeletePayload? urlRedirectDelete { get; set; } = null;

    /// <summary>
    /// Creates a [`UrlRedirectImport`](https://shopify.dev/api/admin-graphql/latest/objects/UrlRedirectImport) object.
    /// After creating the `UrlRedirectImport` object, the `UrlRedirectImport` request
    /// can be performed using the [`urlRedirectImportSubmit`](https://shopify.dev/api/admin-graphql/latest/mutations/urlRedirectImportSubmit) mutation.
    /// </summary>
    [JsonPropertyName("urlRedirectImportCreate")]
    public UrlRedirectImportCreatePayload? urlRedirectImportCreate { get; set; } = null;

    /// <summary>
    /// Submits a `UrlRedirectImport` request to be processed.
    /// The `UrlRedirectImport` request is first created with the [`urlRedirectImportCreate`](https://shopify.dev/api/admin-graphql/latest/mutations/urlRedirectImportCreate) mutation.
    /// </summary>
    [JsonPropertyName("urlRedirectImportSubmit")]
    public UrlRedirectImportSubmitPayload? urlRedirectImportSubmit { get; set; } = null;

    /// <summary>
    /// Updates a URL redirect.
    /// </summary>
    [JsonPropertyName("urlRedirectUpdate")]
    public UrlRedirectUpdatePayload? urlRedirectUpdate { get; set; } = null;

    /// <summary>
    /// Creates a validation.
    /// </summary>
    [JsonPropertyName("validationCreate")]
    public ValidationCreatePayload? validationCreate { get; set; } = null;

    /// <summary>
    /// Deletes a validation.
    /// </summary>
    [JsonPropertyName("validationDelete")]
    public ValidationDeletePayload? validationDelete { get; set; } = null;

    /// <summary>
    /// Update a validation.
    /// </summary>
    [JsonPropertyName("validationUpdate")]
    public ValidationUpdatePayload? validationUpdate { get; set; } = null;

    /// <summary>
    /// Creates a new webhook subscription.
    /// Building an app? If you only use app-specific webhooks, you won't need this.
    /// App-specific webhook subscriptions specified in your `shopify.app.toml` may be
    /// easier. They are automatically kept up to date by Shopify & require less
    /// maintenance. Please read [About managing webhook
    /// subscriptions](https://shopify.dev/docs/apps/build/webhooks/subscribe).
    /// </summary>
    [JsonPropertyName("webhookSubscriptionCreate")]
    public WebhookSubscriptionCreatePayload? webhookSubscriptionCreate { get; set; } = null;

    /// <summary>
    /// Deletes a webhook subscription.
    /// Building an app? If you only use app-specific webhooks, you won't need this.
    /// App-specific webhook subscriptions specified in your `shopify.app.toml` may be
    /// easier. They are automatically kept up to date by Shopify & require less
    /// maintenance. Please read [About managing webhook
    /// subscriptions](https://shopify.dev/docs/apps/build/webhooks/subscribe).
    /// </summary>
    [JsonPropertyName("webhookSubscriptionDelete")]
    public WebhookSubscriptionDeletePayload? webhookSubscriptionDelete { get; set; } = null;

    /// <summary>
    /// Updates a webhook subscription.
    /// Building an app? If you only use app-specific webhooks, you won't need this.
    /// App-specific webhook subscriptions specified in your `shopify.app.toml` may be
    /// easier. They are automatically kept up to date by Shopify & require less
    /// maintenance. Please read [About managing webhook
    /// subscriptions](https://shopify.dev/docs/apps/build/webhooks/subscribe).
    /// </summary>
    [JsonPropertyName("webhookSubscriptionUpdate")]
    public WebhookSubscriptionUpdatePayload? webhookSubscriptionUpdate { get; set; } = null;

    /// <summary>
    /// Activate a [web pixel extension](https://shopify.dev/docs/apps/build/marketing-analytics/build-web-pixels)
    /// by creating a web pixel record on the store where you installed your app.
    /// When you run the `webPixelCreate` mutation, Shopify validates it
    /// against the settings definition in `shopify.extension.toml`. If the `settings` input field doesn't match
    /// the schema that you defined, then the mutation fails. Learn how to
    /// define [web pixel settings](https://shopify.dev/docs/apps/build/marketing-analytics/build-web-pixels#step-2-define-your-web-pixel-settings).
    /// </summary>
    [JsonPropertyName("webPixelCreate")]
    public WebPixelCreatePayload? webPixelCreate { get; set; } = null;

    /// <summary>
    /// Deletes the web pixel shop settings.
    /// </summary>
    [JsonPropertyName("webPixelDelete")]
    public WebPixelDeletePayload? webPixelDelete { get; set; } = null;

    /// <summary>
    /// Activate a [web pixel extension](https://shopify.dev/docs/apps/build/marketing-analytics/build-web-pixels)
    /// by updating a web pixel record on the store where you installed your app.
    /// When you run the `webPixelUpdate` mutation, Shopify validates it
    /// against the settings definition in `shopify.extension.toml`. If the `settings` input field doesn't match
    /// the schema that you defined, then the mutation fails. Learn how to
    /// define [web pixel settings](https://shopify.dev/docs/apps/build/marketing-analytics/build-web-pixels#step-2-define-your-web-pixel-settings).
    /// </summary>
    [JsonPropertyName("webPixelUpdate")]
    public WebPixelUpdatePayload? webPixelUpdate { get; set; } = null;

    /// <summary>
    /// Creates a web presence.
    /// </summary>
    [JsonPropertyName("webPresenceCreate")]
    public WebPresenceCreatePayload? webPresenceCreate { get; set; } = null;

    /// <summary>
    /// Deletes a web presence.
    /// </summary>
    [JsonPropertyName("webPresenceDelete")]
    public WebPresenceDeletePayload? webPresenceDelete { get; set; } = null;

    /// <summary>
    /// Updates a web presence.
    /// </summary>
    [JsonPropertyName("webPresenceUpdate")]
    public WebPresenceUpdatePayload? webPresenceUpdate { get; set; } = null;
}