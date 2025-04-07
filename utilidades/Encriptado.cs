using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PacientesCesharp.utilidades
{
    internal class Encriptado
    {
        static readonly string clavePrivada = "2025tareadam2025";

        public static String Encriptar(String textoacifrar)
        {
            Aes aes = Aes.Create();

            aes.Key = Encoding.UTF8.GetBytes(clavePrivada);
            aes.IV = new byte[aes.BlockSize / 8];

            ICryptoTransform encriptador = aes.CreateEncryptor(aes.Key, aes.IV);

            MemoryStream flujodatosmemoria = new MemoryStream();

            CryptoStream cifradodedatos = new CryptoStream(flujodatosmemoria, encriptador, CryptoStreamMode.Write);

            byte[] bytesdeltextoPlano = UTF8Encoding.UTF8.GetBytes(textoacifrar);
            cifradodedatos.Write(bytesdeltextoPlano, 0, bytesdeltextoPlano.Length);
            cifradodedatos.FlushFinalBlock();

            byte[] bytescifraados = flujodatosmemoria.ToArray();
            
            flujodatosmemoria.Close();
            cifradodedatos.Close();

            return Convert.ToBase64String(bytescifraados);
        }

        public static string Desencriptar(string textoCifrado)
        {
            byte[] textoCifradoBytes = Convert.FromBase64String(textoCifrado);

            Aes aes = Aes.Create();

            aes.Key = Encoding.UTF8.GetBytes(clavePrivada);
            aes.IV = new byte[aes.BlockSize / 8];

            ICryptoTransform desencriptador = aes.CreateDecryptor(aes.Key, aes.IV);

            MemoryStream flujodatosmemoria = new MemoryStream(textoCifradoBytes);

            CryptoStream cifradodedatos = new CryptoStream(flujodatosmemoria, desencriptador, CryptoStreamMode.Read);

            StreamReader sr = new StreamReader(cifradodedatos);
            return sr.ReadToEnd();
        }
    }
}
