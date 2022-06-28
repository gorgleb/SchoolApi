CREATE PROCEDURE [dbo].[spStudent_Get]
	@Id int
AS
begin
	select Id,FirstName,LastName,AverageRating, Grade
	from dbo.[Student]
	where Id=@Id;

end