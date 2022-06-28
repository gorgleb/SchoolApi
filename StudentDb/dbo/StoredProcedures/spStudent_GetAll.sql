CREATE PROCEDURE [dbo].[spStudent_GetAll]
AS
begin
	select Id,FirstName,LastName,AverageRating, Grade
	from dbo.[Student];
end