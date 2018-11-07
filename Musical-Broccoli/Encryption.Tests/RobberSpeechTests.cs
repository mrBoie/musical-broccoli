using Musical_Broccoli.Encryption;
using Xunit;

namespace Encryption.Tests
{
    public class RobberSpeechTests
    {
        [Theory]
        [InlineData("Jag talar R�varspr�ket!", "Jojagog totalolaror Ror�vovarorsospopror�koketot!")]
        [InlineData("I'm speaking Robber's language!", "I'mom sospopeakokinongog Rorobobboberor'sos lolanongoguagoge!")]
        [InlineData("Tre Kronor �r v�rldens b�sta ishockeylag.", "Totrore Kokrorononoror �ror vov�rorloldodenonsos bob�sostota isoshohocockokeylolagog.")]
        [InlineData("V�r kung �r coolare �n er kung.", "Vov�ror kokunongog �ror cocoololarore �non eror kokunongog.")]
        public void RobberSpeech_Encrypt_EncryptsData(string input, string output)
        {
            var encrypter = new RobberSpeechEncryption();
            var encryptionOutput = encrypter.Encrypt(input);
            Assert.Equal(output, encryptionOutput);
        }

        [Theory]
        [InlineData("Jag talar R�varspr�ket!", "Jojagog totalolaror Ror�vovarorsospopror�koketot!")]
        [InlineData("I'm speaking Robber's language!", "I'mom sospopeakokinongog Rorobobboberor'sos lolanongoguagoge!")]
        [InlineData("Tre Kronor �r v�rldens b�sta ishockeylag.", "Totrore Kokrorononoror �ror vov�rorloldodenonsos bob�sostota isoshohocockokeylolagog.")]
        [InlineData("V�r kung �r coolare �n er kung.", "Vov�ror kokunongog �ror cocoololarore �non eror kokunongog.")]
        public void RobberSpeech_Decrypt_DecryptsData(string output, string input)
        {
            var decrypter = new RobberSpeechEncryption();
            var decryptedOutput = decrypter.Decrypt(input);
            Assert.Equal(output, decryptedOutput);
        }
    }
}
