using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agaclaCoz
{
    public class agac
    {
        public int sayac;
        int basamak;
        dugum kok;
        public agac(dugum kokVer,int basamak)
        {
            this.basamak = basamak;
            this.kok = kokVer;
            sayac = 0;
        }
        //agacOlustur metodu ile aşağıdaki şartları sağlayan bir ağaç oluşturuyoruz:
        public void agacOlustur(dugum ebeveyn,int satır)
        {
            //agacın ilk satırında sadece kök bulunur
            //ikinci satırda kökün sol(siyah) ve sağ(beyaz) çocukları bulunabilir.
            //ikinci satırdaki çocukların da üçüncü satırda sol ve sağ çocukları bulunabilir
            //bu şekilde kaç basamak isteniyorsa o kadar satır eklenir
            if (satır < basamak)
            {
                if (ebeveyn.sol == null && ebeveyn.renk=="beyaz")
                {
                    //mevcut düğüm beyazsa sol çocuğu siyah, sağ çocuğu beyaz olur
                    dugum siyah = new dugum("siyah");
                    ebeveyn.sol = siyah;
                    //yeni satır oluşturmak için recursive olarak 
                    //satır sayısı arttırılıp fonksiyon tekrar çağrılır.
                    //istenilen satıra(yani basamağa) ulaşılmışsa else içindeki sayaç durumu bir artar.
                    agacOlustur(ebeveyn.sol,satır+1);
                }
                if (ebeveyn.sag == null)
                {
                    //mevcut düğüm siyahsa sol çocuğu olmaz(çünkü iki siyah ardarda gelmemelidir,
                    //sağ çocuğu beyaz olur
                    dugum beyaz = new dugum("beyaz");
                    ebeveyn.sag = beyaz;
                    //yeni satır oluşturmak için recursive olarak 
                    //satır sayısı arttırılıp fonksiyon tekrar çağrılır.
                    //istenilen satıra(yani basamağa) ulaşılmışsa else içindeki sayaç durumu bir artar.
                    agacOlustur(ebeveyn.sag,satır+1);
                }
            }
            else
            {
                sayac++;
            }
        }
    }
}
