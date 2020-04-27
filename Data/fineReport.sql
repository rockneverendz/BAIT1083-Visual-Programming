--Select [Patron].Patron_ID, [Patron].[Name], COUNT([Return].Fine_Amount) as [Number of Fines Record], SUM([Return].Fine_Amount) as Total_Fine
--From CheckOutList
--INNER JOIN [Return] ON [Return].Rtn_ID = CheckOutList.Return_ID
--INNER JOIN [CheckOut] ON [CheckOut].Chk_ID = CheckOutList.Chk_ID
--INNER JOIN [Patron] ON [Patron].Patron_ID = [CheckOut].Patron_ID
--Group By [Patron].Patron_ID, [Patron].[Name]



Select SUM([Return].Fine_Amount) as Total
From [Return]
