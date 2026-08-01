using System;
using Microsoft.Extensions.Configuration;
using ShopifySharp.Credentials;

namespace ShopifySharp.Tests.Integration;

/// <summary>
/// A helper class for reading configuration from appsettings.local.json.
/// </summary>
public static class ConfigurationHelper
{
    private static IConfiguration? _configuration;

    /// <summary>
    /// Gets the configuration from appsettings.local.json.
    /// </summary>
    private static IConfiguration Configuration
    {
        get
        {
            if (_configuration == null)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: false);
                _configuration = builder.Build();
            }
            return _configuration;
        }
    }

    /// <summary>
    /// Attempts to get an environment variable first by the key, then from configuration.
    /// All keys must be uppercased!
    /// </summary>
    public static string Get(string key)
    {
        key = key.ToUpper();

        var prefix = "SHOPIFYSHARP_";

        // First check environment variables
        var value = Environment.GetEnvironmentVariable(key) ?? Environment.GetEnvironmentVariable(prefix + key);

        if (!string.IsNullOrEmpty(value))
        {
            return value;
        }

        // Then check configuration with various key patterns
        var configValue = Configuration[$"{prefix}{key}"]
                       ?? Configuration[key]
                       ?? Configuration[$"ShopifySharp:Credentials:{key}"]
                       ?? Configuration[$"ShopifySharp:Credentials:{key.Replace("API_KEY", "ApiKey").Replace("_", "")}"];

        if (!string.IsNullOrEmpty(configValue))
        {
            return configValue;
        }

        throw new Exception($"{key} was not found in environment variables or configuration. " +
            $"Add the key or {prefix}{key} to your environment variables or add it to appsettings.local.json and try again.");
    }

    public static string ApiKey => Get("API_KEY");

    public static string SecretKey => Get("SECRET_KEY");

    public static string AccessToken => Get("ACCESS_TOKEN");

    public static string MultipassSecret => Get("MULTIPASS_SECRET");

    public static string MyShopifyUrl => Get("MY_SHOPIFY_URL");

    public static ShopifyApiCredentials Credentials => new(MyShopifyUrl, AccessToken);

    public static long OrganizationId => long.Parse(Get("ORG_ID"));

    public static string OrganizationToken => Get("ORG_TOKEN");

    public static ShopifyPartnerApiCredentials PartnerCredentials => new(OrganizationId, OrganizationToken);
}