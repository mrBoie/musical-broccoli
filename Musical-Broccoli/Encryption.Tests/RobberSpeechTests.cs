using Musical_Broccoli.Encryption;
using Xunit;

namespace Encryption.Tests
{
    public class RobberSpeechTests
    {
        [Theory]
        [InlineData("Jag talar Rövarspråket!", "Jojagog totalolaror Rorövovarorsospoproråkoketot!")]
        [InlineData("I'm speaking Robber's language!", "I'mom sospopeakokinongog Rorobobboberor'sos lolanongoguagoge!")]
        [InlineData("Tre Kronor är världens bästa ishockeylag.", "Totrore Kokrorononoror äror vovärorloldodenonsos bobäsostota isoshohocockokeylolagog.")]
        [InlineData("Vår kung är coolare än er kung.", "Vovåror kokunongog äror cocoololarore änon eror kokunongog.")]
        public void RobberSpeech_Encrypt_EncryptsData(string input, string output)
        {
            var encrypter = new RobberSpeechEncryption();
            var encryptionOutput = encrypter.Encrypt(input);
            Assert.Equal(output, encryptionOutput);
        }

        [Theory]
        [InlineData("Jag talar Rövarspråket!", "Jojagog totalolaror Rorövovarorsospoproråkoketot!")]
        [InlineData("I'm speaking Robber's language!", "I'mom sospopeakokinongog Rorobobboberor'sos lolanongoguagoge!")]
        [InlineData("Tre Kronor är världens bästa ishockeylag.", "Totrore Kokrorononoror äror vovärorloldodenonsos bobäsostota isoshohocockokeylolagog.")]
        [InlineData("Vår kung är coolare än er kung.", "Vovåror kokunongog äror cocoololarore änon eror kokunongog.")]
        public void RobberSpeech_Decrypt_DecryptsData(string output, string input)
        {
            var decrypter = new RobberSpeechEncryption();
            var decryptedOutput = decrypter.Decrypt(input);
            Assert.Equal(output, decryptedOutput);
        }
    }
}
