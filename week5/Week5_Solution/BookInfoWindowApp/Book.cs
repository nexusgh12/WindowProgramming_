using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInfoWindowApp
{
    class Book
    {
        //멤버 변수
        private string title;
        private string author;
        private int page;
        private string ISBN;
        private string publisher;

        // 생성자
        public Book(string title, string author, int page, string ISBN, string publisher)
        {
            this.title = title;
            this.author = author;
            this.page = page;
            this.ISBN = ISBN;
            this.publisher = publisher;
        }

        //title에 대한 get/set 프로퍼티
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                this.title = value;
            }
        }

        //ToString 메소드
        public override string ToString()
        {
            return "책 제목 : " + title + "\r\n책 저자 : " + author + "\r\n쪽 수 :" + page + "\r\nISBN : " + ISBN + "\r\n출판사 : " + publisher;
        }
    }
}
