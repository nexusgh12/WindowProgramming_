using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfoWindowApp
{
    class EBook : Book, Sale
    {
        private int price;
        private bool outOfStock = false;

        public EBook(string title, string author, int page, string ISBN, string publisher, int price) : base(title, author, page, ISBN, publisher)
        {
            this.price = price;
        }

        //프로퍼티
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
            }
        }
        public bool OutOfStock
        {
            get
            {
                return outOfStock;
            }
            set
            {
                this.outOfStock = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\r\n가격 : " + this.price + "\r\n품절 : " + this.outOfStock;
        }

        public void DiscountPrice(int discount)     // 가격을 조정
        {
            this.price -= discount;
        }
        
        public void StockOut()      // 품절여부 변경 (재고 없음)
        {
            this.outOfStock = true;
        }
        
        public void StorageInWareHouse() // 품절여부 변경 (재고 있음)
        {
            this.outOfStock = false;
        }       
    }
}
