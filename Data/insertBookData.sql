
/*Insert Admin*/
SET IDENTITY_INSERT [dbo].[AdminLib] ON
INSERT INTO [dbo].[AdminLib] ([Admin_ID], [Name], [Password]) VALUES (1000, N'admin', N'admin123')
INSERT INTO [dbo].[AdminLib] ([Admin_ID], [Name], [Password]) VALUES (1001, N'nbuser', N'nbuser123')
INSERT INTO [dbo].[AdminLib] ([Admin_ID], [Name], [Password]) VALUES (1002, N'cisco', N'class')
SET IDENTITY_INSERT [dbo].[AdminLib] OFF

/*Insert Book*/
SET IDENTITY_INSERT [dbo].[Book] ON
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1000, N'Assembly language for x86 processors', N'Kip R. Irvine.', N'Programming', N'Hoboken, NJ : Pearson, c2020.', 2020, 15, N'005.265 IRV')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1001, N'Hands-on game development patterns with Unity 2019 : create engaging games by using industry-standard design patterns with C#', N'David Baron.', N'Programming', N'Birmingham : Packt, 2019.', 2019, 3, N'794.815 26 BAR')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1002, N'Raspberry Pi3 : enchanted guide for starters', N'Thomas Charleston.', N'Programming ', N'[S.l. : s.n.], c2017.', 2017, 2, N'004.165 CHA')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1003, N'Android programming concepts ', N'Trish Cornez, Richard Cornez.', N'Programming', N'Burlington, MA : Jones & Bartlett Learning, c2017.', 2017, 8, N'005.258 COR')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1004, N'Beginning Android programming with Android Studio ', N'J. F. DiMarzio.', N'Programming', N'Indianapolis, Indiana : Wrox, 2017.', 2017, 4, N'005.301 COR')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1005, N'Warwickshire : In Easy Steps, c2018.', N'Matt Neuburg', N'Programming', N'Sebastopol, CA : O''Reilly Media, c2017.', 2017, 2, N'005.268 NEU')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1006, N'Beginning Swift games development for iOS : develop 2D and 3D games using Apple''s SceneKit and SpriteKit', N'James Goodwill, Wesley Matlock.', N'Programming', N'New York : Apress, c2017.', 2017, 2, N'794.815 26 GOO')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1007, N'Real-time embedded systems : design principles and engineering practices', N'Xiaocong Fan.', N'Programming', N'Boston, MA : Newnes, Elsevier, c2015.', 2017, 3, N'006.22 FAN')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1008, N'Beginning Python games development : with PyGame', N'Harrison Kinsley, Will McGugan.', N'Programming', N'[New York] : Apress, c2015.', 2015, 1, N'794.815 262 KIN')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1009, N'Programming fundamentals using Java : a game application approach', N'William McAllister, S. Jane Fritz, St Joseph''s College, New York.', N'Programming', N'Dulles, Virginia ; Boston, [Massachusetts] ; New Delhi, [India] : Mercury Learning and Information, 2015.', 2015, 3, N'007.22 AOI')

INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1010, N'Game AI pro 2 : collected wisdom of game AI professionals', N'Steven Rabin.', N'Programming', N'Boca Raton, FL : CRC Press, c2015.', 2015, 2, N'794.815 36 GAM')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1011, N'Discrete mathematics with applications', N'Susanna S. Epp.', N'Mathematics', N'Boston, MA : Cengage, c2020.', 2020, 13, N'511 EPP')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1012, N'Advanced structural analysis with MATLAB', N'Srinivasan Chandrasekaran.', N'Mathematics', N'Boca Raton, FL : CRC Press, c2019.', 2019, 1, N'624.170 285 536 CHA')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1013, N'Discrete mathematics and its applications', N'Kenneth H. Rosen.', N'Mathematics', N'New York : McGraw-Hill Education, c2019.', 2019, 13, N'511 ROS 8th ed.')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1014, N'Quantum mechanics : axiomatic theory with modern applications', N'Nelson Bolivar, Gabriel Abellan.', N'Mathematics', N'Oakville, ON : Apple Academic Press, c2018.', 2018, 1, N'530.12 BOL')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1015, N'Fundamentals of discrete math for computer science : a problem-solving primer', N'Tom Jenkyns, Ben Stephenson.', N'Mathematics', N'Cham, Switzerland : Springer, c2018.', 2018, 4, N'004.015 1 JEN 2nd ed.')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1016, N'R for data analysis in easy steps', N'Mike McGrath.', N'Mathematics', N'Warwickshire : In Easy Steps, c2018.', 2018, 1, N'006.312 MCG')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1017, N'The statistical foundations of entropy', N'John D. Ramshaw.', N'Mathematics', N'Singapore : World Scientific, c2018.', 2018, 1, N'536.730 151 95 RAM')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1018, N'Discrete structures, logic, and computability', N'James L. Hein.', N'Mathematics', N'Burlington, MA : Jones & Bartlett Learning, c2017.', 2017, 1, N'004.015 1 HEI 4th ed.')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1019, N'Essentials of discrete mathematics', N'David J. Hunter, Westmont College.', N'Mathematics', N'Burlington, MA : Jones & Bartlett Learning, c2017.', 2017, 1, N'511.1 HUN 3rd ed.')
INSERT INTO [dbo].[Book] ([Book_Id], [Book_title], [Author], [Category], [Publication], [Year_Publish], [Copies], [Call_no]) VALUES (1020, N'Questions & solutions : advanced calculus for engineering', N'Yuzainee Md Yusoff, Faridah Basaruddin, Norhalena Mohd Nor.', N'Mathematics', N'Shah Alam : Oxford Fajar, 2017.', 2017, 2, N'515.076 YUZ')
SET IDENTITY_INSERT [dbo].[Book] OFF

/*Insert Copies */
SET IDENTITY_INSERT [dbo].[Copies] ON
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1001, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1002, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1003, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1004, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1005, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1006, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1007, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1008, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1009, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1010, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1011, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1012, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1013, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1014, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1015, 1000, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1016, 1001, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1017, 1001, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1018, 1001, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1019, 1002, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1020, 1002, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1021, 1003, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1022, 1003, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1023, 1003, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1024, 1003, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1025, 1003, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1026, 1003, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1027, 1003, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1028, 1003, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1029, 1004, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1030, 1004, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1031, 1004, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1032, 1004, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1033, 1005, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1034, 1005, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1035, 1006, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1036, 1006, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1037, 1007, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1038, 1007, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1039, 1007, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1040, 1008, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1041, 1009, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1042, 1009, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1043, 1009, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1044, 1010, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1045, 1010, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1046, 1011, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1047, 1011, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1048, 1011, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1049, 1011, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1050, 1011, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1051, 1011, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1052, 1011, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1053, 1011, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1054, 1011, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1055, 1011, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1056, 1011, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1057, 1011, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1058, 1011, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1059, 1012, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1060, 1013, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1061, 1013, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1062, 1013, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1063, 1013, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1064, 1013, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1065, 1013, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1066, 1013, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1067, 1013, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1068, 1013, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1069, 1013, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1070, 1013, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1071, 1013, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1072, 1013, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1073, 1014, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1074, 1015, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1075, 1015, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1076, 1015, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1077, 1015, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1078, 1016, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1079, 1017, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1080, 1018, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1081, 1019, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1082, 1020, N'Available')
INSERT INTO [dbo].[Copies] ([Copy_ID], [Book_ID], [Status]) VALUES (1083, 1020, N'Available')
SET IDENTITY_INSERT [dbo].[Copies] OFF

