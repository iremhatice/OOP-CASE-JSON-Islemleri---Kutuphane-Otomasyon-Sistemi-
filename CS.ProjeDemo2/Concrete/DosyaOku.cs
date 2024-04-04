using CS.ProjeDemo2.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CS.ProjeDemo2.Concrete
{
    public static class DosyaOku
    {
        /// <summary>
        /// Json'ı bir dosyaya yazdırmak için kullanılır
        /// </summary>
        /// <param name="json"></param>yazılacak json dizesi
        /// <param name="filePath"></param>dosyanın yolu
        public static void DosyaYaz(string json, string filePath)
        {
            try
            {
                //StreamWriter sınıfından bir nesne oluşturulur ve dosya yazma işlemi için kullanılır. Bu nesne, using bloğu içinde oluşturulduğu için, işlem bittiğinde otomatik olarak kapatılır ve kaynaklar serbest bırakılır. 
                //Dosya okuma/yaz
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.Write(json); //filePath parametresi tarafından belirtilen dosyayı yazma modunda açar.
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Hata Oluştu: " + ex.Message);
            }
        }

        /// <summary>
        ///  Bu metot, bir dosyadan JSON verisini okumak için kullanılır.Metot, okunan JSON verisini bir dize olarak döndürür.
        /// </summary>
        /// <param name="filePath"></param> okunacak dosyanın yolu,
        /// <returns></returns>
        public static string DosyaOkuma(string filePath)
        {
            try
            {
                //StreamReader sınıfından bir nesne oluşturulur ve dosya okuma işlemi için kullanılır. Bu nesne, using bloğu içinde oluşturulduğu için, işlem bittiğinde otomatik olarak kapatılır ve kaynaklar serbest bırakılır. 
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    return streamReader.ReadToEnd(); //StreamReader nesnesi üzerinden ReadToEnd() metodunu çağırarak dosyanın tamamını okur ve okunan içeriği bir dize olarak döndürür.
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata Oluştu.");
                return null;
            }
        }
    }
}
