Select Copies.Book_ID, Book.Book_title, COUNT(CheckOut.Chk_ID) as MostCheckedOutBook
From CheckOutList
Inner Join CheckOut ON CheckOutList.Chk_ID = CheckOut.Chk_ID
Inner Join Copies ON CheckOutList.Copy_ID = Copies.Copy_ID 
Inner Join Book On Copies.Book_ID = Book.Book_ID
Group by Copies.Book_ID, Book.Book_title


