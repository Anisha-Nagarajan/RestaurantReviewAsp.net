CREATE TABLE Registration
(
UserName VARCHAR(30) PRIMARY KEY,
Password VARCHAR(30) UNIQUE NOT NULL,
Email VARCHAR(55) unique not null,
Street VARCHAR(30) NOT NULL,
City VARCHAR(30) NOT NULL,
State VARCHAR(30) NOT NULL,  
Pincode NUMERIC(6) NOT NULL,
Country VARCHAR(30) NOT NULL,
PhoneNumber NUMERIC(10) unique NOT NULL
)

INSERT INTO Registration VALUES('Akhil','akhil1234','akhilnagarajan@gmail.com','Gandhi Street','Salem','Tamil Nadu','636008','India','8903723179'),
('Rajee','Rajee1234','rajeenagarajan@gmail.com','Anbu Nagar','Salem','Tamil Nadu','636008','India','7338383002')

DROP TABLE Registration
CREATE PROCEDURE sp_View
AS
BEGIN
SELECT * FROM Registration
END
DROP PROCEDURE sp_View
CREATE PROCEDURE sp_Delete
(
@UserName VARCHAR(30)
)
AS
BEGIN
DELETE FROM Registration WHERE UserName = @UserName
END
DROP PROCEDURE sp_Delete
sp_Delete 'ilakiya'
CREATE PROCEDURE sp_Update
(
@UserName VARCHAR(30),
@Password VARCHAR(30),
@Email VARCHAR(55),
@Street VARCHAR(30),
@City VARCHAR(30),
@State VARCHAR(30),
@Pincode NUMERIC(6),
@Country VARCHAR(30),
@PhoneNumber NUMERIC(10)
)
AS
BEGIN
UPDATE Registration SET UserName=@UserName,Password=@Password,Email=@Email,Street=@Street,City=@City,
State=@State,Pincode=@Pincode,Country=@Country,PhoneNumber=@PhoneNumber WHERE UserName=@UserName
END

sp_Update 'Rajee','Rajee1234','rajeenagarajan@gmail.com','Anbu Nagar','Erode','Tamil Nadu','636008','India','7338383002' 
CREATE PROCEDURE sp_Select
(
@UserName VARCHAR(25),
@Password VARCHAR(25)
)
AS
BEGIN
IF((SELECT COUNT(UserName) FROM Registration WHERE UserName LIKE @UserName AND Password LIKE @Password)=1)
BEGIN
PRINT 'Login Successful'
END
END

CREATE PROCEDURE sp_Register 
(
@UserName VARCHAR(30),
@Password VARCHAR(30),
@Email VARCHAR(55),
@Street VARCHAR(30),
@City VARCHAR(30),
@State VARCHAR(30),
@Pincode NUMERIC(6),
@Country VARCHAR(30),
@PhoneNumber NUMERIC(10)
)
AS
BEGIN
INSERT INTO Registration VALUES(@UserName,@Password,@Email,@Street,@City,@State,@Pincode,@Country,@PhoneNumber)
END
SELECT * FROM Registration
DROP PROCEDURE sp_Register
DROP TABLE Registration