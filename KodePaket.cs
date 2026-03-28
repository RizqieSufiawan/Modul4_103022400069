using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400069
{
    internal class KodePaket
    {
        public string GetKodePaket(string namaPaket)
        {
            string[,] tableKodePaket = {
        { "Basic", "P201" },
        { "Standard", "P202" },
        { "Premium", "P203" },
        { "Unlimited", "P204" },
        { "Gaming", "P205" },
        { "Streaming", "P206" },
        { "Family", "P207" },
        { "Business", "P208" },
        { "Student", "P209" },
        { "Traveler", "P210" },
        };
            for (int i = 0; i < tableKodePaket.GetLength(0); i++)
            {
                if (tableKodePaket[i, 0].Equals(namaPaket, StringComparison.OrdinalIgnoreCase))
                {
                    return tableKodePaket[i, 1];
                }
            }
            return "Paket Tidak Ditemukan";
        }
    }
}

