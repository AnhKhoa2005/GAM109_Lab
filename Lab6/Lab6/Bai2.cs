using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal static class Bai2
    {
        static List<ShopLab6> listShop = new List<ShopLab6>();
        static List<PhoneLab6> listPhone = new List<PhoneLab6>();
        public static void _Bai2()
        {

            listShop.Add(new ShopLab6(1, "HCM", "Quan 12"));
            listShop.Add(new ShopLab6(2, "Ha Noi", "Quan Nam tu lien"));
            listShop.Add(new ShopLab6(3, "Da Nang", "Quan Hai chau"));


            listPhone.Add(new PhoneLab6(1, 1, "IP 15", 100, "doc la binh duong"));
            listPhone.Add(new PhoneLab6(2, 2, "IP 16", 1000, "doc la binh duong"));
            listPhone.Add(new PhoneLab6(3, 3, "IP 17", 10000, "doc la binh duong"));
            listPhone.Add(new PhoneLab6(4, 1, "IP 18", 100000, "doc la binh duong"));

            Console.WriteLine("\n----------Bai 2----------");
            Console.WriteLine("\n----------Cau a----------");
            Cau_a();
            Console.WriteLine("\n----------Cau b----------");
            Cau_b();
        }

        public static void Cau_a()
        {
            listShop
                  .Join(listPhone,
                          shop => shop.id,
                          phone => phone.id,
                       (shop, phone) => new
                       {
                           ShopName = shop.shopName,
                           PhoneName = phone.name
                       })
                  .ToList()
                  .ForEach(x => Console.WriteLine($"Shop Name: {x.ShopName} \t Phone Name: {x.PhoneName}"));
        }

        public static void Cau_b()
        {
            var newList = listShop
                                .GroupJoin(listPhone,
                                        shop => shop.id,
                                        phone => phone.shop_id,
                                        (shop, phone) => new
                                        {
                                            ShopName = shop.shopName,
                                            Phone = phone.ToList()
                                        });

            foreach (var shopName in newList)
            {
                Console.WriteLine($"\nShop Name: {shopName.ShopName}");
                foreach (var phone in shopName.Phone)
                {
                    Console.WriteLine($"Phone Name: {phone.name} \t Price: {phone.price}");
                }
            }
        }
    }
}
