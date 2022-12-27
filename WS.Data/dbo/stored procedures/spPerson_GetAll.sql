CREATE PROCEDURE [dbo].[spPerson_GetAll]
	
as
begin
	   set nocount on;

	   select FirstName, LastName, Email
	   from dbo.Person
end
