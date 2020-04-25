Select Patron.Name, COUNT(CheckOut.Chk_ID) as MostCheckedOutPatron
From CheckOut
Inner Join Patron ON Patron.Patron_ID = CheckOut.Patron_ID
Group by Patron.Name
Order by MostCheckedOutPatron DESC