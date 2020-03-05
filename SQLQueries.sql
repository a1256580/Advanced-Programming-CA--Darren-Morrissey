CREATE TABLE [dbo].[Login_tbl] (
    [LoginID]  INT          NOT NULL,
    [UserName] VARCHAR (25) NOT NULL,
    [Password] VARCHAR (50) NOT NULL
);


CREATE TABLE [dbo].[Student_tbl] (
    [LoginID]       INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]     VARCHAR (50) NOT NULL,
    [Surname]       VARCHAR (50) NOT NULL,
    [Email]         VARCHAR (50) NOT NULL,
    [Phone]         INT          NOT NULL,
    [AddressLine1]  VARCHAR (50) NOT NULL,
    [AddressLine2]  VARCHAR (50) NOT NULL,
    [City]          VARCHAR (25) NOT NULL,
    [County]        VARCHAR (25) NOT NULL,
    [Level]         VARCHAR (25) NOT NULL,
    [Course]        VARCHAR (50) NOT NULL,
    [StudentNumber]	INT  NOT NULL,
	[ModifierInitials] VARCHAR(5) NOT NULL,
    PRIMARY KEY CLUSTERED ([LoginID] ASC)
);

GO
CREATE PROCEDURE dbo.StudentAddOrEdit
@mode nvarchar(10),
@LoginID int,
@FirstName varchar (50),
@Surname varchar (50), 
@Email	varchar (50), 
@Phone int,
@AddressLine1 varchar (50),
@AddressLine2 varchar (50),
@City varchar (25),
@County varchar(25),
@Level varchar (25),
@Course varchar(50),
@StudentNumber int,
@ModifierInitials varchar(5)

AS
	IF @mode='Add'
	BEGIN
	INSERT INTO Student_tbl

	(FirstName, Surname,Email,Phone,AddressLine1,AddressLine2,City,County,Level, Course,StudentNumber,ModifierInitials)
VALUES
	(@FirstName,
	@Surname, 
	@Email, 
	@Phone,
	@AddressLine1,
	@AddressLine2,
	@City,
	@County,
	@Level,
	@Course,
	@StudentNumber,
	@ModifierInitials)
END
ELSE IF @mode='Edit'
BEGIN 
UPDATE Student_tbl
SET 
FirstName=@FirstName, Surname=@Surname, Email=@Email,Phone=@Phone,AddressLine1=@AddressLine1,AddressLine2=@AddressLine2,City=@City, County=@County ,Level=@Level,Course=@Course, StudentNumber=@StudentNumber,ModifierInitials=@ModifierInitials
WHERE LoginID=@LoginID
END


GO
CREATE PROCEDURE dbo.StudentDeletion
	@StudentNumber int
AS
	DELETE Student_tbl
	WHERE StudentNumber=@StudentNumber


GO
CREATE PROCEDURE [dbo].[StudentViewOrSearch]
@FirstName varchar(50)
AS
	SELECT * FROM Student_tbl
	WHERE FirstName LIKE @FirstName+'%'


GO
CREATE TABLE StudentHistory(history_id	varchar (25),
history_name varchar(50),
history_studentNo	int,
modifier varchar(25),
modified_date datetime,
action varchar(15))


GO

CREATE TRIGGER [insert_history] ON Student_tbl 
FOR INSERT
AS
INSERT StudentHistory(history_name,history_studentNo,modifier,modified_date,action)
SELECT FirstName,StudentNumber,ModifierInitials ,GETDATE(), 'INSERTED' 
FROM inserted

GO
CREATE PROCEDURE [dbo].[TableHistory]
@history_name VARCHAR (50)
AS
	SELECT * FROM StudentHistory
	WHERE history_name LIKE @history_name+'%'
