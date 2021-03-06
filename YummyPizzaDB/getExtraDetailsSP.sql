USE [PizzaShop]
GO
/****** Object:  StoredProcedure [dbo].[getExtraDetails]    Script Date: 2020/01/19 11:20:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[getExtraDetails]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 
		Extra.Extra_ID, Extra.Extra_Name, Price.Price_ID, Price.Price
	FROM
		Extra, Extra_Price, Price
	WHERE
		Extra.Extra_ID = Extra_Price.Extra_ID AND Price.Price_ID = Extra_Price.Price_ID
		AND Extra_Price_Date = (SELECT MAX(Extra_Price.Extra_Price_Date)
								FROM Extra_Price)
END
