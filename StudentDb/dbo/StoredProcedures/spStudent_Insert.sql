CREATE PROCEDURE [dbo].[spStudent_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@AverageRating float,
	@Grade int
AS
begin
	insert into dbo.[Student] (FirstName,LastName,AverageRating,Grade)
	values(@FirstName,@LastName,@AverageRating,@Grade);
end