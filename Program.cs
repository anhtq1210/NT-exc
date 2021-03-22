using System;
using System.Collections.Generic;
using System.Linq;

namespace C__Exc
{
   
    class Program
    {
        static void Main(string[] args)
        {
        Members member1 = new Members{ firstName="Chu",lastName="Ba Thong", gender="Male",dateOfBirth= new DateTime(1998,1,12), phoneNumber= "0985747474", birthPlace="Ha Noi",startDate = new DateTime(1998,1,12),endDate = new DateTime(1998,1,12) };
        Members member2 = new Members{ firstName="Chu",lastName="Chi Nhuoc", gender="Female",dateOfBirth= new DateTime(1998,1,12), phoneNumber= "0985747474", birthPlace="Hai Phong",startDate = new DateTime(1998,1,12),endDate = new DateTime(1998,1,12) };
        Members member3 = new Members{ firstName="Truong",lastName="Vo Ky", gender="Male",dateOfBirth= new DateTime(1997,1,12), phoneNumber= "0985747474", birthPlace="Bac Ninh",startDate = new DateTime(1998,1,12),endDate = new DateTime(1998,1,12) };
        Members member4 = new Members{ firstName="Au",lastName="Duong Phong", gender="Male",dateOfBirth= new DateTime(1996,1,12), phoneNumber= "0985747474", birthPlace="Ha Noi",startDate = new DateTime(1998,1,12),endDate = new DateTime(1998,1,12) };
        Members member5 = new Members{ firstName="Hoang",lastName="Dung", gender="Female",dateOfBirth= new DateTime(1999,1,12), phoneNumber= "0985747474", birthPlace="Ho Chi Minh",startDate = new DateTime(1998,1,12),endDate = new DateTime(1998,1,12) };
        List<Members> memberList =  new List<Members>();
        memberList.Add(member1);
        memberList.Add(member2);
        memberList.Add(member3);
        memberList.Add(member4);
        memberList.Add(member5);
        List<string> membersIsMale = new List<string>();
        List<string> listOfFullName = new List<string>();
        List<Members> bornIn1998 = new List<Members>();
        List<Members> bornBefore1998 = new List<Members>();
        List<Members> bornAfter1998 = new List<Members>();
        List<Members> joinBefore_22_03_2021 = new List<Members>();
        membersIsMale = memberList.Where ( s => s.gender == "Male")
                        .Select(s => s.firstName).ToList();
        Console.WriteLine(membersIsMale[0]);
        var theOldest = memberList.OrderBy (s => s.dateOfBirth).FirstOrDefault();
        listOfFullName = memberList.Select (s => s.firstName + "" + s.lastName).ToList();
        bornIn1998 = memberList.Where (s=> s.dateOfBirth.Year == 1998 ).ToList();
        bornBefore1998 = memberList.Where (s=> s.dateOfBirth.Year > 1998 ).ToList();
        bornAfter1998 = memberList.Where (s=> s.dateOfBirth.Year < 1998 ).ToList();
        var firstBornInHaNoi = memberList.Where(s => s.birthPlace == "Ha Noi").First();
        joinBefore_22_03_2021 = memberList.Where(s => DateTime.Compare(s.startDate, new DateTime(2021,3,21)) < 0 ).ToList();
        }
    }
}


