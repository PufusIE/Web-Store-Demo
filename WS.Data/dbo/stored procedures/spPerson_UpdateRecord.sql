CREATE PROCEDURE [dbo].[spPerson_UpdateRecord]
	@FirstName nvarchar(50) = 0,
	@LastName nvarchar(50) = 0,
	@Email nvarchar(50) = 0
as
begin
	   set nocount on;

	  insert into dbo.Person 
	  values (@FirstName, @LastName, @Email)
end