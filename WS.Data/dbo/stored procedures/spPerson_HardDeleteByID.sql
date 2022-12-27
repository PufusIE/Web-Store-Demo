CREATE PROCEDURE [dbo].[spPerson_HardDeleteById]
	@Id int
	
AS
	set nocount on;

	delete from dbo.Person
	where (Id = @Id)

RETURN 
																