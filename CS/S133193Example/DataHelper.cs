using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace S133193Example
{
    class DataHelper
    {
        enum CustomerType { Person, Company };


        public static DataSet CreateDataBase()
        {
            DataTable SomeList = new DataTable();
            DataTable Orders = new DataTable();
            DataTable AnotherOrders = new DataTable();
            DataSet DataBase = new DataSet();

            SomeList.Columns.Add("CustomerId", typeof(string));
            SomeList.Columns.Add("FirstName", typeof(string));
            SomeList.Columns.Add("LastName", typeof(string));
            SomeList.Columns.Add("CustomerType", typeof(CustomerType));

            DataRow FirstCustomer = SomeList.NewRow();
            FirstCustomer[SomeList.Columns["CustomerId"]] = "Id31210";
            FirstCustomer[SomeList.Columns["FirstName"]] = "Alex";
            FirstCustomer[SomeList.Columns["LastName"]] = "Hunt";
            FirstCustomer[SomeList.Columns["CustomerType"]] = CustomerType.Person;
            SomeList.Rows.Add(FirstCustomer);

            DataRow SecondCustomer = SomeList.NewRow();
            SecondCustomer[SomeList.Columns["CustomerId"]] = "Id11210";
            SecondCustomer[SomeList.Columns["FirstName"]] = "bruce";
            SecondCustomer[SomeList.Columns["LastName"]] = "Wayne";
            SecondCustomer[SomeList.Columns["CustomerType"]] = CustomerType.Person;
            SomeList.Rows.Add(SecondCustomer);

            DataRow thirdCustomer = SomeList.NewRow();
            thirdCustomer[SomeList.Columns["CustomerId"]] = "Id17431";
            thirdCustomer[SomeList.Columns["FirstName"]] = "Jon";
            thirdCustomer[SomeList.Columns["LastName"]] = "Jons";
            thirdCustomer[SomeList.Columns["CustomerType"]] = CustomerType.Company;
            SomeList.Rows.Add(thirdCustomer);

            Orders.Columns.Add("CustomerId", typeof(string));
            Orders.Columns.Add("Product", typeof(String));
            Orders.Columns.Add("Date", typeof(DateTime));

            DataRow Order1 = Orders.NewRow();
            Order1[Orders.Columns["CustomerId"]] = "Id31210";
            Order1[Orders.Columns["Product"]] = "Potato 150 kg";
            Order1[Orders.Columns["Date"]] = DateTime.Today;
            Orders.Rows.Add(Order1);

            DataRow Order2 = Orders.NewRow();
            Order2[Orders.Columns["CustomerId"]] = "Id31210";
            Order2[Orders.Columns["Product"]] = "Onion 13 kg";
            Order2[Orders.Columns["Date"]] = DateTime.Today;
            Orders.Rows.Add(Order2);

            DataRow Order3 = Orders.NewRow();
            Order3[Orders.Columns["CustomerId"]] = "Id11210";
            Order3[Orders.Columns["Product"]] = "Batarang 150 pcs";
            Order3[Orders.Columns["Date"]] = DateTime.Today;
            Orders.Rows.Add(Order3);

            DataRow Order4 = Orders.NewRow();
            Order4[Orders.Columns["CustomerId"]] = "Id17431";
            Order4[Orders.Columns["Product"]] = "Mineral Water 50 bottles";
            Order4[Orders.Columns["Date"]] = DateTime.Today;
            Orders.Rows.Add(Order4);

            DataRow Order5 = Orders.NewRow();
            Order5[Orders.Columns["CustomerId"]] = "Id17431";
            Order5[Orders.Columns["Product"]] = "and something";
            Order5[Orders.Columns["Date"]] = DateTime.Today;
            Orders.Rows.Add(Order5);
            
            AnotherOrders.Columns.Add("CustomerId",typeof(string));
            AnotherOrders.Columns.Add("Orders",typeof(string));

            DataRow AnotherOrder1 = AnotherOrders.NewRow();
            AnotherOrder1[AnotherOrders.Columns["CustomerId"]] = "Id31210";
            AnotherOrder1[AnotherOrders.Columns["Orders"]] = "Mineral water 50 bottles";
            AnotherOrders.Rows.Add(AnotherOrder1);
            DataRow AnotherOrder2 = AnotherOrders.NewRow();
            AnotherOrder2[AnotherOrders.Columns["CustomerId"]] = "Id31210";
            AnotherOrder2[AnotherOrders.Columns["Orders"]] = "Potato 30 kg";
            AnotherOrders.Rows.Add(AnotherOrder2);

            DataBase.Tables.Add(SomeList);
            DataBase.Tables.Add(Orders);
            DataBase.Tables.Add(AnotherOrders);

            DataRelation dr = new DataRelation("Orders", DataBase.Tables[0].Columns["CustomerId"], DataBase.Tables[1].Columns["CustomerId"]);
            DataRelation relation = new DataRelation("PreviosOrders",DataBase.Tables[0].Columns["CustomerId"],DataBase.Tables[2].Columns["CustomerId"]);
            DataBase.Tables[1].ParentRelations.Add(dr);
            DataBase.Tables[2].ParentRelations.Add(relation);

            return DataBase;
        }
    }
}
