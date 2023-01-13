--create trigger AddBlogInRaytingTable
--on Blogs
--after Insert
--as 
--declare @ID int
--select @ID=BlogId from inserted
--Insert into blogRaytings (BlogID,BlogTotalScore,BlogRaytinCount)
--Values (@ID,0,0)


create trigger AddScoreinComment
on comments
after insert
as 
declare @ID int
declare @Score int
declare @RaytingCount int
select @ID=BlogId,@Score=BlogScore from inserted
update blogRaytings set BlogTotalScore=BlogTotalScore+@Score, BlogRaytinCount+=1
where BlogID=@ID