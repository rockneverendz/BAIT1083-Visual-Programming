Select Start_Time, COUNT(Start_Time) as MostBookingPeriod
From RoomBooking
Where CheckIn_Date='2020-04-18'
Group by Start_Time
Order by COUNT(Start_Time) DESC;
