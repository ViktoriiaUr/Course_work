using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Collections;

namespace ClassLibraryCourseWork
{
    public class HashMethod
    {
        private Dictionary<string, int> hashTable;
        public List<double> Passed
        {
            get;
            private set;
        }
        public int Comp
        {
            get;
            private set;
        }
        public HashMethod()
        {
            hashTable = new Dictionary<string, int>();
            Passed = new List<double>();
        }

        public void BuildHashTable(double[] arr)
        {
            hashTable.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                string hash = SHA256Hash(arr[i].ToString());
                if (!hashTable.ContainsKey(hash))
                {
                    hashTable.Add(hash, i);
                }
            }           
        }

        public int HashSearch(double[] arr, double key)
        {
            Comp = 0;
            Passed.Clear();
            string hash = SHA256Hash(key.ToString());
            if (hashTable.TryGetValue(hash, out int index))
            {
                Comp++;
                Passed.Add(arr[index]);
                if (arr[index] == key)
                {
                    return index;
                }
            }
            return -1;
        }

        private string SHA256Hash(string rawData)
        {
            using (SHA256 sha256 = SHA256.Create())
            {

                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
