using System;
using System.Diagnostics;
using System.IO;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using ShopifySharp.Credentials;

namespace ShopifySharp.Tests.Integration;

/// <summary>
/// xUnit v3 assembly fixture that loads test configuration once at suite startup.
/// Reads from appsettings.local.json and environment variables (ShopifySharp__Credentials::*).
/// </summary>
[UsedImplicitly]
public class TestConfigurationFixture : IDisposable
{
    private readonly IConfiguration _configuration;

    public static TestConfigurationFixture Current { get; private set; } = null!;

    public TestConfigurationFixture()
    {
        Current = this;

        // Reset the global HTTP client factory to ensure no pollution from other test classes
        // that set a fake factory (e.g., ShopifyServiceTests.Allows_Setting_Global_HttpClientFactory)
        ShopifySharp.ShopifyService.SetGlobalHttpClientFactory(null);

        var builder = new ConfigurationBuilder();

        // If SOPS_ENV_FILE is set, decrypt it and load as JSON stream.
        var sopsEnvFile = Environment.GetEnvironmentVariable("SOPS_ENV_FILE");
        if (!string.IsNullOrEmpty(sopsEnvFile))
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "sops",
                Arguments = $"decrypt {sopsEnvFile}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
            };

            using var process = Process.Start(startInfo) ?? throw new InvalidOperationException("Failed to start sops process.");
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                var stderr = process.StandardError.ReadToEnd();
                throw new InvalidOperationException(
                    $"sops decrypt failed (exit code {process.ExitCode}): {stderr}");
            }

            var decryptedStream = process.StandardOutput.BaseStream;
            builder.AddJsonStream(decryptedStream);
        }
        else
        {
            builder.SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: false);
        }

        builder.AddEnvironmentVariables();

        _configuration = builder.Build();
    }

    public string ApiKey => GetRequired("ShopifySharp:Credentials:ApiKey");
    public string SecretKey => _configuration["ShopifySharp:Credentials:SecretKey"] ?? string.Empty;
    public string AccessToken => GetRequired("ShopifySharp:Credentials:AccessToken");
    public string MultipassSecret => _configuration["ShopifySharp:Credentials:MultipassSecret"] ?? string.Empty;
    public string MyShopifyUrl => GetRequired("ShopifySharp:Credentials:MyShopifyUrl");
    public string ShopDomain => GetRequired("ShopifySharp:Credentials:ShopDomain");

    public long OrganizationId => long.Parse(GetRequired("ShopifySharp:Credentials:OrganizationId"));
    public string OrganizationToken => GetRequired("ShopifySharp:Credentials:OrganizationToken");

    public ShopifyApiCredentials Credentials => new(ShopDomain, AccessToken);
    public ShopifyPartnerApiCredentials PartnerCredentials => new(OrganizationId, OrganizationToken);

    /// <summary>
    /// Gets a required configuration value or throws if missing.
    /// </summary>
    private string GetRequired(string key)
    {
        var value = _configuration[key];
        if (string.IsNullOrEmpty(value))
        {
            throw new InvalidOperationException(
                $"Configuration key '{key}' was not found or is empty. " +
                $"Set the environment variable {key.Replace(":", "__")} or add it to appsettings.local.json.");
        }
        return value;
    }

    public void Dispose() { }
}
