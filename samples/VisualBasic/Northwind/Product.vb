﻿Imports System
Imports System.Collections.ObjectModel
Imports DbExtensions

Namespace Northwind

   <Table(Name:="Products")>
   Partial Public Class Product

      <Column>
      Public Property CategoryID As Integer?

      <Column>
      Public Property Discontinued As Boolean

      <Column(IsPrimaryKey:=True, IsDbGenerated:=True)>
      Public Property ProductID As Integer

      <Column>
      Public Property ProductName As String

      <Column>
      Public Property QuantityPerUnit As String

      <Column>
      Public Property ReorderLevel As Short?

      <Column>
      Public Property SupplierID As Integer?

      <Column>
      Public Property UnitPrice As Decimal?

      <Column>
      Public Property UnitsInStock As Short?

      <Column>
      Public Property UnitsOnOrder As Short?

      <Association(ThisKey:=NameOf(CategoryID))>
      Public Property Category As Category

      <Association(OtherKey:=NameOf(OrderDetail.ProductID))>
      Public ReadOnly Property OrderDetails As New Collection(Of OrderDetail)

      <Association(ThisKey:=NameOf(SupplierID))>
      Public Property Supplier As Supplier

   End Class

End Namespace

