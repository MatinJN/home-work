using home_work_18._04._22.Models;
using System;

namespace home_work_18._04._22
{
//    Asagidaki parameterlerden ibret Employee class-i yaradirsini
//No - iscinin nomresi company-e elave edilme sirasina gore olur(company-e birinic elave edilen iscinin no deyrei 1,
//ikincide 2 olsun)
//Fullname
//Salary
//Position - iscinin sirketdeki vezifesi
//Asagidaki parameterlerden ibaret Company class-i yaradirsiniz:
//Name - Company adini ifade edir.Company adi boyuk herfle baslamalidir ve icerisinde herf,
//reqem ve bosluqdan basqa hec ne (simvol) ola bilmez
//Limit - Company-da ola bilecek maximum isci sayini ifade edir
//Employees - Company-in icerisindeki iscilerin siyahisini ifade edir (Employee typda array)
//AddEmoployee() - metod prameter olaraq Employee  typinda obyekt
//qebul edir ve onu eger Company - da yer varsa Company -nin Employees arrayine elave edir
//GetEmployees() - bu metod  Employee-larin siyahisini geriye qaytarir
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee fehle = new Employee
            {
                Fullname = "Matin Najafov",
                salary = 2000,
                position = "Mudur",

            };

            Company company = new Company
            {
                Name = "Code",
                limit = 18,
            };
            company.AddEmployee(fehle);

            
        }
    }
}
