CREATE PROCEDURE [dbo].[spPerson_AddNewUser]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Email nvarchar(50)
as
begin
	   set nocount on;

	  insert into dbo.Person 
	  values (@FirstName, @LastName, @Email)
end