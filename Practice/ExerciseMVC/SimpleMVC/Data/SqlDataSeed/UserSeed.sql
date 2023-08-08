USE SimpleMvcDB
GO
​
INSERT INTO tbl_users(UserName,UserEmail,Password)
VALUES('naumche', 'naumche@gmail.com', 'Joshevski7132#')
​
INSERT INTO tbl_users(UserName,UserEmail,Password)
VALUES('john', 'johnpeters@gmail.com', 'Peters7111*')
​
INSERT INTO tbl_users(UserName,UserEmail,Password)
VALUES('freddy', 'loom@gmail.com', 'loom7162#')
​
INSERT INTO tbl_users(UserName,UserEmail,Password)
VALUES('alex', 'dunkman@gmail.com', 'dunkman7112*')
​
INSERT INTO tbl_users(UserName,UserEmail,Password)
VALUES('tonny', 'balboa@gmail.com', 'balboa7132#')
​
SELECT * FROM tbl_users


INSERT INTO tbl_product_review VALUES
--USER 1
(10,1,3.5),
(11,1,5),
(15,1,5),
(17,1,4.5),
(8,1,3),
(9,1,2.5),
--USER 2
(13,2,3.5),
(9,2,5),
(17,2,5),
(14,2,4.5),
(5,2,3),
(6,2,2.5),
--USER 3
(15,3,3.5),
(13,3,5),
(6,3,5),
(11,3,4.5),
(12,3,3),
(14,3,2.5),
--USER 4
(19,4,3.5),
(16,4,5),
(6,4,5),
(5,4,4.5),
(9,4,3),
(10,4,2.5),
--USER 5
(9,5,3.5),
(7,5,5),
(13,5,5),
(14,5,4.5),
(12,5,3),
(20,5,2.5)