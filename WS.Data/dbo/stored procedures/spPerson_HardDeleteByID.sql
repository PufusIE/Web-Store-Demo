CREATE PROCEDURE [dbo].[spPerson_HardDeleteByID]
	@Id int = 0
	
AS
	set nocount on;

	delete from dbo.Person
	where (Id = @Id)

RETURN 
																