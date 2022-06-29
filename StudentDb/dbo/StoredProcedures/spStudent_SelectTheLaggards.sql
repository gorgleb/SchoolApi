CREATE PROCEDURE [dbo].[spStudent_SelectTheLaggards]
AS
begin
	select Id,FirstName,LastName,AverageRating, Grade
	from dbo.[Student]
	where AverageRating<4;

end