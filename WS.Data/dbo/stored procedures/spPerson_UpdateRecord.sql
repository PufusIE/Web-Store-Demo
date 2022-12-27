CREATE PROCEDURE [dbo].[spPerson_UpdateRecord]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Email nvarchar(200)
AS
begin

	set nocount on;

	update dbo.Person
	set FirstName = @FirstName, LastName = @LastName, Email = @Email
	where Id = @Id

end
