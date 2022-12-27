CREATE PROCEDURE [dbo].[spPerson_GetByID]
	@Id int = 0
as
begin
	   set nocount on;

	   select FirstName, LastName, Email
	   from dbo.Person
	   where Id = @Id
end