using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashF21112017
{
    struct TInfo
    {
        public string phone;
        public string fio;
    }
    struct THashItem
        {
        public List<TInfo> listInfo;
    }
    class MyHash
    {
        public int sizeTable;
        static int step = 37;
        int size;
        public THashItem[] h;
        public MyHash(int sizeTable)
        {
            this.sizeTable = sizeTable;
            h = new THashItem[sizeTable];
            HashInit();
        }
        public void HashInit()
        {
            size = 0;
            for (int i = 0; i<sizeTable; i++)
            {
                h[i].listInfo = new List<TInfo>();
            }
        }
        public int AddHash(string fio, string phone)
        {
            int adr = -1;
            if(size<sizeTable)
            {
                adr = hashKey(fio);
                TInfo ti = new TInfo();
                ti.fio = fio;
                ti.phone = phone;
                h[adr].listInfo.Add(ti);
                ++size;

            }
            return adr;
        }
        public int DelHash(string fio)
        {
            string phone;
            int adr = hashKey(fio);
            int adrList = FindHash(fio, out phone);
            if(adrList!=-1)
            {
                TInfo ti = new TInfo();
                ti.fio = fio;
                ti.phone = phone;

                h[adr].listInfo.Remove(ti);
            }
            return adrList;
        }
        public int FindHash(string fio, out string phone)
        {
            int result = -1;
            phone = "";
            int i = hashKey(fio);
            for (int j = 0; j<h[i].listInfo.Count; j++)
            {
                if (fio == h[i].listInfo[j].fio)
                {
                    result = j;
                    phone = h[i].listInfo[j].phone;
                    break;
                }

            }
            return result;
            
        }
       public int hashKey(string s)
        {
            int result = 0;
            for (int i = 0; i<s.Length; i++)
            {
                result += Convert.ToInt32(s[i] * (i + 1));
                result %= sizeTable;
            }
            return result;
        }

    }
}
