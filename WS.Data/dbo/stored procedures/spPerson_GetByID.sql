CREATE PROCEDURE [dbo].[spPerson_GetById]
	@Id int
as
begin
	   set nocount on;

	   select FirstName, LastName, Email
	   from dbo.Person
	   where Id = @Id
end