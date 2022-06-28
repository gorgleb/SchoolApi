CREATE PROCEDURE [dbo].[spStudent_Update]
	@Id int	,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@AverageRating float,
	@Grade int
AS
begin
	update dbo.[Student]
	set @FirstName = @FirstName, @LastName = @LastName,@AverageRating = @AverageRating, @Grade = @Grade
	where Id = @Id;
end