/*Insert Patron*/
SET IDENTITY_INSERT [dbo].[Patron] ON
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1001, N'Duke Fairnie', N'RSD', N'912 792 7558', N'124 Jln Sek.Keb.Dato Hamid 17000 Pasir Mas Pasir Mas Kelantan 17000 Malaysia Pasir Mas Kelantan 1700', N'dfairnie0@chronoengine.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1002, N'Gay Kirtlan', N'RSD', N'625 542 8534', N'215 G Jalan Miri-Mintulu Km 2 98000 Miri Sarawak Malaysia', N'gkirtlan1@hugedomains.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1003, N'Barbabas Varns', N'RSD', N'380 879 5916', N'52 Jln Tun Mohd Fuad 1 Taman Tun Dr Ismail 60000 Wilayah Persekutuan 60000 Malaysia 60000 Malaysia', N'bvarns2@tamu.edu')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1004, N'Terri Plott', N'RSD', N'616 100 1396', N'31 1 Jalan Sr8/4 Taman Putra Indah Serdang Jaya Seri Kembangan 43300 Malaysia Seri Kembangan 43300', N'tplott3@pcworld.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1005, N'Tabina Abilowitz', N'RSD', N'973 430 8867', N'215 G Jalan Miri-Mintulu Km 2 98000 Miri Sarawak Malaysia', N'tabilowitz4@statcounter.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1006, N'Gabi Kinkead', N'RSD', N'313 155 9264', N'8 Jalan Timor 19 Taman Timor 81300 Johor Malaysia', N'gkinkead5@unc.edu')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1007, N'Rory Hurlston', N'RSD', N'130 295 0010', N'4012 Jln Mentakab Batu 12 28500 Lanchang 28500 Malaysia Lanchang Pahang 28500 Malaysia', N'rhurlston6@tmall.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1008, N'Starla Lead', N'RSD', N'481 973 1447', N'No. 53 B Jln Telawi 3 Bangsar Baru 59100 Wilayah Persekutuan 59100 Malaysia', N'slead7@flickr.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1009, N'Leslie Corde', N'RSD', N'894 358 6743', N'6 Jln Selaseh 18 Taman Selaseh 68100 Gombak 68100 Malaysia Batu Caves 68100 Malaysia', N'lcorde8@buzzfeed.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1010, N'Pen Freddi', N'RSD', N'102 684 4694', N'13 Jln 4 Taman Kuala 45000 Kuala Kuala 45000 Malaysia Kuala 45000 Malaysia', N'pfreddi9@ibm.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1011, N'Joseph Gambles', N'RSD', N'426 208 0803', N'2294 45000 Kuala Malaysia Kuala 45000 Malaysia', N'jgamblesa@scientificamerican.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1012, N'Gwendolyn Hopfner', N'RSD', N'175 667 2058', N'19-1 Taman Mawar 72200 Bukit Kikir Negeri Sembilan Malaysia', N'ghopfnerb@angelfire.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1013, N'Pippy Cinelli', N'RSD', N'822 179 3249', N'82, Jalan Raja Chulan, Wilayah Persekutuan 50200', N'pcinellic@imgur.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1014, N'Trix Kilmaster', N'RSD', N'204 732 8618', N'40 Jln Ss2/24 Ss2 47300Petaling Jaya 47300 Malaysia 47300 Malaysia', N'tkilmasterd@lulu.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1015, N'Jerrie Norbury', N'RSD', N'205 607 2647', N'11 Jln Permai Taman Sedili 81910 Kota Tinggi Kota Tinggi Johor 81910 Malaysia Kota Tinggi Johor 8191', N'jnorburye@indiatimes.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1016, N'Tracy Calvert', N'RSD', N'732 496 6521', N'2 Jln Sri Perkasa Dua/1 Taman Tampoi Utama 81200 Johor 81200 Malaysia Johor 81200 Malaysia', N'tcalvertf@bloglines.com')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1017, N'Dicky Lewty', N'RSD', N'159 234 2467', N'No. 2994 Kampung Sungai Penchala 60000 Wilayah Persekutuan 60000 Malaysia', N'dlewtyg@census.gov')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1018, N'Jyoti Ivanshintsev', N'RSD', N'537 833 1684', N'No. 2 Jln Sepana 15/3 Seksyen 15 40000 Shah Alam Shah Alam 40000 Malaysia', N'jivanshintsevh@census.gov')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1019, N'Idelle Bellino', N'RSD', N'176 997 0485', N'65 Jalan Emas Satu Taman Sri Skudai 81300 Skudai Johor Malaysia', N'ibellinoi@unesco.org')
INSERT INTO [dbo].[Patron] ([Patron_ID], [Name], [Course], [PhoneNo], [Address], [Email]) VALUES (1020, N'Arabel Pozzo', N'RSD', N'217 256 8858', N'No. 1908 Jln Bukit Kemuning Batu 7 Bukit Kemuning 42450 Shah Alam Shah Alam 42450 Malaysia', N'apozzoj@51.la')
SET IDENTITY_INSERT [dbo].[Patron] OFF

