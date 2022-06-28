if not exists(select 1 from dbo.[Student])
begin
	insert into dbo.[Student]	(Id,FirstName,LastName,AverageRating,Grade)
	values ('0','Tim','Corey','4','5'),
	('1','Gleb','Klimenko','5','6'),
	('2','Andrey','Ivanov','2','3'),
	('3','Ivan','Andreev','3','5'),
	('4','Nastia','Cisele','2','8');

end