using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactProgram
{
    class Contact
    {
        String name, company, cellPhone, tel, mail;
        int age;
        public Contact(string name, int age, string company, string cellPhone, string tel, string mail)
        {
            this.name = name;
            this.age = age;
            this.company = company;
            this.cellPhone = cellPhone;
            this.tel = tel;
            this.mail = mail;
        }

        public override string ToString()
        {
            return "이름 : " + name + "\r\n나이 : " + age + "\r\n직장 : " + company + "\r\n휴대폰 : " + cellPhone + "\r\n전화 : " + tel + "\r\n메일 : " + mail;
        }
    }
}