/*Insert room*/
SET IDENTITY_INSERT [dbo].[Room] ON
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1001, 4)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1002, 4)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1003, 4)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1004, 4)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1005, 4)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1006, 6)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1007, 6)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1008, 6)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1009, 6)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1010, 6)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1011, 8)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1012, 8)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1013, 8)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1014, 8)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1015, 8)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1016, 8)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1017, 8)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1018, 8)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1019, 8)
INSERT INTO [dbo].[Room] ([Room_Id], [Size]) VALUES (1020, 8)
SET IDENTITY_INSERT [dbo].[Room] OFF


/*Insert Checkout */
SET IDENTITY_INSERT [dbo].[CheckOut] ON
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1001, 1001, N'2019-03-25', N'2019-03-25', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1002, 1001, N'2019-12-18', N'2019-12-18', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1003, 1001, N'2019-04-24', N'2019-04-24', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1004, 1001, N'2019-06-19', N'2019-06-19', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1005, 1001, N'2020-02-09', N'2020-02-09', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1006, 1001, N'2019-09-09', N'2019-09-09', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1007, 1001, N'2020-02-27', N'2020-02-27', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1008, 1002, N'2019-08-19', N'2019-08-19', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1009, 1002, N'2019-07-23', N'2019-07-23', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1010, 1002, N'2019-05-11', N'2019-05-11', NULL)

INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1011, 1003, N'2019-12-23', N'2019-12-23', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1012, 1003, N'2019-12-19', N'2019-12-19', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1013, 1003, N'2019-11-26', N'2019-11-26', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1014, 1003, N'2019-05-07', N'2019-05-07', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1015, 1003, N'2020-03-17', N'2020-03-17', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1016, 1004, N'2019-09-25', N'2019-09-25', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1017, 1004, N'2019-05-21', N'2019-05-21', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1018, 1004, N'2019-12-19', N'2019-12-19', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1019, 1005, N'2019-10-15', N'2019-10-15', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1020, 1005, N'2020-01-22', N'2020-01-22', NULL)

INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1021, 1006, N'2019-05-31', N'2019-05-31', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1022, 1007, N'2019-10-04', N'2019-10-04', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1023, 1007, N'2020-02-23', N'2020-02-23', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1024, 1007, N'2020-02-11', N'2020-02-11', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1025, 1008, N'2019-03-27', N'2019-03-27', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1026, 1009, N'2019-04-19', N'2019-04-19', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1027, 1009, N'2019-08-06', N'2019-08-06', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1028, 1010, N'2019-08-19', N'2019-08-19', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1029, 1010, N'2019-06-20', N'2019-06-20', NULL)
INSERT INTO [dbo].[CheckOut] ([Chk_ID], [Patron_ID], [Issue_Date], [Due_Date], [Rtn_ID]) VALUES (1030, 1010, N'2019-05-07', N'2019-05-07', NULL)
SET IDENTITY_INSERT [dbo].[CheckOut] OFF


/*Insert CheckOutList*/
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1001, 1029)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1001, 1002)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1001, 1080)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1002, 1054)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1002, 1033)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1002, 1020)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1002, 1001)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1003, 1032)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1003, 1012)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1004, 1035)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1004, 1044)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1005, 1047)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1005, 1009)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1005, 1015)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1005, 1068)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1006, 1055)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1007, 1026)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1008, 1001)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1008, 1065)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1009, 1061)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1009, 1002)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1010, 1031)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1010, 1078)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1010, 1060)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1011, 1009)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1011, 1012)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1012, 1003)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1012, 1055)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1012, 1036)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1012, 1065)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1013, 1047)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1014, 1068)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1015, 1013)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1016, 1065)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1016, 1037)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1016, 1041)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1017, 1024)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1017, 1004)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1017, 1076)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1018, 1081)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1018, 1066)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1018, 1036)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1018, 1048)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1019, 1017)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1019, 1047)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1020, 1046)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1020, 1036)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1021, 1083)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1021, 1050)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1021, 1060)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1021, 1012)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1022, 1045)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1023, 1050)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1024, 1035)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1024, 1029)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1025, 1050)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1025, 1012)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1026, 1071)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1026, 1038)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1026, 1069)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1027, 1047)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1027, 1022)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1028, 1030)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1028, 1035)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1028, 1012)
INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1028, 1054)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1029, 1050)

