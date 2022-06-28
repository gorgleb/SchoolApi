CREATE PROCEDURE [dbo].[spStudents_ChooseTheExcellentStudents]
AS
begin
	select Id,FirstName,LastName,AverageRating, Grade
	from dbo.[Student]
	where AverageRating>3;

end