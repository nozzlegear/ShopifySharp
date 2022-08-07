using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public static class MultipassService
    {
        private const int FixedKeySize = 16;

        public static string GetMultipassUrl(
            Customer userData,
            string shopifyUrl, 
            string multipassSecret
            )
        {
            string validatedShopifyUrl = ValidateShopifyUrl(shopifyUrl);

            if (userData == null)
            {
                throw new ShopifyException($"The given {nameof(userData)} is empty.");
            }

            if (string.IsNullOrEmpty(multipassSecret))
            {
                throw new ShopifyException($"The given {nameof(multipassSecret)} is empty.");
            }

            string token = Encrypt(
                JsonConvert.SerializeObject(userData, new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore
                }),
                multipassSecret
            );

            return $"{validatedShopifyUrl}/account/login/multipass/{token}";
        }

        private static string ValidateShopifyUrl(string shopifyUrl)
        {
            if (Uri.IsWellFormedUriString(shopifyUrl, UriKind.Absolute) == false)
            {
                //Shopify typically returns the shop URL without a scheme. If the user is storing that as-is, the uri will not be well formed.
                //Try to fix that by adding a scheme and checking again.
                if (Uri.IsWellFormedUriString("https://" + shopifyUrl, UriKind.Absolute) == false)
                {
                    throw new ShopifyException($"The given {nameof(shopifyUrl)} cannot be converted into a well-formed URI.");
                }

                return "https://" + shopifyUrl;
            }

            return shopifyUrl;
        }

        private static string Encrypt(string json, string multipassSecret)
        {
            byte[] hash = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(multipassSecret));
            byte[] encryptionKey = new ArraySegment<byte>(hash, 0, FixedKeySize).ToArray();
            byte[] signatureKey = new ArraySegment<byte>(hash, FixedKeySize, FixedKeySize).ToArray();

            byte[] initVector = new byte[FixedKeySize];
            //change to more proper with .net standard 2.0
            //RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            rng.GetBytes(initVector);

            byte[] cipherData = new Func<byte[], byte[], byte[]>((iv, key) =>
            {
                byte[] encrypted;
                using (Aes aes = Aes.Create())
                {
                    aes.Key = encryptionKey;
                    aes.IV = iv;
                    aes.Mode = CipherMode.CBC;

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(cs))
                            {
                                sw.Write(json);
                            }

                            encrypted = ms.ToArray();
                        }
                    }
                }
                return encrypted;
            })(initVector, encryptionKey);
            byte[] cipher = initVector.Concat(cipherData).ToArray();
            byte[] signature = new HMACSHA256(signatureKey).ComputeHash(cipher);
            return Convert.ToBase64String(cipher.Concat(signature).ToArray())
                          .Replace("+", "-")
                          .Replace("/", "_");
        }
    }
}