INSERT INTO [dbo].[CheckOutList] ([Chk_ID], [Copy_ID]) VALUES (1030, 1010)

/*Insert RoomBooking*/
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1001, 1001, N'2019-05-14 08:50:26', N'2019-05-14 09:00:00', N'2019-05-14 11:00:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1001, 1001, N'2019-10-02 09:50:26', N'2019-10-02 10:00:00', N'2019-10-02 12:00:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1001, 1006, N'2019-08-28 23:25:45', N'2019-08-28 11:30:00', N'2019-08-28 13:30:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1001, 1008, N'2020-02-24 16:20:17', N'2020-02-24 16:30:00', N'2020-02-24 18:30:00')

INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1002, 1002, N'2020-03-21 15:02:59', N'2020-03-21 15:30:00', N'2020-03-21 17:30:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1002, 1010, N'2020-02-17 16:53:25', N'2020-02-17 17:00:00', N'2020-02-17 19:00:00')

INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1003, 1020, N'2020-02-09 09:57:23', N'2020-02-09 10:00:00', N'2020-02-09 11:00:00')

INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1004, 1002, N'2019-09-22 08:03:48', N'2019-09-22 08:30:00', N'2019-09-22 10:30:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1004, 1003, N'2019-04-17 08:53:59', N'2019-04-17 09:00:00', N'2019-04-17 11:00:00')

INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1005, 1001, N'2020-01-16 12:10:18', N'2020-01-16 12:30:00', N'2020-01-16 14:30:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1005, 1019, N'2019-07-21 14:24:17', N'2019-07-21 14:30:00', N'2019-07-21 16:30:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1005, 1019, N'2019-08-11 15:45:13', N'2019-08-11 16:00:00', N'2019-08-11 18:00:00')

INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1006, 1015, N'2020-03-18 08:02:27', N'2020-03-18 08:30:00', N'2020-03-18 10:30:00')

INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1007, 1016, N'2019-04-05 10:36:45', N'2019-04-05 11:00:00', N'2019-04-05 13:00:00')

INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1008, 1017, N'2019-07-14 13:55:29', N'2019-07-14 14:00:00', N'2019-07-14 16:00:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1008, 1018, N'2019-07-15 11:42:06', N'2019-07-15 12:00:00', N'2019-07-15 14:00:00')

INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1009, 1001, N'2019-04-10 16:58:44', N'2019-04-10 17:00:00', N'2019-04-10 19:00:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1009, 1019, N'2019-04-02 11:16:10', N'2019-04-02 11:30:00', N'2019-04-02 13:30:00')

INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1010, 1004, N'2019-12-19 13:02:00', N'2019-12-19 13:30:00', N'2019-12-19 15:30:00')

INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1011, 1004, N'2019-10-28 17:18:41', N'2019-10-28 17:30:00', N'2019-10-28 19:30:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1011, 1005, N'2020-03-09 08:38:18', N'2020-03-09 09:00:00', N'2020-03-09 11:00:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1011, 1006, N'2020-02-08 15:37:38', N'2020-02-08 16:00:00', N'2020-02-08 18:00:00')

INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1012, 1007, N'2019-05-05 11:04:47', N'2019-05-05 11:00:00', N'2019-05-05 13:00:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1012, 1007, N'2019-11-25 10:46:37', N'2019-11-25 11:00:00', N'2019-11-25 13:00:00')

INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1013, 1001, N'2019-04-09 11:10:16', N'2019-04-09 11:30:00', N'2019-04-09 13:30:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1013, 1002, N'2019-10-05 13:57:46', N'2019-10-05 14:00:00', N'2019-10-05 16:00:00')
INSERT INTO [dbo].[RoomBooking] ([Patron_ID], [Room_ID], [Date_Time], [CheckIn_Date], [CheckOut_Date]) VALUES (1013, 1020, N'2019-12-13 12:55:15', N'2019-12-13 13:00:00', N'2019-12-13 15:00:00')

/*Insert Return*/
/*In Progress...*/



/****/