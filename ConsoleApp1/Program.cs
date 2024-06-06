
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

CourseManager courseManager = new(new EfCourseDal());

List<Course> courses2 = courseManager.GetAll();
    for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Kodlama bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678999";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = 123456;

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345678990";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = 123456;

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Runway Dijital";
customer3.CustomerNumber = 645321;
customer3.TaxNumber = "312321412312";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = 3213421;
customer4.TaxNumber = "54365768756";


BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//Polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}