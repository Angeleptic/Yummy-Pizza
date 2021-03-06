USE [PizzaShop]
GO
/****** Object:  StoredProcedure [dbo].[getToppingDetails]    Script Date: 2020/01/19 11:22:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[getToppingDetails]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 
		Topping.Topping_ID, Topping.Topping_Name, Price.Price_ID, Price.Price
	FROM
		Topping, Topping_Price, Price
	WHERE
		Topping.Topping_ID = Topping_Price.Topping_ID AND Price.Price_ID = Topping_Price.Price_ID
		AND Topping_Price_Date = (SELECT MAX(Topping_Price.Topping_Price_Date)
								FROM Topping_Price)
END
