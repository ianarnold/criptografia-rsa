using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Envia
{
    public class ChaveAssimetrica
    {
        //realiza criptografia e descriptografia assimétrica
        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);

        //declarando as chaves pública e privada
        private RSAParameters privateKey;
        private RSAParameters publicKey;

        public ChaveAssimetrica()
        {
            //exportando as chaves
            privateKey = csp.ExportParameters(true);
            publicKey = csp.ExportParameters(false);
        }

        public string getPublicKey()
        {
            //gera uma cadeia de caracteres
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            //serializando nossa cadeira de carcteres na chave publica
            xs.Serialize(sw, publicKey);

            return sw.ToString();
        }

        public string encrypt(string text)
        {
            csp = new RSACryptoServiceProvider();
            //Importa a informação da chave RSA. 
            //Feito apenas para incluir a informação da chave pública
            csp.ImportParameters(publicKey);
            var data = Encoding.Unicode.GetBytes(text);
            //criptografando os dados
            var cypher = csp.Encrypt(data, false);
            return Convert.ToBase64String(cypher);
        }

        public string decrypt(string cypherText)
        {
            var dataBytes = Convert.FromBase64String(cypherText);
            //Importa informação da chavev RSA
            //Isso é preciso para incluir a informação da chave privada
            csp.ImportParameters(privateKey);
            //descriptografando
            var text = csp.Decrypt(dataBytes, false);
            return Encoding.Unicode.GetString(text);

        }
    }
}
