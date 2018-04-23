Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Data

Namespace S133193Example
	Friend Class DataHelper
		Private Enum CustomerType
			Person
			Company
		End Enum


		Public Shared Function CreateDataBase() As DataSet
			Dim SomeList As New DataTable()
			Dim Orders As New DataTable()
			Dim AnotherOrders As New DataTable()
			Dim DataBase As New DataSet()

			SomeList.Columns.Add("CustomerId", GetType(String))
			SomeList.Columns.Add("FirstName", GetType(String))
			SomeList.Columns.Add("LastName", GetType(String))
			SomeList.Columns.Add("CustomerType", GetType(CustomerType))

			Dim FirstCustomer As DataRow = SomeList.NewRow()
			FirstCustomer(SomeList.Columns("CustomerId")) = "Id31210"
			FirstCustomer(SomeList.Columns("FirstName")) = "Alex"
			FirstCustomer(SomeList.Columns("LastName")) = "Hunt"
			FirstCustomer(SomeList.Columns("CustomerType")) = CustomerType.Person
			SomeList.Rows.Add(FirstCustomer)

			Dim SecondCustomer As DataRow = SomeList.NewRow()
			SecondCustomer(SomeList.Columns("CustomerId")) = "Id11210"
			SecondCustomer(SomeList.Columns("FirstName")) = "bruce"
			SecondCustomer(SomeList.Columns("LastName")) = "Wayne"
			SecondCustomer(SomeList.Columns("CustomerType")) = CustomerType.Person
			SomeList.Rows.Add(SecondCustomer)

			Dim thirdCustomer As DataRow = SomeList.NewRow()
			thirdCustomer(SomeList.Columns("CustomerId")) = "Id17431"
			thirdCustomer(SomeList.Columns("FirstName")) = "Jon"
			thirdCustomer(SomeList.Columns("LastName")) = "Jons"
			thirdCustomer(SomeList.Columns("CustomerType")) = CustomerType.Company
			SomeList.Rows.Add(thirdCustomer)

			Orders.Columns.Add("CustomerId", GetType(String))
			Orders.Columns.Add("Product", GetType(String))
			Orders.Columns.Add("Date", GetType(DateTime))

			Dim Order1 As DataRow = Orders.NewRow()
			Order1(Orders.Columns("CustomerId")) = "Id31210"
			Order1(Orders.Columns("Product")) = "Potato 150 kg"
			Order1(Orders.Columns("Date")) = DateTime.Today
			Orders.Rows.Add(Order1)

			Dim Order2 As DataRow = Orders.NewRow()
			Order2(Orders.Columns("CustomerId")) = "Id31210"
			Order2(Orders.Columns("Product")) = "Onion 13 kg"
			Order2(Orders.Columns("Date")) = DateTime.Today
			Orders.Rows.Add(Order2)

			Dim Order3 As DataRow = Orders.NewRow()
			Order3(Orders.Columns("CustomerId")) = "Id11210"
			Order3(Orders.Columns("Product")) = "Batarang 150 pcs"
			Order3(Orders.Columns("Date")) = DateTime.Today
			Orders.Rows.Add(Order3)

			Dim Order4 As DataRow = Orders.NewRow()
			Order4(Orders.Columns("CustomerId")) = "Id17431"
			Order4(Orders.Columns("Product")) = "Mineral Water 50 bottles"
			Order4(Orders.Columns("Date")) = DateTime.Today
			Orders.Rows.Add(Order4)

			Dim Order5 As DataRow = Orders.NewRow()
			Order5(Orders.Columns("CustomerId")) = "Id17431"
			Order5(Orders.Columns("Product")) = "and something"
			Order5(Orders.Columns("Date")) = DateTime.Today
			Orders.Rows.Add(Order5)

			AnotherOrders.Columns.Add("CustomerId",GetType(String))
			AnotherOrders.Columns.Add("Orders",GetType(String))

			Dim AnotherOrder1 As DataRow = AnotherOrders.NewRow()
			AnotherOrder1(AnotherOrders.Columns("CustomerId")) = "Id31210"
			AnotherOrder1(AnotherOrders.Columns("Orders")) = "Mineral water 50 bottles"
			AnotherOrders.Rows.Add(AnotherOrder1)
			Dim AnotherOrder2 As DataRow = AnotherOrders.NewRow()
			AnotherOrder2(AnotherOrders.Columns("CustomerId")) = "Id31210"
			AnotherOrder2(AnotherOrders.Columns("Orders")) = "Potato 30 kg"
			AnotherOrders.Rows.Add(AnotherOrder2)

			DataBase.Tables.Add(SomeList)
			DataBase.Tables.Add(Orders)
			DataBase.Tables.Add(AnotherOrders)

			Dim dr As New DataRelation("Orders", DataBase.Tables(0).Columns("CustomerId"), DataBase.Tables(1).Columns("CustomerId"))
			Dim relation As New DataRelation("PreviosOrders",DataBase.Tables(0).Columns("CustomerId"),DataBase.Tables(2).Columns("CustomerId"))
			DataBase.Tables(1).ParentRelations.Add(dr)
			DataBase.Tables(2).ParentRelations.Add(relation)

			Return DataBase
		End Function
	End Class
End Namespace
