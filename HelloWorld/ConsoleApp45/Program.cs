using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp45 {
    class Goods {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga) {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override string ToString() {
            return goodsno + " : " + gname + " : " + danga;
        }
    }

    class Cart {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get; set; }

        public override string ToString() {
            return goods + " : " + count + " : " + sum;
        }
    }

    class CartTest {
        static void Main() {
            Cart c1 = new Cart();
            c1.goods = new Goods(1001, "볼펜", 1000);
            c1.count = 2;
            c1.sum = c1.goods.danga * c1.count;

            Cart c2 = new Cart();
            c2.goods = new Goods(1002, "연필", 500);
            c2.count = 3;
            c2.sum = c2.goods.danga * c2.count;

            Cart c3 = new Cart();
            c3.goods = new Goods(1003, "딸기", 6000);
            c3.count = 2;
            c3.sum = c3.goods.danga * c3.count;

            Dictionary<int, Cart> table = new Dictionary<int, Cart>();
            table.Add(1, c1);
            table.Add(2, c2);
            table.Add(3, c3);

            foreach (KeyValuePair<int, Cart> i in table) {
                Console.WriteLine(i.Key + " : " + i.Value);
            }
        }
    }
}
