using System;

namespace Musical_Broccoli.Encryption.Abstractions
{
    public interface IEncryptionStrategy
    {
        string Encrypt(string input);
        string Decrypt(string input);
    }
}
