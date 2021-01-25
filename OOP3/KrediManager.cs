using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Burada operasyonlar tanımlayacağız. Genellikle operasyonel methotlarda inheritance kullanılır.
    //Okunurluğu artımak için biz interface isimlerini "I" harfi ile başlatırız.
    
    
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();

    }
}
