CREATE TABLE Registration
(
UserName VARCHAR(30),
Password VARCHAR(30)
)

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
@Password VARCHAR(30)
)
AS
BEGIN
INSERT INTO Registration VALUES(@UserName,@Password)
END
SELECT * FROM Registration

DROP TABLE Registration