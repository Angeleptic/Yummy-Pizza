USE [PizzaShop]
GO
/****** Object:  StoredProcedure [dbo].[getPizzaDetails]    Script Date: 2020/01/19 11:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[getPizzaDetails]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 
		Pizza.Pizza_ID, Pizza.Pizza_Name, Pizza.Pizza_Desc, Price.Price_ID, Price.Price
	FROM
		Pizza, Pizza_Price, Price
	WHERE
		Pizza.Pizza_ID = Pizza_Price.Pizza_ID AND Price.Price_ID = Pizza_Price.Price_ID
		AND Pizza_Price_Date = (SELECT MAX(Pizza_Price.Pizza_Price_Date)
								FROM Pizza_Price)
END
